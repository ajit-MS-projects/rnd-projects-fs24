using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Ajit.DetectMyIp
{
	public class FileManager
	{
		public static void CreateIpFile(string ipAddress)
		{
			string path = @"d:\skydrive";
			if(!Directory.Exists(path))
			{
				Directory.CreateDirectory(path);
			}
			using (StreamWriter sw = File.CreateText(path+@"\my.txt"))
			{
				sw.WriteLine(ipAddress);
			}	
		}
		public static void CreateErrorFile(string ipAddress)
		{
			string path = @"d:\skydrive";
			if (!Directory.Exists(path))
			{
				Directory.CreateDirectory(path);
			}
			using (StreamWriter sw = File.CreateText(path + @"\my_Errors.txt"))
			{
				sw.WriteLine(ipAddress);
			}
		}
	}
}
