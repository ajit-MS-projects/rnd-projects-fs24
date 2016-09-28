namespace PostToUrl
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.btnPost = new System.Windows.Forms.Button();
			this.txtContent = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtUrl = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtContentType = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// btnPost
			// 
			this.btnPost.Location = new System.Drawing.Point(74, 502);
			this.btnPost.Name = "btnPost";
			this.btnPost.Size = new System.Drawing.Size(578, 23);
			this.btnPost.TabIndex = 0;
			this.btnPost.Text = "Post";
			this.btnPost.UseVisualStyleBackColor = true;
			this.btnPost.Click += new System.EventHandler(this.btnPost_Click);
			// 
			// txtContent
			// 
			this.txtContent.Location = new System.Drawing.Point(74, 79);
			this.txtContent.Multiline = true;
			this.txtContent.Name = "txtContent";
			this.txtContent.Size = new System.Drawing.Size(578, 417);
			this.txtContent.TabIndex = 2;
			this.txtContent.Text = resources.GetString("txtContent.Text");
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(28, 82);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(47, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "Content:";
			// 
			// txtUrl
			// 
			this.txtUrl.Location = new System.Drawing.Point(77, 27);
			this.txtUrl.Name = "txtUrl";
			this.txtUrl.Size = new System.Drawing.Size(575, 20);
			this.txtUrl.TabIndex = 1;
			this.txtUrl.Text = "http://www.sparacuda.loc/callback/defensio";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(43, 30);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(32, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "URL:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(1, 56);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(74, 13);
			this.label3.TabIndex = 6;
			this.label3.Text = "Content Type:";
			// 
			// txtContentType
			// 
			this.txtContentType.Location = new System.Drawing.Point(77, 53);
			this.txtContentType.Name = "txtContentType";
			this.txtContentType.Size = new System.Drawing.Size(575, 20);
			this.txtContentType.TabIndex = 5;
			this.txtContentType.Text = "text/xml";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(656, 530);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtContentType);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtContent);
			this.Controls.Add(this.txtUrl);
			this.Controls.Add(this.btnPost);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnPost;
		private System.Windows.Forms.TextBox txtContent;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtUrl;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtContentType;
	}
}

