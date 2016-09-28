using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace PostToUrl
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void btnPost_Click(object sender, EventArgs e)
		{
			var req = (HttpWebRequest)WebRequest.Create(txtUrl.Text);
			req.KeepAlive = false;
			req.UserAgent = "Sparacuda";
			req.Method = "POST";
			req.ContentType = txtContentType.Text;

			byte[] data = Encoding.ASCII.GetBytes(txtContent.Text);
			req.ContentLength = data.Length;
			using (var input = req.GetRequestStream())
			{
				input.Write(data, 0, data.Length);
			}

			
		}
	}
}
