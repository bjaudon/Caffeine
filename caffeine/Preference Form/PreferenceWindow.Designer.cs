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
            btnClose = new System.Windows.Forms.Button();
            lblWelcome = new System.Windows.Forms.Label();
            pbLogo = new System.Windows.Forms.PictureBox();
            chkAutoStart = new System.Windows.Forms.CheckBox();
            chkLaunchatStartup = new System.Windows.Forms.CheckBox();
            chkShowMessage = new System.Windows.Forms.CheckBox();
            lblDefaultDuration = new System.Windows.Forms.Label();
            comboDefaultDuration = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            SuspendLayout();
            // 
            // btnClose
            // 
            btnClose.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            btnClose.Location = new System.Drawing.Point(660, 479);
            btnClose.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            btnClose.Name = "btnClose";
            btnClose.Size = new System.Drawing.Size(168, 45);
            btnClose.TabIndex = 3;
            btnClose.Text = "btnClose";
            btnClose.UseVisualStyleBackColor = true;
            // 
            // lblWelcome
            // 
            lblWelcome.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblWelcome.Location = new System.Drawing.Point(320, 34);
            lblWelcome.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new System.Drawing.Size(476, 200);
            lblWelcome.TabIndex = 5;
            lblWelcome.Text = "lblWelcome";
            // 
            // pbLogo
            // 
            pbLogo.Image = Properties.Resources.imgCaffeineNew;
            pbLogo.Location = new System.Drawing.Point(30, 34);
            pbLogo.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new System.Drawing.Size(255, 254);
            pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pbLogo.TabIndex = 4;
            pbLogo.TabStop = false;
            // 
            // chkAutoStart
            // 
            chkAutoStart.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            chkAutoStart.AutoSize = true;
            chkAutoStart.Location = new System.Drawing.Point(301, 243);
            chkAutoStart.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            chkAutoStart.Name = "chkAutoStart";
            chkAutoStart.Size = new System.Drawing.Size(140, 29);
            chkAutoStart.TabIndex = 6;
            chkAutoStart.Text = "chkAutoStart";
            chkAutoStart.UseVisualStyleBackColor = true;
            chkAutoStart.CheckedChanged += chkAutoStart_CheckedChanged;
            // 
            // chkLaunchatStartup
            // 
            chkLaunchatStartup.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            chkLaunchatStartup.AutoSize = true;
            chkLaunchatStartup.Location = new System.Drawing.Point(301, 290);
            chkLaunchatStartup.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            chkLaunchatStartup.Name = "chkLaunchatStartup";
            chkLaunchatStartup.Size = new System.Drawing.Size(192, 29);
            chkLaunchatStartup.TabIndex = 7;
            chkLaunchatStartup.Text = "chkLaunchatStartup";
            chkLaunchatStartup.UseVisualStyleBackColor = true;
            chkLaunchatStartup.CheckedChanged += chkLaunchatStartup_CheckedChanged;
            // 
            // chkShowMessage
            // 
            chkShowMessage.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            chkShowMessage.AutoSize = true;
            chkShowMessage.Location = new System.Drawing.Point(301, 337);
            chkShowMessage.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            chkShowMessage.Name = "chkShowMessage";
            chkShowMessage.Size = new System.Drawing.Size(179, 29);
            chkShowMessage.TabIndex = 8;
            chkShowMessage.Text = "chkShowMessage";
            chkShowMessage.UseVisualStyleBackColor = true;
            chkShowMessage.CheckedChanged += chkShowMessage_CheckedChanged;
            // 
            // lblDefaultDuration
            // 
            lblDefaultDuration.AutoSize = true;
            lblDefaultDuration.Location = new System.Drawing.Point(301, 383);
            lblDefaultDuration.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            lblDefaultDuration.Name = "lblDefaultDuration";
            lblDefaultDuration.Size = new System.Drawing.Size(157, 25);
            lblDefaultDuration.TabIndex = 9;
            lblDefaultDuration.Text = "lblDefaultDuration";
            // 
            // comboDefaultDuration
            // 
            comboDefaultDuration.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            comboDefaultDuration.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboDefaultDuration.FormattingEnabled = true;
            comboDefaultDuration.Location = new System.Drawing.Point(498, 380);
            comboDefaultDuration.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            comboDefaultDuration.Name = "comboDefaultDuration";
            comboDefaultDuration.Size = new System.Drawing.Size(298, 33);
            comboDefaultDuration.TabIndex = 10;
            comboDefaultDuration.SelectedIndexChanged += comboDefaultDuration_SelectedIndexChanged;
            // 
            // PreferenceWindow
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            CancelButton = btnClose;
            ClientSize = new System.Drawing.Size(845, 542);
            ControlBox = false;
            Controls.Add(comboDefaultDuration);
            Controls.Add(lblDefaultDuration);
            Controls.Add(chkShowMessage);
            Controls.Add(chkLaunchatStartup);
            Controls.Add(chkAutoStart);
            Controls.Add(btnClose);
            Controls.Add(lblWelcome);
            Controls.Add(pbLogo);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "PreferenceWindow";
            ShowInTaskbar = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "PreferencesWindow";
            TopMost = true;
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();

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