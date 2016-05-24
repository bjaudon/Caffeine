/*
 * Name: CaffeineGUIMain Class
 * Synopsis: Main Forms Class
 * Author: Bryan Jaudon <bryan.jaudon@gmail.com>
 * Date: 5/23/2016
 */

using System;
using System.Drawing;
using System.Windows.Forms;

namespace Caffeine
{
    public partial class CaffeineGUIMain : ApplicationContext
    {
        #region Form Object Instances
        NotifyIcon notifyIcon1 = new NotifyIcon();
        ContextMenuStrip contextMenuStrip1 = new ContextMenuStrip();
        ToolStripMenuItem aboutCaffeineToolStripMenuItem = new ToolStripMenuItem();
        ToolStripMenuItem preferencesToolStripMenuItem = new ToolStripMenuItem();
        ToolStripSeparator toolStripSeparator1 = new ToolStripSeparator();
        ToolStripMenuItem activateForToolStripMenuItem = new ToolStripMenuItem();
        ToolStripMenuItem indefinitelyToolStripMenuItem = new ToolStripMenuItem();
        ToolStripMenuItem fiveMinuntesToolStripMenuItem = new ToolStripMenuItem();
        ToolStripMenuItem tenMinutesToolStripMenuItem = new ToolStripMenuItem();
        ToolStripMenuItem fifteenMinutesToolStripMenuItem1 = new ToolStripMenuItem();
        ToolStripMenuItem thirtyMinutesToolStripMenuItem2 = new ToolStripMenuItem();
        ToolStripMenuItem oneHourToolStripMenuItem = new ToolStripMenuItem();
        ToolStripMenuItem twoHoursToolStripMenuItem = new ToolStripMenuItem();
        ToolStripMenuItem fiveHoursToolStripMenuItem1 = new ToolStripMenuItem();
        ToolStripSeparator toolStripSeparator2 = new ToolStripSeparator();
        ToolStripMenuItem quitToolStripMenuItem = new ToolStripMenuItem();
        Timer timer1 = new Timer();
        ToolStripMenuItem activateCaffeineToolStripMenuItem = new ToolStripMenuItem();
        ToolStripSeparator toolStripSeparator3 = new ToolStripSeparator();
        #endregion

