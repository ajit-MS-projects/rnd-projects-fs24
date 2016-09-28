using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;

namespace Ajit.DetectMyIp.Service
{
	public class ServiceController
	{
		public Timer Timer { get; set; }
		public void Start()
		{
			if (Timer == null)
			{
				Timer = new Timer { Interval = 1000 };
				Timer.Elapsed += (sender, args) => this.TimerHandler();
			}
			Timer.Enabled = true;
			Timer.Start();
		}

		private void TimerHandler()
		{
			try
			{
				Timer.Enabled = false;
				Timer.Interval = 5*60*1000;
				FileManager.CreateIpFile(IpDetectService.GetMyIp());
				Timer.Enabled = true;
			}
			catch (Exception ex)
			{
				FileManager.CreateErrorFile(ex.ToString());
			}
		}

		public void Stop()
		{
			Timer.Enabled = false;
		}
	}
}
