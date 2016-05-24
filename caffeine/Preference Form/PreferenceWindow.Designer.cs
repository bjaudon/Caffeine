namespace Caffeine
{
    partial class PreferenceWindow
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
            this.btnClose = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.chkAutoStart = new System.Windows.Forms.CheckBox();
            this.chkLaunchatStartup = new System.Windows.Forms.CheckBox();
            this.chkShowMessage = new System.Windows.Forms.CheckBox();
            this.lblDefaultDuration = new System.Windows.Forms.Label();
            this.comboDefaultDuration = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(370, 230);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.lblWelcome.Location = new System.Drawing.Point(148, 25);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(288, 62);
            this.lblWelcome.TabIndex = 5;
            this.lblWelcome.Text = "";
            // 
            // pictureBox1
            // 
            this.pbLogo.Image = global::Caffeine.Properties.Resources.imgCaffeineNew;
            this.pbLogo.Location = new System.Drawing.Point(12, 12);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(130, 116);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 4;
            this.pbLogo.TabStop = false;
            // 
            // chkAutoStart
            // 
            this.chkAutoStart.AutoSize = true;
            this.chkAutoStart.Location = new System.Drawing.Point(151, 111);
            this.chkAutoStart.Name = "chkAutoStart";
            this.chkAutoStart.Size = new System.Drawing.Size(190, 17);
            this.chkAutoStart.TabIndex = 6;
            this.chkAutoStart.Text = "";
            this.chkAutoStart.UseVisualStyleBackColor = true;
            this.chkAutoStart.CheckedChanged += new System.EventHandler(this.chkAutoStart_CheckedChanged);
            // 
            // chkLaunchatStartup
            // 
            this.chkLaunchatStartup.AutoSize = true;
            this.chkLaunchatStartup.Location = new System.Drawing.Point(151, 135);
            this.chkLaunchatStartup.Name = "chkLaunchatStartup";
            this.chkLaunchatStartup.Size = new System.Drawing.Size(154, 17);
            this.chkLaunchatStartup.TabIndex = 7;
            this.chkLaunchatStartup.Text = "";
            this.chkLaunchatStartup.UseVisualStyleBackColor = true;
            this.chkLaunchatStartup.CheckedChanged += new System.EventHandler(this.chkLaunchatStartup_CheckedChanged);
            // 
            // chkShowMessage
            // 
            this.chkShowMessage.AutoSize = true;
            this.chkShowMessage.Location = new System.Drawing.Point(151, 159);
            this.chkShowMessage.Name = "chkShowMessage";
            this.chkShowMessage.Size = new System.Drawing.Size(225, 17);
            this.chkShowMessage.TabIndex = 8;
            this.chkShowMessage.Text = "";
            this.chkShowMessage.UseVisualStyleBackColor = true;
            this.chkShowMessage.CheckedChanged += new System.EventHandler(this.chkShowMessage_CheckedChanged);
            // 
            // label2
            // 
            this.lblDefaultDuration.AutoSize = true;
            this.lblDefaultDuration.Location = new System.Drawing.Point(148, 186);
            this.lblDefaultDuration.Name = "lblDefaultDuration";
            this.lblDefaultDuration.Size = new System.Drawing.Size(88, 13);
            this.lblDefaultDuration.TabIndex = 9;
            this.lblDefaultDuration.Text = "";
            // 
            // comboDefaultDuration
            // 
            this.comboDefaultDuration.FormattingEnabled = true;
            this.comboDefaultDuration.Location = new System.Drawing.Point(246, 183);
            this.comboDefaultDuration.Name = "comboDefaultDuration";
            this.comboDefaultDuration.Size = new System.Drawing.Size(121, 21);
            this.comboDefaultDuration.TabIndex = 10;
            this.comboDefaultDuration.SelectedIndexChanged += new System.EventHandler(this.comboDefaultDuration_SelectedIndexChanged);
            // 
            // PreferenceWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(458, 261);
            this.ControlBox = false;
            this.Controls.Add(this.comboDefaultDuration);
            this.Controls.Add(this.lblDefaultDuration);
            this.Controls.Add(this.chkShowMessage);
            this.Controls.Add(this.chkLaunchatStartup);
            this.Controls.Add(this.chkAutoStart);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.pbLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PreferenceWindow";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.CheckBox chkAutoStart;
        private System.Windows.Forms.CheckBox chkLaunchatStartup;
        private System.Windows.Forms.CheckBox chkShowMessage;
        private System.Windows.Forms.Label lblDefaultDuration;
        private System.Windows.Forms.ComboBox comboDefaultDuration;
    }
}