namespace PostToUrl
{
	partial class ReadDealStarApi
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
			this.btnGetDelta = new System.Windows.Forms.Button();
			this.txtUrl = new System.Windows.Forms.TextBox();
			this.txtUser = new System.Windows.Forms.TextBox();
			this.txtPass = new System.Windows.Forms.TextBox();
			this.txtResult = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txtChallenge = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.btnReqChallenge = new System.Windows.Forms.Button();
			this.btnConvertChallengeFromBase64 = new System.Windows.Forms.Button();
			this.txtChallengeInNormalText = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.txtSignedChallenge = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.btnSign = new System.Windows.Forms.Button();
			this.btnGetActiveDeals = new System.Windows.Forms.Button();
			this.txtToken = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.btnGetToken = new System.Windows.Forms.Button();
			this.btnActiveToJson = new System.Windows.Forms.Button();
			this.btnDealsToJSON = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnGetDelta
			// 
			this.btnGetDelta.Location = new System.Drawing.Point(661, 232);
			this.btnGetDelta.Name = "btnGetDelta";
			this.btnGetDelta.Size = new System.Drawing.Size(317, 23);
			this.btnGetDelta.TabIndex = 0;
			this.btnGetDelta.Text = "Get Deals";
			this.btnGetDelta.UseVisualStyleBackColor = true;
			this.btnGetDelta.Click += new System.EventHandler(this.btnGetDelta_Click);
			// 
			// txtUrl
			// 
			this.txtUrl.Location = new System.Drawing.Point(91, 1);
			this.txtUrl.Name = "txtUrl";
			this.txtUrl.Size = new System.Drawing.Size(564, 20);
			this.txtUrl.TabIndex = 1;
			this.txtUrl.Text = "http://www.gutscheinbuch.de/webapi/";
			// 
			// txtUser
			// 
			this.txtUser.Location = new System.Drawing.Point(91, 27);
			this.txtUser.Name = "txtUser";
			this.txtUser.Size = new System.Drawing.Size(363, 20);
			this.txtUser.TabIndex = 1;
			this.txtUser.Text = "380585796";
			// 
			// txtPass
			// 
			this.txtPass.Location = new System.Drawing.Point(91, 251);
			this.txtPass.Name = "txtPass";
			this.txtPass.Size = new System.Drawing.Size(363, 20);
			this.txtPass.TabIndex = 1;
			this.txtPass.Text = "13A8EF19C5882A7F21A7EEDECDD76AA5059EE935";
			// 
			// txtResult
			// 
			this.txtResult.Location = new System.Drawing.Point(91, 279);
			this.txtResult.Multiline = true;
			this.txtResult.Name = "txtResult";
			this.txtResult.Size = new System.Drawing.Size(887, 439);
			this.txtResult.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(52, 3);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(20, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Url";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(37, 27);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(41, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "User Id";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(19, 254);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(53, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "Password";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(39, 282);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(39, 13);
			this.label4.TabIndex = 2;
			this.label4.Text = "Output";
			// 
			// txtChallenge
			// 
			this.txtChallenge.Location = new System.Drawing.Point(91, 62);
			this.txtChallenge.Name = "txtChallenge";
			this.txtChallenge.Size = new System.Drawing.Size(564, 20);
			this.txtChallenge.TabIndex = 1;
			this.txtChallenge.Text = "PC0xMDcxMjI3MDkuMTM0MjcwNTg2MTMwMkB3d3cuZ3V0c2NoZWluYnVjaC5kZT4=";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(25, 65);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(68, 13);
			this.label5.TabIndex = 2;
			this.label5.Text = "O: Challenge";
			// 
			// btnReqChallenge
			// 
			this.btnReqChallenge.Location = new System.Drawing.Point(661, 88);
			this.btnReqChallenge.Name = "btnReqChallenge";
			this.btnReqChallenge.Size = new System.Drawing.Size(317, 23);
			this.btnReqChallenge.TabIndex = 0;
			this.btnReqChallenge.Text = "Request Challenge";
			this.btnReqChallenge.UseVisualStyleBackColor = true;
			this.btnReqChallenge.Click += new System.EventHandler(this.btnReqChallenge_Click);
			// 
			// btnConvertChallengeFromBase64
			// 
			this.btnConvertChallengeFromBase64.Location = new System.Drawing.Point(661, 117);
			this.btnConvertChallengeFromBase64.Name = "btnConvertChallengeFromBase64";
			this.btnConvertChallengeFromBase64.Size = new System.Drawing.Size(317, 23);
			this.btnConvertChallengeFromBase64.TabIndex = 0;
			this.btnConvertChallengeFromBase64.Text = "Convert Challenge from Base64";
			this.btnConvertChallengeFromBase64.UseVisualStyleBackColor = true;
			this.btnConvertChallengeFromBase64.Click += new System.EventHandler(this.btnConvertChallengeFromBase64_Click);
			// 
			// txtChallengeInNormalText
			// 
			this.txtChallengeInNormalText.Location = new System.Drawing.Point(91, 91);
			this.txtChallengeInNormalText.Name = "txtChallengeInNormalText";
			this.txtChallengeInNormalText.Size = new System.Drawing.Size(564, 20);
			this.txtChallengeInNormalText.TabIndex = 1;
			this.txtChallengeInNormalText.Text = "<-107122709.1342705861302@www.gutscheinbuch.de>";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(7, 98);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(78, 13);
			this.label6.TabIndex = 2;
			this.label6.Text = "TXT Challenge";
			// 
			// txtSignedChallenge
			// 
			this.txtSignedChallenge.Location = new System.Drawing.Point(91, 117);
			this.txtSignedChallenge.Name = "txtSignedChallenge";
			this.txtSignedChallenge.Size = new System.Drawing.Size(564, 20);
			this.txtSignedChallenge.TabIndex = 1;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(4, 120);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(89, 13);
			this.label7.TabIndex = 2;
			this.label7.Text = "Signed challenge";
			// 
			// btnSign
			// 
			this.btnSign.Location = new System.Drawing.Point(661, 146);
			this.btnSign.Name = "btnSign";
			this.btnSign.Size = new System.Drawing.Size(317, 23);
			this.btnSign.TabIndex = 0;
			this.btnSign.Text = "Sign Challenge with key";
			this.btnSign.UseVisualStyleBackColor = true;
			this.btnSign.Click += new System.EventHandler(this.btnSign_Click);
			// 
			// btnGetActiveDeals
			// 
			this.btnGetActiveDeals.Location = new System.Drawing.Point(661, 203);
			this.btnGetActiveDeals.Name = "btnGetActiveDeals";
			this.btnGetActiveDeals.Size = new System.Drawing.Size(317, 23);
			this.btnGetActiveDeals.TabIndex = 0;
			this.btnGetActiveDeals.Text = "Get active Deals";
			this.btnGetActiveDeals.UseVisualStyleBackColor = true;
			this.btnGetActiveDeals.Click += new System.EventHandler(this.btnGetActiveDeals_Click);
			// 
			// txtToken
			// 
			this.txtToken.Location = new System.Drawing.Point(91, 143);
			this.txtToken.Name = "txtToken";
			this.txtToken.Size = new System.Drawing.Size(564, 20);
			this.txtToken.TabIndex = 1;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(40, 146);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(38, 13);
			this.label8.TabIndex = 2;
			this.label8.Text = "Token";
			// 
			// btnGetToken
			// 
			this.btnGetToken.Location = new System.Drawing.Point(661, 175);
			this.btnGetToken.Name = "btnGetToken";
			this.btnGetToken.Size = new System.Drawing.Size(317, 23);
			this.btnGetToken.TabIndex = 0;
			this.btnGetToken.Text = "Get Token";
			this.btnGetToken.UseVisualStyleBackColor = true;
			this.btnGetToken.Click += new System.EventHandler(this.btnGetToken_Click);
			// 
			// btnActiveToJson
			// 
			this.btnActiveToJson.Location = new System.Drawing.Point(1009, 282);
			this.btnActiveToJson.Name = "btnActiveToJson";
			this.btnActiveToJson.Size = new System.Drawing.Size(115, 23);
			this.btnActiveToJson.TabIndex = 3;
			this.btnActiveToJson.Text = "Active to JSON";
			this.btnActiveToJson.UseVisualStyleBackColor = true;
			this.btnActiveToJson.Click += new System.EventHandler(this.btnActiveToJson_Click);
			// 
			// btnDealsToJSON
			// 
			this.btnDealsToJSON.Location = new System.Drawing.Point(1009, 321);
			this.btnDealsToJSON.Name = "btnDealsToJSON";
			this.btnDealsToJSON.Size = new System.Drawing.Size(115, 23);
			this.btnDealsToJSON.TabIndex = 3;
			this.btnDealsToJSON.Text = "Deals to JSON";
			this.btnDealsToJSON.UseVisualStyleBackColor = true;
			this.btnDealsToJSON.Click += new System.EventHandler(this.btnDealsToJSON_Click);
			// 
			// ReadDealStarApi
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1232, 791);
			this.Controls.Add(this.btnDealsToJSON);
			this.Controls.Add(this.btnActiveToJson);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtResult);
			this.Controls.Add(this.txtToken);
			this.Controls.Add(this.txtSignedChallenge);
			this.Controls.Add(this.txtChallengeInNormalText);
			this.Controls.Add(this.txtChallenge);
			this.Controls.Add(this.txtPass);
			this.Controls.Add(this.txtUser);
			this.Controls.Add(this.txtUrl);
			this.Controls.Add(this.btnGetToken);
			this.Controls.Add(this.btnGetActiveDeals);
			this.Controls.Add(this.btnSign);
			this.Controls.Add(this.btnConvertChallengeFromBase64);
			this.Controls.Add(this.btnReqChallenge);
			this.Controls.Add(this.btnGetDelta);
			this.Name = "ReadDealStarApi";
			this.Text = "ReadDealStarApi";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnGetDelta;
		private System.Windows.Forms.TextBox txtUrl;
		private System.Windows.Forms.TextBox txtUser;
		private System.Windows.Forms.TextBox txtPass;
		private System.Windows.Forms.TextBox txtResult;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtChallenge;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button btnReqChallenge;
		private System.Windows.Forms.Button btnConvertChallengeFromBase64;
		private System.Windows.Forms.TextBox txtChallengeInNormalText;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtSignedChallenge;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Button btnSign;
		private System.Windows.Forms.Button btnGetActiveDeals;
		private System.Windows.Forms.TextBox txtToken;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Button btnGetToken;
		private System.Windows.Forms.Button btnActiveToJson;
		private System.Windows.Forms.Button btnDealsToJSON;
	}
}