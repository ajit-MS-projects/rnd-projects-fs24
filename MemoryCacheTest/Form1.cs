using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Caching;
using System.Text;
using System.Windows.Forms;

namespace MemoryCacheTest
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		MemoryCache mc = MemoryCache.Default;
		private void button1_Click(object sender, EventArgs e)
		{
			CacheItem ci = new CacheItem("mykey",DateTime.Now);
			CacheItemPolicy cp = new CacheItemPolicy();
			cp.AbsoluteExpiration = DateTime.Now.AddSeconds(30);
			mc.Add(ci, cp);
		}

		private void button2_Click(object sender, EventArgs e)
		{
			MessageBox.Show(mc.Contains("mykey")? mc.Get("mykey").ToString():"");
		}
	}
}