        private void InitializeComponent()
        {
            #region Form Object
            //
            // notifyIcon1
            //
            notifyIcon1.ContextMenuStrip = contextMenuStrip1;
            notifyIcon1.Visible = true;
            notifyIcon1.DoubleClick += new EventHandler(contextMenuStrip1_DoubleClick);
            notifyIcon1.MouseDown += new MouseEventHandler(notifyIcon1_MouseDown);
            Application.ApplicationExit += new EventHandler(OnApplicationExit);
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] {
             activateCaffeineToolStripMenuItem,
             toolStripSeparator3,
             aboutCaffeineToolStripMenuItem,
             preferencesToolStripMenuItem,
             toolStripSeparator1,
             activateForToolStripMenuItem,
             toolStripSeparator2,
             quitToolStripMenuItem
    });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(172, 132);
            // 
            // activateCaffeineToolStripMenuItem
            // 
            activateCaffeineToolStripMenuItem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            activateCaffeineToolStripMenuItem.Name = "activateCaffeineToolStripMenuItem";
            activateCaffeineToolStripMenuItem.Size = new Size(171, 22);
            activateCaffeineToolStripMenuItem.Text = "Activate Caffeine";
            activateCaffeineToolStripMenuItem.Click += new EventHandler(contextMenuStrip1_DoubleClick);
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(168, 6);
            // 
            // aboutCaffeineToolStripMenuItem
            // 
            aboutCaffeineToolStripMenuItem.Name = "aboutCaffeineToolStripMenuItem";
            aboutCaffeineToolStripMenuItem.Size = new Size(171, 22);
            aboutCaffeineToolStripMenuItem.Text = "About Caffeine...";
            aboutCaffeineToolStripMenuItem.Click += new EventHandler(aboutCaffeineToolStripMenuItem_Click);
            // 
            // preferencesToolStripMenuItem
            // 
            preferencesToolStripMenuItem.Name = "preferencesToolStripMenuItem";
            preferencesToolStripMenuItem.Size = new Size(171, 22);
            preferencesToolStripMenuItem.Text = "Preferences...";
            preferencesToolStripMenuItem.Click += new EventHandler(preferencesToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(168, 6);
            // 
            // activateForToolStripMenuItem
            // 
            activateForToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] {
             indefinitelyToolStripMenuItem,
             fiveMinuntesToolStripMenuItem,
             tenMinutesToolStripMenuItem,
             fifteenMinutesToolStripMenuItem1,
             thirtyMinutesToolStripMenuItem2,
             oneHourToolStripMenuItem,
             twoHoursToolStripMenuItem,
             fiveHoursToolStripMenuItem1});
            activateForToolStripMenuItem.Name = "activateForToolStripMenuItem";
            activateForToolStripMenuItem.Size = new Size(171, 22);
            activateForToolStripMenuItem.Text = "Activate For";
            // 
            // indefinitelyToolStripMenuItem
            // 
            indefinitelyToolStripMenuItem.Name = "indefinitelyToolStripMenuItem";
            indefinitelyToolStripMenuItem.Size = new Size(133, 22);
            indefinitelyToolStripMenuItem.Text = "Indefinitely";
            indefinitelyToolStripMenuItem.Click += new EventHandler(indefinitelyToolStripMenuItem_Click);
            // 
            // fiveMinuntesToolStripMenuItem
            // 
            fiveMinuntesToolStripMenuItem.Name = "fiveMinuntesToolStripMenuItem";
            fiveMinuntesToolStripMenuItem.Size = new Size(133, 22);
            fiveMinuntesToolStripMenuItem.Text = "5 minuntes";
            fiveMinuntesToolStripMenuItem.Click += new EventHandler(fiveMinuntesToolStripMenuItem_Click);
            // 
            // tenMinutesToolStripMenuItem
            // 
            tenMinutesToolStripMenuItem.Name = "tenMinutesToolStripMenuItem";
            tenMinutesToolStripMenuItem.Size = new Size(133, 22);
            tenMinutesToolStripMenuItem.Text = "10 minutes";
            tenMinutesToolStripMenuItem.Click += new EventHandler(tenMinutesToolStripMenuItem_Click);
            // 
            // fifteenMinutesToolStripMenuItem1
            // 
            fifteenMinutesToolStripMenuItem1.Name = "fifteenMinutesToolStripMenuItem1";
            fifteenMinutesToolStripMenuItem1.Size = new Size(133, 22);
            fifteenMinutesToolStripMenuItem1.Text = "15 minutes";
            fifteenMinutesToolStripMenuItem1.Click += new EventHandler(fifteenMinutesToolStripMenuItem1_Click);
            // 
            // thirtyMinutesToolStripMenuItem2
            // 
            thirtyMinutesToolStripMenuItem2.Name = "thirtyMinutesToolStripMenuItem2";
            thirtyMinutesToolStripMenuItem2.Size = new Size(133, 22);
            thirtyMinutesToolStripMenuItem2.Text = "30 minutes";
            thirtyMinutesToolStripMenuItem2.Click += new EventHandler(thirtyMinutesToolStripMenuItem2_Click);
            // 
            // oneHourToolStripMenuItem
            // 
            oneHourToolStripMenuItem.Name = "oneHourToolStripMenuItem";
            oneHourToolStripMenuItem.Size = new Size(133, 22);
            oneHourToolStripMenuItem.Text = "1 hour";
            oneHourToolStripMenuItem.Click += new EventHandler(oneHourToolStripMenuItem_Click);
            // 
            // twoHoursToolStripMenuItem
            // 
            twoHoursToolStripMenuItem.Name = "twoHoursToolStripMenuItem";
            twoHoursToolStripMenuItem.Size = new Size(133, 22);
            twoHoursToolStripMenuItem.Text = "2 hours";
            twoHoursToolStripMenuItem.Click += new EventHandler(twoHoursToolStripMenuItem_Click);
            // 
            // fiveHoursToolStripMenuItem1
            // 
            fiveHoursToolStripMenuItem1.Name = "fiveHoursToolStripMenuItem1";
            fiveHoursToolStripMenuItem1.Size = new Size(133, 22);
            fiveHoursToolStripMenuItem1.Text = "5 hours";
            fiveHoursToolStripMenuItem1.Click += new EventHandler(fiveHoursToolStripMenuItem1_Click);
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(168, 6);
            // 
            // quitToolStripMenuItem
            // 
            quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            quitToolStripMenuItem.Size = new Size(171, 22);
            quitToolStripMenuItem.Text = "Quit";
            quitToolStripMenuItem.Click += new EventHandler(quitToolStripMenuItem_Click);
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += new EventHandler(timer1_Tick);
            #endregion
        }

    }
}

