/*
 * Name: CaffeineGUIMain Class
 * Synopsis: Main Forms Class
 * Author: Bryan Jaudon <bryan.jaudon@gmail.com>
 * Date: 5/23/2016
 */

using System;
using System.Drawing;
using System.Windows.Forms;
using static Caffeine.CaffeineStrings;

namespace Caffeine
{
    public partial class CaffeineGUIMain : ApplicationContext
    {
        #region Form Object Instances
        private NotifyIcon notifyIcon1 = new NotifyIcon();
        private ContextMenuStrip contextMenuStrip1 = new ContextMenuStrip();
        private ToolStripMenuItem aboutCaffeineToolStripMenuItem = new ToolStripMenuItem();
        private ToolStripMenuItem preferencesToolStripMenuItem = new ToolStripMenuItem();
        private ToolStripSeparator toolStripSeparator1 = new ToolStripSeparator();
        private ToolStripMenuItem activateForToolStripMenuItem = new ToolStripMenuItem();
        private ToolStripMenuItem indefinitelyToolStripMenuItem = new ToolStripMenuItem();
        private ToolStripMenuItem fiveMinuntesToolStripMenuItem = new ToolStripMenuItem();
        private ToolStripMenuItem tenMinutesToolStripMenuItem = new ToolStripMenuItem();
        private ToolStripMenuItem fifteenMinutesToolStripMenuItem1 = new ToolStripMenuItem();
        private ToolStripMenuItem thirtyMinutesToolStripMenuItem2 = new ToolStripMenuItem();
        private ToolStripMenuItem oneHourToolStripMenuItem = new ToolStripMenuItem();
        private ToolStripMenuItem twoHoursToolStripMenuItem = new ToolStripMenuItem();
        private ToolStripMenuItem fiveHoursToolStripMenuItem1 = new ToolStripMenuItem();
        private ToolStripSeparator toolStripSeparator2 = new ToolStripSeparator();
        private ToolStripMenuItem quitToolStripMenuItem = new ToolStripMenuItem();
        private Timer timer1 = new Timer();
        private ToolStripMenuItem activateCaffeineToolStripMenuItem = new ToolStripMenuItem();
        private ToolStripSeparator toolStripSeparator3 = new ToolStripSeparator();
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
            activateCaffeineToolStripMenuItem.Text = _strContextActivateCaffeine;
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
            aboutCaffeineToolStripMenuItem.Text = _strContextAboutCaffeine;
            aboutCaffeineToolStripMenuItem.Click += new EventHandler(aboutCaffeineToolStripMenuItem_Click);
            // 
            // preferencesToolStripMenuItem
            // 
            preferencesToolStripMenuItem.Name = "preferencesToolStripMenuItem";
            preferencesToolStripMenuItem.Size = new Size(171, 22);
            preferencesToolStripMenuItem.Text = _strContextPreferences;
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
            activateForToolStripMenuItem.Text = _strContextActivateFor;
            // 
            // indefinitelyToolStripMenuItem
            // 
            indefinitelyToolStripMenuItem.Name = "indefinitelyToolStripMenuItem";
            indefinitelyToolStripMenuItem.Size = new Size(133, 22);
            indefinitelyToolStripMenuItem.Text = _strContextIndefinitely;
            indefinitelyToolStripMenuItem.Click += new EventHandler(indefinitelyToolStripMenuItem_Click);
            // 
            // fiveMinuntesToolStripMenuItem
            // 
            fiveMinuntesToolStripMenuItem.Name = "fiveMinuntesToolStripMenuItem";
            fiveMinuntesToolStripMenuItem.Size = new Size(133, 22);
            fiveMinuntesToolStripMenuItem.Text = _strContext5Minutes;
            fiveMinuntesToolStripMenuItem.Click += new EventHandler(fiveMinuntesToolStripMenuItem_Click);
            // 
            // tenMinutesToolStripMenuItem
            // 
            tenMinutesToolStripMenuItem.Name = "tenMinutesToolStripMenuItem";
            tenMinutesToolStripMenuItem.Size = new Size(133, 22);
            tenMinutesToolStripMenuItem.Text = _strContext10Minutes;
            tenMinutesToolStripMenuItem.Click += new EventHandler(tenMinutesToolStripMenuItem_Click);
            // 
            // fifteenMinutesToolStripMenuItem1
            // 
            fifteenMinutesToolStripMenuItem1.Name = "fifteenMinutesToolStripMenuItem1";
            fifteenMinutesToolStripMenuItem1.Size = new Size(133, 22);
            fifteenMinutesToolStripMenuItem1.Text = _strContext15Minutes;
            fifteenMinutesToolStripMenuItem1.Click += new EventHandler(fifteenMinutesToolStripMenuItem1_Click);
            // 
            // thirtyMinutesToolStripMenuItem2
            // 
            thirtyMinutesToolStripMenuItem2.Name = "thirtyMinutesToolStripMenuItem2";
            thirtyMinutesToolStripMenuItem2.Size = new Size(133, 22);
            thirtyMinutesToolStripMenuItem2.Text = _strContext30Minutes;
            thirtyMinutesToolStripMenuItem2.Click += new EventHandler(thirtyMinutesToolStripMenuItem2_Click);
            // 
            // oneHourToolStripMenuItem
            // 
            oneHourToolStripMenuItem.Name = "oneHourToolStripMenuItem";
            oneHourToolStripMenuItem.Size = new Size(133, 22);
            oneHourToolStripMenuItem.Text = _strContext1Hour;
            oneHourToolStripMenuItem.Click += new EventHandler(oneHourToolStripMenuItem_Click);
            // 
            // twoHoursToolStripMenuItem
            // 
            twoHoursToolStripMenuItem.Name = "twoHoursToolStripMenuItem";
            twoHoursToolStripMenuItem.Size = new Size(133, 22);
            twoHoursToolStripMenuItem.Text = _strContext2Hours;
            twoHoursToolStripMenuItem.Click += new EventHandler(twoHoursToolStripMenuItem_Click);
            // 
            // fiveHoursToolStripMenuItem1
            // 
            fiveHoursToolStripMenuItem1.Name = "fiveHoursToolStripMenuItem1";
            fiveHoursToolStripMenuItem1.Size = new Size(133, 22);
            fiveHoursToolStripMenuItem1.Text = _strContext5Hours;
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
            quitToolStripMenuItem.Text = _strContextQuit;
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

