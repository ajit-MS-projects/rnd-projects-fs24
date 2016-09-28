using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace PostToUrl
{
	public static class Utility
	{
		public static string ToBase64(this string inputString)
		{
			if (!string.IsNullOrEmpty(inputString))
			{
				byte[] txtByte = Encoding.Default.GetBytes(inputString);
				string txt64 = Convert.ToBase64String(txtByte);
				return txt64;
			}

			return string.Empty;
		}

		public static string FromBase64(this string inputString)
		{
			if (!string.IsNullOrEmpty(inputString))
			{
				byte[] txtByte64 = Convert.FromBase64String(inputString);
				string txt = Encoding.Default.GetString(txtByte64);
				return txt;
			}

			return string.Empty;
		}
		public static string GetMd5HashBytes(string strInput)
        {
            ASCIIEncoding encoder = new ASCIIEncoding();

            Byte[] _secretBytes = encoder.GetBytes(strInput);
            MD5 md5 = MD5.Create();
            Byte[] computedHash = md5.ComputeHash(_secretBytes);
            string mystring = "";
            foreach (byte b in computedHash)
            {
                String tmp = b.ToString("x");
                if (tmp.Length == 1) tmp = "0" + tmp;
                mystring += tmp;
            }
            return mystring;
        }
	}
	 
}
