namespace CSVToXmlTest
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.btnCsv = new System.Windows.Forms.Button();
			this.csv2 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(78, 51);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 0;
			this.button1.Text = "button1";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(159, 51);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 1;
			this.button2.Text = "button2";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// btnCsv
			// 
			this.btnCsv.Location = new System.Drawing.Point(13, 163);
			this.btnCsv.Name = "btnCsv";
			this.btnCsv.Size = new System.Drawing.Size(75, 23);
			this.btnCsv.TabIndex = 2;
			this.btnCsv.Text = "CSV";
			this.btnCsv.UseVisualStyleBackColor = true;
			this.btnCsv.Click += new System.EventHandler(this.btnCsv_Click);
			// 
			// csv2
			// 
			this.csv2.Location = new System.Drawing.Point(118, 163);
			this.csv2.Name = "csv2";
			this.csv2.Size = new System.Drawing.Size(75, 23);
			this.csv2.TabIndex = 3;
			this.csv2.Text = "CSV2";
			this.csv2.UseVisualStyleBackColor = true;
			this.csv2.Click += new System.EventHandler(this.csv2_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 262);
			this.Controls.Add(this.csv2);
			this.Controls.Add(this.btnCsv);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button btnCsv;
		private System.Windows.Forms.Button csv2;
	}
}

