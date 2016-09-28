using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StringFormatting
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			string s = "{0} This is a {1} test";
			string ss = string.Format(s, "dsfdf","{0}");
			MessageBox.Show(ss);
			ss = string.Format(ss, "Ajit");
			MessageBox.Show(ss);
			ss = string.Format(ss, "Ajit");
			MessageBox.Show(ss);
		}

		private void button2_Click(object sender, EventArgs e)
		{
			string s = "xyz" + Environment.NewLine + "dsffd";
			MessageBox.Show(s);
			MessageBox.Show(s.RemoveCrAndLf());
		}

	}
	public static class ss
	{
		public static string RemoveCrAndLf(this string s)
		{
			if (!string.IsNullOrWhiteSpace(s))
			{
				s = s.Replace('\r', ' ');
				s = s.Replace('\n', ' ');
			}

			return s;
		}
	}
}
