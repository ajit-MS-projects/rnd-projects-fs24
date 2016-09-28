namespace RabbitMqClient
{
	partial class frmQueuer
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
			this.btnSend = new System.Windows.Forms.Button();
			this.txtQueue = new System.Windows.Forms.TextBox();
			this.txtMessage = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.txtUserId = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.txtObjectId = new System.Windows.Forms.TextBox();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.btnJson = new System.Windows.Forms.Button();
			this.txtExch = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.btnExchMessageSend = new System.Windows.Forms.Button();
			this.txtExchMessage = new System.Windows.Forms.TextBox();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnSend
			// 
			this.btnSend.Location = new System.Drawing.Point(83, 141);
			this.btnSend.Name = "btnSend";
			this.btnSend.Size = new System.Drawing.Size(268, 23);
			this.btnSend.TabIndex = 0;
			this.btnSend.Text = "Send";
			this.btnSend.UseVisualStyleBackColor = true;
			this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
			// 
			// txtQueue
			// 
			this.txtQueue.Location = new System.Drawing.Point(80, 31);
			this.txtQueue.Name = "txtQueue";
			this.txtQueue.Size = new System.Drawing.Size(306, 20);
			this.txtQueue.TabIndex = 1;
			this.txtQueue.Text = "testQueue";
			// 
			// txtMessage
			// 
			this.txtMessage.Location = new System.Drawing.Point(82, 60);
			this.txtMessage.Name = "txtMessage";
			this.txtMessage.Size = new System.Drawing.Size(303, 20);
			this.txtMessage.TabIndex = 2;
			this.txtMessage.Text = "test message";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 67);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(50, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "Message";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(6, 34);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(70, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "Queue Name";
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.groupBox1.Controls.Add(this.txtQueue);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.btnSend);
			this.groupBox1.Controls.Add(this.txtMessage);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(394, 238);
			this.groupBox1.TabIndex = 5;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Send Messages to Queue";
			// 
			// groupBox2
			// 
			this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
			this.groupBox2.Controls.Add(this.txtUserId);
			this.groupBox2.Controls.Add(this.label7);
			this.groupBox2.Controls.Add(this.txtObjectId);
			this.groupBox2.Controls.Add(this.comboBox1);
			this.groupBox2.Controls.Add(this.btnJson);
			this.groupBox2.Controls.Add(this.txtExch);
			this.groupBox2.Controls.Add(this.label6);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Controls.Add(this.btnExchMessageSend);
			this.groupBox2.Controls.Add(this.txtExchMessage);
			this.groupBox2.Location = new System.Drawing.Point(428, 11);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(394, 239);
			this.groupBox2.TabIndex = 5;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Send Messages to Exchange";
			// 
			// txtUserId
			// 
			this.txtUserId.Location = new System.Drawing.Point(82, 140);
			this.txtUserId.Name = "txtUserId";
			this.txtUserId.Size = new System.Drawing.Size(303, 20);
			this.txtUserId.TabIndex = 9;
			this.txtUserId.Text = "23487";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(6, 140);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(40, 13);
			this.label7.TabIndex = 8;
			this.label7.Text = "UserID";
			// 
			// txtObjectId
			// 
			this.txtObjectId.Location = new System.Drawing.Point(82, 114);
			this.txtObjectId.Name = "txtObjectId";
			this.txtObjectId.Size = new System.Drawing.Size(303, 20);
			this.txtObjectId.TabIndex = 7;
			this.txtObjectId.Text = "12238";
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Items.AddRange(new object[] {
            "ActivityCreated = 1",
            "ActivityUpdated = 2",
            "ActivityCanceled = 3",
            "UserJoinedYourActivity = 4",
            "FriendJoinedActivity = 5",
            "UserCreated = 6",
            "UserConfirmedEmail = 7",
            "MessageReceived = 8",
            "FriendshipRequested = 9",
            "FriendshipAccepted = 10",
            "RecommendationReceived = 11",
            "InvitationReceived = 12",
            "ActivityCommentedByInitiator = 13",
            "ActivityCommentedByUser = 14"});
			this.comboBox1.Location = new System.Drawing.Point(82, 86);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(304, 21);
			this.comboBox1.TabIndex = 6;
			// 
			// btnJson
			// 
			this.btnJson.Location = new System.Drawing.Point(79, 198);
			this.btnJson.Name = "btnJson";
			this.btnJson.Size = new System.Drawing.Size(268, 23);
			this.btnJson.TabIndex = 5;
			this.btnJson.Text = "Send JSON";
			this.btnJson.UseVisualStyleBackColor = true;
			this.btnJson.Click += new System.EventHandler(this.btnJson_Click);
			// 
			// txtExch
			// 
			this.txtExch.Location = new System.Drawing.Point(80, 31);
			this.txtExch.Name = "txtExch";
			this.txtExch.Size = new System.Drawing.Size(306, 20);
			this.txtExch.TabIndex = 1;
			this.txtExch.Text = "Spontatcs.Notifications";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(6, 114);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(47, 13);
			this.label6.TabIndex = 3;
			this.label6.Text = "ObjectId";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(6, 86);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(35, 13);
			this.label5.TabIndex = 3;
			this.label5.Text = "Event";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(6, 67);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(50, 13);
			this.label3.TabIndex = 3;
			this.label3.Text = "Message";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(6, 34);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(55, 13);
			this.label4.TabIndex = 4;
			this.label4.Text = "Exchange";
			// 
			// btnExchMessageSend
			// 
			this.btnExchMessageSend.Location = new System.Drawing.Point(80, 169);
			this.btnExchMessageSend.Name = "btnExchMessageSend";
			this.btnExchMessageSend.Size = new System.Drawing.Size(268, 23);
			this.btnExchMessageSend.TabIndex = 0;
			this.btnExchMessageSend.Text = "Send";
			this.btnExchMessageSend.UseVisualStyleBackColor = true;
			this.btnExchMessageSend.Click += new System.EventHandler(this.btnExchMessageSend_Click);
			// 
			// txtExchMessage
			// 
			this.txtExchMessage.Location = new System.Drawing.Point(82, 60);
			this.txtExchMessage.Name = "txtExchMessage";
			this.txtExchMessage.Size = new System.Drawing.Size(303, 20);
			this.txtExchMessage.TabIndex = 2;
			this.txtExchMessage.Text = "test message";
			// 
			// frmQueuer
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(828, 259);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Name = "frmQueuer";
			this.Text = "Queue Pusher";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmQueuer_FormClosing);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnSend;
		private System.Windows.Forms.TextBox txtQueue;
		private System.Windows.Forms.TextBox txtMessage;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.TextBox txtExch;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button btnExchMessageSend;
		private System.Windows.Forms.TextBox txtExchMessage;
		private System.Windows.Forms.Button btnJson;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtObjectId;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtUserId;
		private System.Windows.Forms.Label label7;
	}
}

