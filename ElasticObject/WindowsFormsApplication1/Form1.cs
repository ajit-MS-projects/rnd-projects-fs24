using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using AmazedSaint.Elastic;
using AmazedSaint.Elastic.Lib;

namespace WindowsFormsApplication1
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			var xDocument = XDocument.Load(@"books.xml");
			// convert the xml into string (did not get why do you want to do this)
			string xml = xDocument.ToString();
			MessageBox.Show(xml);

			dynamic books = XElement.Parse(xml).ToElastic();
			foreach (var book in books["book"])
			{
				
				MessageBox.Show(book.id);
				MessageBox.Show(book.author.InternalContent);
			}

		}

		private void button2_Click(object sender, EventArgs e)
		{
			xx x = new xx();

			List<Emp> emp = new List<Emp>();
			var ee = new Emp();
			ee.Ids.Add("1");
			ee.Ids.Add("11");
			emp.Add(ee);
			ee = new Emp();
			ee.Ids.Add("2");
			ee.Ids.Add("22");
			ee.Ids.Add("22");
			emp.Add(ee);
			ee = new Emp();
			ee.Ids.Add("3");
			emp.Add(ee);
			ee = new Emp();
			ee.Ids.Add("4");
			emp.Add(ee);

			int cnt = emp.Sum(emp1 => emp1.Ids.Count());


			MessageBox.Show(cnt.ToString());
		}
	}
	public class Emp
	{
		public List<string>  Ids = new List<string>();
	}

	class xx
	{
		public List<Emp> MyEmp { get; set; }
	}
}
