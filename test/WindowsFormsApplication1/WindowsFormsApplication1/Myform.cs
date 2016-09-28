using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary1;

namespace WindowsFormsApplication1
{
	public partial class Myform : Form
	{
		public Myform()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			NameCLass c = new NameCLass();
			MessageBox.Show(c.GetNAme());
		}
	}
}
