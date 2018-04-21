namespace Loader {
	partial class Form1 {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.components = new System.ComponentModel.Container();
			this.metroProgressBar1 = new MetroFramework.Controls.MetroProgressBar();
			this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.SuspendLayout();
			// 
			// metroProgressBar1
			// 
			this.metroProgressBar1.Location = new System.Drawing.Point(23, 44);
			this.metroProgressBar1.Name = "metroProgressBar1";
			this.metroProgressBar1.Size = new System.Drawing.Size(272, 23);
			this.metroProgressBar1.TabIndex = 0;
			this.metroProgressBar1.Theme = MetroFramework.MetroThemeStyle.Dark;
			// 
			// metroLabel1
			// 
			this.metroLabel1.AutoSize = true;
			this.metroLabel1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.metroLabel1.Location = new System.Drawing.Point(23, 22);
			this.metroLabel1.Name = "metroLabel1";
			this.metroLabel1.Size = new System.Drawing.Size(142, 19);
			this.metroLabel1.Style = MetroFramework.MetroColorStyle.Silver;
			this.metroLabel1.TabIndex = 1;
			this.metroLabel1.Text = "Checking for updates...";
			this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
			// 
			// timer1
			// 
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(318, 90);
			this.Controls.Add(this.metroLabel1);
			this.Controls.Add(this.metroProgressBar1);
			this.MaximizeBox = false;
			this.Name = "Form1";
			this.Resizable = false;
			this.Style = MetroFramework.MetroColorStyle.Silver;
			this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
			this.Theme = MetroFramework.MetroThemeStyle.Dark;
			this.TransparencyKey = System.Drawing.Color.Transparent;
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private MetroFramework.Controls.MetroProgressBar metroProgressBar1;
		private MetroFramework.Controls.MetroLabel metroLabel1;
		private System.Windows.Forms.Timer timer1;
	}
}

