using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceModel;
using System.ServiceProcess;
using System.Text;
using System.Timers;

namespace WcfSessionWinServiceHost
{
	public partial class Service1 : ServiceBase
	{
		public Service1()
		{
			InitializeComponent();
		}
		public Timer Timer { get; set; }
		protected override void OnStart(string[] args)
		{
			if (Timer == null)
			{
				Timer = new Timer { Interval = 1000 };
				Timer.Elapsed += (sender,args1) => this.TimerHandler();
			}
			Timer.Start();
		}
		private void TimerHandler()
		{
			Timer.Stop();
			using (ServiceHost host = new ServiceHost(typeof(WcfSession.Service1)))
			{
				host.Open();
				Console.WriteLine("Service Started... at http://localhost:62476 and net.tcp://localhost:62477");
				Console.WriteLine("Press enter to stop the service.");
				Console.ReadLine();
			}
		}

		protected override void OnStop()
		{
		}
	}
}
