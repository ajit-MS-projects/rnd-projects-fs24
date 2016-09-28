using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLog;

namespace Services
{
	public static class LogService
	{
		private static Logger DebugLogger;
		private static Logger InfoLogger;
		private static Logger WarningLogger;
		private static Logger ErrorLogger;

		static LogService()
		{
			DebugLogger = LogManager.GetLogger("Debug");
			InfoLogger = LogManager.GetLogger("Info");
			WarningLogger = LogManager.GetLogger("Warning");
			ErrorLogger = LogManager.GetLogger("Error");
		}
		public static void LogError(Exception ex, string message)
		{
			ErrorLogger.Error("{0}\n{1}",ex.ToString(),message);
		}
	}
}
