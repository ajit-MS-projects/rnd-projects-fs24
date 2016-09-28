using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace sqliteTest
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			// Create sqlite connection
			SQLiteConnection connection = new SQLiteConnection(string.Format(
			@"Data Source={0}\testdb.db",
			Environment.CurrentDirectory));

			// Open sqlite connection
			connection.Open();

			// Get all rows from example_table
			SQLiteDataAdapter db = new SQLiteDataAdapter("SELECT * FROM tt", connection);

			// Create a dataset
			DataSet ds = new DataSet();

			// Fill dataset
			db.Fill(ds);

			// Create a datatable
			DataTable dt = new DataTable("Names");
			dt = ds.Tables[0];

			// Close connection
			connection.Close();

			// Print table
			foreach (DataRow row in dt.Rows)
			{
				textBox1.Text += string.Format("{0} {1}", row["one"], Environment.NewLine);
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			using (var db = new UsersContext())
			{
				tt t = new tt();
				t.one = "eee";
				db.tts.Add(t);
				db.SaveChanges();

				//Emp ee = new Emp();
				//ee.Name = "Ajit";
				//ee.Salary = "45000";
				//db.AddToEmpSet(ee);
				//db.SaveChanges();
			}
		}
	}
}
