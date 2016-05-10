using System;
using System.Windows.Forms;

namespace Caffeine
{
    public partial class Form1 : Form
    {
        //Instantiate the CaffeineCore object
        CaffeineCore caffeine = new CaffeineCore();
        TimeInterval activationDuration;


        private enum TimeInterval : int
        {
            Indefinite = 0,
            fiveMinutes = 1,
            tenMinutes = 2,
            fifteenMinutes = 3,
            thirtyMinutes = 4,
            oneHour = 5,
            twoHours = 6,
            fiveHours = 7,

        }

        private enum MinutesToMilliseconds : int
        {
            Indefinite = -1,
            fiveMinutes = 300000,
            tenMinutes = 600000,
            fifteenMinutes = 900000,
            thirtyMinutes = 1800000,
            oneHour = 3600000,
            twoHours = 7200000,
            fiveHours = 18000000,
        }


        public Form1()
        {
            InitializeComponent();
            this.Hide();

            deactivateCaffeine();

            // Load User Preferences
            if (Properties.Settings.Default.activateAtLaunch) { activateCaffeine((TimeInterval)Properties.Settings.Default.defaultDuration); }
            
            if (Properties.Settings.Default.showWelcome) { preferencesToolStripMenuItem_Click(this,null); }
            timer1.Enabled = true;
            
        }

        private void activateCaffeine(TimeInterval duration)
        {
            try
            {
                activationDuration = duration;
                caffeine.setCaffeineMode(true);
                notifyIcon1.Icon = Properties.Resources.active;
                notifyIcon1.Text = "Caffeine is active.";
                activateCaffeineToolStripMenuItem.Text = "Deactivate Caffeine";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void deactivateCaffeine()
        {
            try
            {
                caffeine.setCaffeineMode(false);
                notifyIcon1.Icon = Properties.Resources.inactive;
                notifyIcon1.Text = "Caffeine is inactive.";
                activateCaffeineToolStripMenuItem.Text = "Activate Caffeine";
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void aboutCaffeineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About aboutBox = new About();
            aboutBox.ShowDialog();
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            deactivateCaffeine();
            Application.Exit();
        }

        private void preferencesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PreferenceWindow preferences = new PreferenceWindow();
            preferences.ShowDialog();
        }

        private void checkInterval()
        {
            int millis;
            if (activationDuration == TimeInterval.Indefinite) { millis = -1; }
            else { millis = (int)(MinutesToMilliseconds)Enum.Parse(typeof(MinutesToMilliseconds),activationDuration.ToString()); }

            if (caffeine.getCaffeineMode())
            {
                int currentInterval = caffeine.getActiveTime();
                if ((currentInterval >= millis) && (millis != -1))
                {
                    deactivateCaffeine();
                }
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            checkInterval();
        }
        
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            deactivateCaffeine();
        }

        private void indefinitelyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            activateCaffeine(TimeInterval.Indefinite);
        }

        private void fiveMinuntesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            activateCaffeine(TimeInterval.fiveMinutes);
        }

        private void tenMinutesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            activateCaffeine(TimeInterval.tenMinutes);
        }

        private void fifteenMinutesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            activateCaffeine(TimeInterval.fifteenMinutes);
        }

        private void thirtyMinutesToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            activateCaffeine(TimeInterval.thirtyMinutes);
        }

        private void oneHourToolStripMenuItem_Click(object sender, EventArgs e)
        {
            activateCaffeine(TimeInterval.oneHour);
        }

        private void twoHoursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            activateCaffeine(TimeInterval.twoHours);
        }

        private void fiveHoursToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            activateCaffeine(TimeInterval.fiveHours);
        }

        private void contextMenuStrip1_DoubleClick(object sender, EventArgs e)
        {
            bool currentMode = caffeine.getCaffeineMode();
            if (currentMode == true)
            {
                deactivateCaffeine();
            } 
            else
            {
                activateCaffeine((TimeInterval)Properties.Settings.Default.defaultDuration);
            }
        }
    }
}
