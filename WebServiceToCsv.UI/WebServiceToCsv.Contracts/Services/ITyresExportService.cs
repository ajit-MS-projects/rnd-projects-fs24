using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WebServiceToCsv.Contracts.Services
{
	public interface ITyresExportService
	{
		IMapping GetMapping(int id);
		List<IMapping> GetMappings();
		List<IMapping> GetMappings(int exportId);
		void SaveMapping(IMapping mapping);

		ISavedGetTyreRequest GetSavedTyreRequest(int id);
		List<ISavedGetTyreRequest> GetSavedTyreRequests();
		List<ISavedGetTyreRequest> GetSavedTyreRequests(int exportId);
		void SaveTyreRequest(ISavedGetTyreRequest getTyreRequest);

		IExportSettings GetExportSetting(int id);
		List<IExportSettings> GetExportSettings();
		void SaveExportSettings(IExportSettings exportSetting);

		void ExportCsv(int exportId);
		List<IMapping> GetDefaultMappings(int exportId);
		IExportSettings GetDefaultExportSettings();
	}
}
