using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceProcess;

namespace SolarSchmiede.WindowsServiceUtils
{
    public class WindowsServicesManager
    {
		private List<WindowsService> WindowsServices { get; set; }
		
		public WindowsServicesManager(IEnumerable<string> serviceNames)
		{
			WindowsServices = new List<WindowsService>();
			foreach (var serviceName in serviceNames)
			{
				WindowsServices.Add(new WindowsService() { ServiceName = serviceName , Status = "Unknown"});
			}
		}

		public WindowsServicesManager(List<WindowsService> windowsServices)
		{
			this.WindowsServices = windowsServices;
		}

	    public List<WindowsService> StartServices()
	    {
		    return ChangeServicesState(true);
	    }
		public List<WindowsService> StopServices()
		{
			return ChangeServicesState(false);
		}
		private List<WindowsService> ChangeServicesState(bool start)
		{

			var sysServices = ServiceController.GetServices();
			foreach (var windowsService in WindowsServices)
			{
				var serviceController = sysServices.FirstOrDefault(x => x.ServiceName == windowsService.ServiceName);
				if (serviceController == null)
				{
					windowsService.Status = "Not Found";
				}
				else
				{
					if (serviceController.Status != ServiceControllerStatus.Running)
					{
						if (start) serviceController.Start(); else serviceController.Stop();
						serviceController.WaitForStatus(start ? ServiceControllerStatus.Running:ServiceControllerStatus.Stopped, TimeSpan.FromSeconds(5));//wait for service to start for max 5 secs
					}
					windowsService.Status = serviceController.Status.ToString();
				}
			}

			return WindowsServices;
		}
    }
}
