using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PostToUrl
{
	public partial class testForm : Form
	{
		public testForm()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			dynamic d = new ExpandoObject();
			d.name = "test";
			MessageBox.Show(d.blame);
		}
	}
}
