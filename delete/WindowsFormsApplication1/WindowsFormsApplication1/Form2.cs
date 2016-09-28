using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
	public partial class Form2 : Form
	{
		public Form2()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			List<String> s = new List<string>();
			while (true)
			{
				s.Add("abcdefghijklmnopqrstuvwxyz" + DateTime.Now.ToString(CultureInfo.InvariantCulture));
			}
		}
	}
}
