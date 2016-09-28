using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Windows.Forms;
using WindowsFormsApplication1.ServiceReference1;

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
			Service1Client httpclient = new Service1Client("WSHttpBinding_IService1");
			var ret = httpclient.GetData();

			MessageBox.Show(ret);
		}

		private void button2_Click(object sender, EventArgs e)
		{
			Service1Client httpclient = new Service1Client("NetTcpBinding_IService1");
			var ret = httpclient.GetData();

			MessageBox.Show(ret);
		}
	}
}
