using System;
using System.Collections.Generic;
using System.Linq;
using System.Timers;
using System.Windows.Forms;
using SolarSchmiede.WindowsServiceUtils;
using Timer = System.Timers.Timer;

namespace Solarschmiede.WindowsServicesManager
{
	public partial class frmPvscoutServiceStatus : Form
	{
		private string[] ServiceNames = new string[] { "PVscoutWindowsService", "PlatinumWindowsService" };//note: can be transferred to app.config if needed.
		private Timer timer;
		private bool FirstRun = true;
		private SolarSchmiede.WindowsServiceUtils.WindowsServicesManager WinServiceMgr { get; set; }
		public frmPvscoutServiceStatus()
		{
			InitializeComponent();
			WinServiceMgr = new SolarSchmiede.WindowsServiceUtils.WindowsServicesManager(ServiceNames);
			timer = new Timer {Interval = 100};
			timer.Elapsed += TimerElapsed;
			timer.Enabled = true;
			
		}

		void TimerElapsed(object sender, ElapsedEventArgs e)
		{
			timer.Enabled = false;
			
			List<WindowsService> windowsService = WinServiceMgr.StartServices();
			if (FirstRun)
			{
				ShowBalloonMessage(windowsService);
				FirstRun = false;
			}
			gvServiceStatus.DataSource = windowsService;
			timer.Interval = 120 * 1000;//will check if services are running every 2 minutes, if not will try to start the services
			timer.Enabled = true;
		}

		private void ShowBalloonMessage(List<WindowsService>  windowsService)
		{
			string message = windowsService.Any(x => x.Status != "Running")
					                 ? "PVscout Services could not be started."
					                 : "PVscout Services started successfully.";
				notifyIcon.ShowBalloonTip(5000, "PVscout", message, new ToolTipIcon());
		}

		private void NotifyIconDoubleClick(object sender, EventArgs e)
		{
			if (!FirstRun)
			{
				this.Show();
				this.WindowState = FormWindowState.Normal;
			}
		}

		private void FrmPvscoutServiceStatusDeactivate(object sender, EventArgs e)
		{
			if (this.WindowState == FormWindowState.Minimized)
			{
				this.Hide();
			}
		}

		private void BtnRestartServicesClick(object sender, EventArgs e)
		{
			timer.Enabled = false;
			WinServiceMgr.StopServices();
			FirstRun = true;
			ShowBalloonMessage(WinServiceMgr.StartServices());
			timer.Enabled = true;
		}

		private void FrmPvscoutServiceStatusFormClosing(object sender, FormClosingEventArgs e)
		{
			e.Cancel = true;
			this.Hide();
		}

	}
}
