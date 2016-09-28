using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace ReflectionForms
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			var activeDealIds =  Activator.CreateInstance("MyTests.Business", "MyTests.Business.ActiveCouponsResponse");
			dynamic deals = Activator.CreateInstance("MyTests.Business", "MyTests.Business.GutscheinbuchDealResponse").Unwrap();
			deals.apiVersion = "33";


			string myString = string.Empty;
			using (StreamReader myFile = new StreamReader("Deals.txt"))
			{
				myString = myFile.ReadToEnd();
			}

			var obj = JsonConvert.DeserializeObject<String>(myString);

		}
	}
}
