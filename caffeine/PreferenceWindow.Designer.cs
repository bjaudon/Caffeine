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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.chkAutoStart = new System.Windows.Forms.CheckBox();
            this.chkLaunchatStartup = new System.Windows.Forms.CheckBox();
            this.chkShowMessage = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboDefaultDuration = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Location = new System.Drawing.Point(370, 230);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(148, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 62);
            this.label1.TabIndex = 5;
            this.label1.Text = "Caffeine is now running. You can find its icon in the notification area of your t" +
    "askbar. Right click the icon to show the Caffeine menu.";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Caffeine.Properties.Resources.caffeine;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(130, 86);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // chkAutoStart
            // 
            this.chkAutoStart.AutoSize = true;
            this.chkAutoStart.Location = new System.Drawing.Point(151, 111);
            this.chkAutoStart.Name = "chkAutoStart";
            this.chkAutoStart.Size = new System.Drawing.Size(190, 17);
            this.chkAutoStart.TabIndex = 6;
            this.chkAutoStart.Text = "Automatically start Caffeine at login";
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
            this.chkLaunchatStartup.Text = "Activate Caffeine at launch";
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
            this.chkShowMessage.Text = "Show this message when starting Caffeine";
            this.chkShowMessage.UseVisualStyleBackColor = true;
            this.chkShowMessage.CheckedChanged += new System.EventHandler(this.chkShowMessage_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(148, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Default duration: ";
            // 
            // comboDefaultDuration
            // 
            this.comboDefaultDuration.FormattingEnabled = true;
            this.comboDefaultDuration.Items.AddRange(new object[] {
            "Indefinitely",
            "5 minutes",
            "10 minutes",
            "15 minutes",
            "30 minutes",
            "1 hour",
            "2 hours",
            "5 hours"});
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
            this.CancelButton = this.button1;
            this.ClientSize = new System.Drawing.Size(458, 261);
            this.ControlBox = false;
            this.Controls.Add(this.comboDefaultDuration);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chkShowMessage);
            this.Controls.Add(this.chkLaunchatStartup);
            this.Controls.Add(this.chkAutoStart);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PreferenceWindow";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome to Caffeine";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox chkAutoStart;
        private System.Windows.Forms.CheckBox chkLaunchatStartup;
        private System.Windows.Forms.CheckBox chkShowMessage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboDefaultDuration;
    }
}