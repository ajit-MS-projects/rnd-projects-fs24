using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Cryptography;
using System.Text;
using System.Web.Http;
using System.Web.Mvc;
using AES.Encrypt.Models;

namespace AES.Encrypt.Controllers
{
	public class HomeController : Controller
	{
		public static AesModel Model;
		public ActionResult Index()
		{
			return View(Model);
		}
		[ValidateInput(false)]
		[System.Web.Mvc.HttpPost]
		public ActionResult Index(AesModel model)
		{
			Model = model;
			Model.EncryptedText = Encrypt(model.Text);
			return RedirectToAction("Index");
		}
		public ActionResult Decrypt()
		{
			return View(Model);
		}
		[ValidateInput(false)]
		[System.Web.Mvc.HttpPost]
		public ActionResult Decrypt(AesModel model)
		{
			Model = model;
			Model.Text = Decrypt(model.EncryptedText);
			return RedirectToAction("Decrypt");
		}

		private string Encrypt(string clearText)
		{
			string EncryptionKey = Model.Password;
			byte[] clearBytes = Encoding.Unicode.GetBytes(clearText);
			using (Aes encryptor = Aes.Create())
			{
				Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey,
				                                                new byte[]
					                                                {
						                                                0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64,
						                                                0x65, 0x76
					                                                });
				encryptor.Key = pdb.GetBytes(32);
				encryptor.IV = pdb.GetBytes(16);
				using (MemoryStream ms = new MemoryStream())
				{
					using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateEncryptor(), CryptoStreamMode.Write))
					{
						cs.Write(clearBytes, 0, clearBytes.Length);
						cs.Close();
					}
					clearText = Convert.ToBase64String(ms.ToArray());
				}
			}
			return clearText;
		}

		private string Decrypt(string cipherText)
		{
			try
			{
				string EncryptionKey = Model.Password;
				byte[] cipherBytes = Convert.FromBase64String(cipherText);
				using (Aes encryptor = Aes.Create())
				{
					Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey,
																	new byte[]
					                                                {
						                                                0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64,
						                                                0x65, 0x76
					                                                });
					encryptor.Key = pdb.GetBytes(32);
					encryptor.IV = pdb.GetBytes(16);
					using (MemoryStream ms = new MemoryStream())
					{
						using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateDecryptor(), CryptoStreamMode.Write))
						{
							cs.Write(cipherBytes, 0, cipherBytes.Length);
							cs.Close();
						}
						cipherText = Encoding.Unicode.GetString(ms.ToArray());
					}
				}
				return cipherText;
			}
			catch (Exception ex)
			{
				return "Invalid Password. :: " + ex.Message;
			}
		}
	}
}
