namespace Solarschmiede.WindowsServicesManager
{
	partial class frmPvscoutServiceStatus
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPvscoutServiceStatus));
			this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
			this.gvServiceStatus = new System.Windows.Forms.DataGridView();
			this.btnRestartServices = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.gvServiceStatus)).BeginInit();
			this.SuspendLayout();
			// 
			// notifyIcon
			// 
			this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
			this.notifyIcon.Text = "notifyIcon1";
			this.notifyIcon.Visible = true;
			this.notifyIcon.DoubleClick += new System.EventHandler(this.NotifyIconDoubleClick);
			// 
			// gvServiceStatus
			// 
			this.gvServiceStatus.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.gvServiceStatus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gvServiceStatus.Dock = System.Windows.Forms.DockStyle.Top;
			this.gvServiceStatus.Location = new System.Drawing.Point(0, 0);
			this.gvServiceStatus.Name = "gvServiceStatus";
			this.gvServiceStatus.Size = new System.Drawing.Size(393, 181);
			this.gvServiceStatus.TabIndex = 0;
			// 
			// btnRestartServices
			// 
			this.btnRestartServices.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.btnRestartServices.Location = new System.Drawing.Point(0, 181);
			this.btnRestartServices.Name = "btnRestartServices";
			this.btnRestartServices.Size = new System.Drawing.Size(393, 23);
			this.btnRestartServices.TabIndex = 1;
			this.btnRestartServices.Text = "Restart Services";
			this.btnRestartServices.UseVisualStyleBackColor = true;
			this.btnRestartServices.Click += new System.EventHandler(this.BtnRestartServicesClick);
			// 
			// frmPvscoutServiceStatus
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(393, 204);
			this.Controls.Add(this.btnRestartServices);
			this.Controls.Add(this.gvServiceStatus);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "frmPvscoutServiceStatus";
			this.ShowInTaskbar = false;
			this.Text = "PvScout Services";
			this.Deactivate += new System.EventHandler(this.FrmPvscoutServiceStatusDeactivate);
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPvscoutServiceStatusFormClosing);
			((System.ComponentModel.ISupportInitialize)(this.gvServiceStatus)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.NotifyIcon notifyIcon;
		private System.Windows.Forms.DataGridView gvServiceStatus;
		private System.Windows.Forms.Button btnRestartServices;
	}
}

