using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.ServiceProcess;
using System.Text;

namespace WinServiceInstallerTest
{
	public partial class Service1 : ServiceBase
	{
		private System.Threading.Timer timer1;
		public Service1()
		{
			InitializeComponent();
		}

		protected override void OnStart(string[] args)
		{
		}

		protected override void OnStop()
		{
		}

		private void timer1_Tick(object sender)
		{
			using (TextWriter tw = new StreamWriter(@"d:\date.txt",true))
			{
				tw.WriteLine(DateTime.Now);
				tw.Close();
			}
		}

	}
}
