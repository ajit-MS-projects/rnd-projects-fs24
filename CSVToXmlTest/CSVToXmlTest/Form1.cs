using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using FileHelpers;
using Newtonsoft.Json;

namespace CSVToXmlTest
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Root r = new Root();
			Product p = new Product() {Id = 1, Title = "Samsung Tv", Description = "sams tv desc"};
			r.Products.Add(p);
			r.Products.Add(new Product() { Id = 2, Title = "Samsung Tv 2", Description = "sams tv desc 2" });
			r.Products.Add(new Product() { Id = 3, Title = "Samsung Tv 3", Description = "sams tv desc 3" });
			string json = JsonConvert.SerializeObject(r);
			XmlDocument doc = (XmlDocument)JsonConvert.DeserializeXmlNode(json,"Products");
			string s = doc.OuterXml;

			s = s;
		}

		private void button2_Click(object sender, EventArgs e)
		{
			System.IO.StreamReader myFile = new System.IO.StreamReader("AffiliSearchProducts.json");
			string json = myFile.ReadToEnd();

			myFile.Close();
			XmlDocument doc = (XmlDocument)JsonConvert.DeserializeXmlNode(json,"Root");
			string s = doc.OuterXml;

			s = s;
		}

		private void btnCsv_Click(object sender, EventArgs e)
		{
			System.IO.StreamReader myFile = new System.IO.StreamReader("AffilinetProductsSmall.csv");
			//string json = myFile.ReadToEnd();

			//myFile.Close();


			var lines = File.ReadAllLines("AffilinetProductsSmall.csv");

			string[] headers = lines[0].Split(';').Select(x => x.Trim('\"')).ToArray();

			var xml = new XElement("TopElement",
			   lines.Where((line, index) => index > 0).Select(line => new XElement("Item",
				  line.Split(';').Select((column, index) => new XElement(headers[index], column)))));


			string s = xml.ToString();
			xml.Save(@"C:\xmlout.xml");
			
		}

		private void csv2_Click(object sender, EventArgs e)
		{
				FileHelperEngine engine = new FileHelperEngine(typeof(object)); 
	 
				// to Read use: 
				object[] res = engine.ReadFile("AffilinetProductsSmall.csv") as object[]; 
	 
				// to Write use: 
				engine.WriteFile("TestOut.txt", res); 
		}
	}
	public class Root
	{
		public List<Product> Products = new List<Product>();
	}
	public class Product
	{
		public int Id { get; set; }
		public string Title { get; set; }
		public string Description { get; set; }
	}
}
