using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using MyTests.Business;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace PostToUrl
{
	public partial class ReadDealStarApi : Form
	{
		public ReadDealStarApi()
		{
			InitializeComponent();
		}


		private string GetHtml(string url)
		{
			string returnHtml = string.Empty;
			WebRequest request = WebRequest.Create(url);
			//request.Timeout = 4000;

			HttpWebResponse response = (HttpWebResponse) request.GetResponse();

			using (Stream dataStream = response.GetResponseStream())
			{
				if (dataStream != null)
					using (StreamReader reader = new StreamReader(dataStream))
					{
						returnHtml = reader.ReadToEnd();
					}
			}
			response.Close();


			return returnHtml;

		}

		private void btnReqChallenge_Click(object sender, EventArgs e)
		{
			txtResult.Text = GetHtml(txtUrl.Text + "requestChallenge?userID=" + txtUser.Text);
			JObject jObject = JObject.Parse(txtResult.Text);
			txtChallenge.Text = (string) jObject["challenge"];
		}

		private void btnConvertChallengeFromBase64_Click(object sender, EventArgs e)
		{
			txtChallengeInNormalText.Text = txtChallenge.Text.FromBase64();
		}

		private void btnSign_Click(object sender, EventArgs e)
		{
			string key = txtPass.Text;
			string message = txtChallengeInNormalText.Text;

			System.Text.ASCIIEncoding encoding = new System.Text.ASCIIEncoding();

			byte[] keyByte = encoding.GetBytes(key);

			//HMACMD5 hmacmd5 = new HMACMD5(keyByte);
			HMACSHA1 hmacsha1 = new HMACSHA1(keyByte);
			//HMACSHA256 hmacsha256 = new HMACSHA256(keyByte);
			//HMACSHA384 hmacsha384 = new HMACSHA384(keyByte);
			//HMACSHA512 hmacsha512 = new HMACSHA512(keyByte);

			byte[] messageBytes = encoding.GetBytes(message);



			byte[] hashmessage = hmacsha1.ComputeHash(messageBytes);
			txtSignedChallenge.Text = ByteToString(hashmessage).ToBase64();

		}

		public static string ByteToString(byte[] buff)
		{
			string sbinary = "";

			for (int i = 0; i < buff.Length; i++)
			{
				sbinary += buff[i].ToString("X2"); // hex format
			}
			return (sbinary);
		}

		private void btnGetDelta_Click(object sender, EventArgs e)
		{
			txtResult.Text = GetHtml(txtUrl.Text + "genericItemLoadUpdate?changesSince=2012-07-01" + "&userID=" + txtUser.Text + "&token=" + txtToken.Text);
		}

		private void btnGetActiveDeals_Click(object sender, EventArgs e)
		{
			txtResult.Text = GetHtml(txtUrl.Text + "activeCoupons?userID=" + txtUser.Text + "&token=" + txtToken.Text);
		}

		private void btnGetToken_Click(object sender, EventArgs e)
		{
			txtResult.Text = GetHtml(txtUrl.Text + "authenticate?userID=" + txtUser.Text + "&response=" + txtSignedChallenge.Text);
			JObject jObject = JObject.Parse(txtResult.Text);
			txtToken.Text = (string)jObject["token"];
		}

		private void btnActiveToJson_Click(object sender, EventArgs e)
		{
			string myString = string.Empty;
			using (StreamReader myFile = new StreamReader("activeDeals.txt"))
			{
				myString = myFile.ReadToEnd();
			}

			ActiveCouponsResponse obj = JsonConvert.DeserializeObject<ActiveCouponsResponse>(myString);
			txtResult.Text = JsonConvert.DeserializeXmlNode(myString,"test").OuterXml;

		}

		private void btnDealsToJSON_Click(object sender, EventArgs e)
		{
			string myString = string.Empty;
			using (StreamReader myFile = new StreamReader("Deals.txt"))
			{
				myString = myFile.ReadToEnd();
			}

			GutscheinbuchDealResponse obj = JsonConvert.DeserializeObject<GutscheinbuchDealResponse>(myString);

			//dynamic obj2 = JsonConvert.DeserializeObject<dynamic>(myString);
			JObject jObject = JObject.Parse(myString);
			txtResult.Text = (string)jObject["coupons"][0]["uid"];

			txtResult.Text = JsonConvert.DeserializeXmlNode(myString, "test").OuterXml;
			//use reflection to get properties...?
		}
	}

}