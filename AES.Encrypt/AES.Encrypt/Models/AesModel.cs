using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AES.Encrypt.Models
{
	public class AesModel
	{
		[Required]
		public string Password { get; set; }
		[Required]
		public string Text { get; set; }
		[Required]
		public string EncryptedText { get; set; }
	}
}