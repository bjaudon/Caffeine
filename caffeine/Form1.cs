using System;
using System.Windows.Forms;

namespace Caffeine
{
    public partial class Form1 : Form
    {
        //Instantiate the CaffeineCore object
        CaffeineCore caffeine = new CaffeineCore();

        // Declare our activationDuration interval
        TimeInterval activationDuration;

        // Enum for the TimeInterval settings
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

        // Enum to translate the Enum TimeInterval to Milliseconds
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
                activationDuration = duration; // Set our duration
                caffeine.setCaffeineMode(true); // Set caffeine enabled
                notifyIcon1.Icon = Properties.Resources.active;
                notifyIcon1.Text = "Caffeine is active."; // Change our notification icon and text
                activateCaffeineToolStripMenuItem.Text = "Deactivate Caffeine";
            }
            catch (Exception ex) // Catch any errors
            {
                MessageBox.Show(ex.ToString(), Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void deactivateCaffeine()
        {
            try
            {
                caffeine.setCaffeineMode(false); // Disable caffeine
                notifyIcon1.Icon = Properties.Resources.inactive; // Set our notify icon and text
                notifyIcon1.Text = "Caffeine is inactive.";
                activateCaffeineToolStripMenuItem.Text = "Activate Caffeine";
               
            }
            catch (Exception ex) // Catch any errors
            {
                MessageBox.Show(ex.ToString(), Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void aboutCaffeineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Show the about box
            About aboutBox = new About();
            aboutBox.ShowDialog();
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Deactivate caffeine on exit
            deactivateCaffeine();
            Application.Exit();
        }

        private void preferencesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Show our preferences (welcome) window.
            PreferenceWindow preferences = new PreferenceWindow();
            preferences.ShowDialog();
        }

        private void checkInterval()
        {
            // Get our interval. If we aren't indefinite, find out where we are to see if we need to
            // disable caffeine.

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
            // Check our interval on every timer tick.
            checkInterval();
        }
        
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            // Override application form closing and disable caffeine.
            base.OnFormClosing(e);
            deactivateCaffeine();
        }

        private void indefinitelyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Activate for x time
            activateCaffeine(TimeInterval.Indefinite);
        }

        private void fiveMinuntesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Activate for x time
            activateCaffeine(TimeInterval.fiveMinutes);
        }

        private void tenMinutesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Activate for x time
            activateCaffeine(TimeInterval.tenMinutes);
        }

        private void fifteenMinutesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // Activate for x time
            activateCaffeine(TimeInterval.fifteenMinutes);
        }

        private void thirtyMinutesToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            // Activate for x time
            activateCaffeine(TimeInterval.thirtyMinutes);
        }

        private void oneHourToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Activate for x time
            activateCaffeine(TimeInterval.oneHour);
        }

        private void twoHoursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Activate for x time
            activateCaffeine(TimeInterval.twoHours);
        }

        private void fiveHoursToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // Activate for x time
            activateCaffeine(TimeInterval.fiveHours);
        }

        private void contextMenuStrip1_DoubleClick(object sender, EventArgs e)
        {
            // Toggle caffeine mode. For Activate/Deactivate context menu, or NotifyIcon double click.
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
