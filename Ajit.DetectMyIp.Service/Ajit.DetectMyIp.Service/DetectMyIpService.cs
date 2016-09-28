using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;

namespace Ajit.DetectMyIp.Service
{
	partial class DetectMyIpService : ServiceBase
	{
		private ServiceController ServiceController { get; set; }
		public DetectMyIpService()
		{
			InitializeComponent();
		}
		[Conditional("DEBUG")]
		private void DebugMode()
		{
			Debugger.Launch();
		}

		protected override void OnStart(string[] args)
		{
			try
			{
				DebugMode();
				this.ServiceController = new ServiceController();
				this.ServiceController.Start();

				this.EventLog.WriteEntry("Ip Detect Service started.", EventLogEntryType.Information);
			}
			catch (Exception exception)
			{
				EventLog.WriteEntry(exception.ToString(), EventLogEntryType.Error);
				OnStop();
			}
		}

		protected override void OnStop()
		{
			if (this.ServiceController != null)
			{
				this.ServiceController.Stop();
			}
		}
	}
}
