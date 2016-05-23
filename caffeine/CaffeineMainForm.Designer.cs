namespace Caffeine
{
    partial class CaffeineMainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CaffeineMainForm));
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.activateCaffeineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutCaffeineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preferencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.activateForToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.indefinitelyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fiveMinuntesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tenMinutesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fifteenMinutesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.thirtyMinutesToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.oneHourToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.twoHoursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fiveHoursToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.DoubleClick += new System.EventHandler(this.contextMenuStrip1_DoubleClick);
            this.notifyIcon1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDown);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.activateCaffeineToolStripMenuItem,
            this.toolStripSeparator3,
            this.aboutCaffeineToolStripMenuItem,
            this.preferencesToolStripMenuItem,
            this.toolStripSeparator1,
            this.activateForToolStripMenuItem,
            this.toolStripSeparator2,
            this.quitToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(172, 132);
            // 
            // activateCaffeineToolStripMenuItem
            // 
            this.activateCaffeineToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activateCaffeineToolStripMenuItem.Name = "activateCaffeineToolStripMenuItem";
            this.activateCaffeineToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.activateCaffeineToolStripMenuItem.Text = "Activate Caffeine";
            this.activateCaffeineToolStripMenuItem.Click += new System.EventHandler(this.contextMenuStrip1_DoubleClick);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(168, 6);
            // 
            // aboutCaffeineToolStripMenuItem
            // 
            this.aboutCaffeineToolStripMenuItem.Name = "aboutCaffeineToolStripMenuItem";
            this.aboutCaffeineToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.aboutCaffeineToolStripMenuItem.Text = "About Caffeine...";
            this.aboutCaffeineToolStripMenuItem.Click += new System.EventHandler(this.aboutCaffeineToolStripMenuItem_Click);
            // 
            // preferencesToolStripMenuItem
            // 
            this.preferencesToolStripMenuItem.Name = "preferencesToolStripMenuItem";
            this.preferencesToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.preferencesToolStripMenuItem.Text = "Preferences...";
            this.preferencesToolStripMenuItem.Click += new System.EventHandler(this.preferencesToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(168, 6);
            // 
            // activateForToolStripMenuItem
            // 
            this.activateForToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.indefinitelyToolStripMenuItem,
            this.fiveMinuntesToolStripMenuItem,
            this.tenMinutesToolStripMenuItem,
            this.fifteenMinutesToolStripMenuItem1,
            this.thirtyMinutesToolStripMenuItem2,
            this.oneHourToolStripMenuItem,
            this.twoHoursToolStripMenuItem,
            this.fiveHoursToolStripMenuItem1});
            this.activateForToolStripMenuItem.Name = "activateForToolStripMenuItem";
            this.activateForToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.activateForToolStripMenuItem.Text = "Activate For";
            // 
            // indefinitelyToolStripMenuItem
            // 
            this.indefinitelyToolStripMenuItem.Name = "indefinitelyToolStripMenuItem";
            this.indefinitelyToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.indefinitelyToolStripMenuItem.Text = "Indefinitely";
            this.indefinitelyToolStripMenuItem.Click += new System.EventHandler(this.indefinitelyToolStripMenuItem_Click);
            // 
            // fiveMinuntesToolStripMenuItem
            // 
            this.fiveMinuntesToolStripMenuItem.Name = "fiveMinuntesToolStripMenuItem";
            this.fiveMinuntesToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.fiveMinuntesToolStripMenuItem.Text = "5 minuntes";
            this.fiveMinuntesToolStripMenuItem.Click += new System.EventHandler(this.fiveMinuntesToolStripMenuItem_Click);
            // 
            // tenMinutesToolStripMenuItem
            // 
            this.tenMinutesToolStripMenuItem.Name = "tenMinutesToolStripMenuItem";
            this.tenMinutesToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.tenMinutesToolStripMenuItem.Text = "10 minutes";
            this.tenMinutesToolStripMenuItem.Click += new System.EventHandler(this.tenMinutesToolStripMenuItem_Click);
            // 
            // fifteenMinutesToolStripMenuItem1
            // 
            this.fifteenMinutesToolStripMenuItem1.Name = "fifteenMinutesToolStripMenuItem1";
            this.fifteenMinutesToolStripMenuItem1.Size = new System.Drawing.Size(133, 22);
            this.fifteenMinutesToolStripMenuItem1.Text = "15 minutes";
            this.fifteenMinutesToolStripMenuItem1.Click += new System.EventHandler(this.fifteenMinutesToolStripMenuItem1_Click);
            // 
            // thirtyMinutesToolStripMenuItem2
            // 
            this.thirtyMinutesToolStripMenuItem2.Name = "thirtyMinutesToolStripMenuItem2";
            this.thirtyMinutesToolStripMenuItem2.Size = new System.Drawing.Size(133, 22);
            this.thirtyMinutesToolStripMenuItem2.Text = "30 minutes";
            this.thirtyMinutesToolStripMenuItem2.Click += new System.EventHandler(this.thirtyMinutesToolStripMenuItem2_Click);
            // 
            // oneHourToolStripMenuItem
            // 
            this.oneHourToolStripMenuItem.Name = "oneHourToolStripMenuItem";
            this.oneHourToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.oneHourToolStripMenuItem.Text = "1 hour";
            this.oneHourToolStripMenuItem.Click += new System.EventHandler(this.oneHourToolStripMenuItem_Click);
            // 
            // twoHoursToolStripMenuItem
            // 
            this.twoHoursToolStripMenuItem.Name = "twoHoursToolStripMenuItem";
            this.twoHoursToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.twoHoursToolStripMenuItem.Text = "2 hours";
            this.twoHoursToolStripMenuItem.Click += new System.EventHandler(this.twoHoursToolStripMenuItem_Click);
            // 
            // fiveHoursToolStripMenuItem1
            // 
            this.fiveHoursToolStripMenuItem1.Name = "fiveHoursToolStripMenuItem1";
            this.fiveHoursToolStripMenuItem1.Size = new System.Drawing.Size(133, 22);
            this.fiveHoursToolStripMenuItem1.Text = "5 hours";
            this.fiveHoursToolStripMenuItem1.Click += new System.EventHandler(this.fiveHoursToolStripMenuItem1_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(168, 6);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // CaffeineMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 130);
            this.ControlBox = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CaffeineMainForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Caffeine";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aboutCaffeineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem preferencesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem activateForToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem indefinitelyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fiveMinuntesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tenMinutesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fifteenMinutesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem thirtyMinutesToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem oneHourToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem twoHoursToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fiveHoursToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem activateCaffeineToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
    }
}