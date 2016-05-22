using System;
using System.Windows.Forms;
using static Caffeine.CaffeineCore;

namespace Caffeine
{
    public partial class Form1 : Form
    {
        
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
            
            // Set initial state as deactivated.
            notifyIcon1.Icon = Properties.Resources.inactive;
            notifyIcon1.Text = "Caffeine is inactive.";
            activateCaffeineToolStripMenuItem.Text = "Activate Caffeine";

            // Load User Preferences
            if (Properties.Settings.Default.activateAtLaunch) { activateCaffeine((TimeInterval)Properties.Settings.Default.defaultDuration); }
            
            if (Properties.Settings.Default.showWelcome) { preferencesToolStripMenuItem_Click(this,null); }
            timer1.Enabled = true;
            
        }

        /// <summary>
        /// Activate Caffeine to the specified duration. 
        /// </summary>
        /// <param name="duration"></param>
        private void activateCaffeine(TimeInterval duration)
        {
            try
            {
                activationDuration = duration; // Set our duration
                setCaffeineMode(true); // Set caffeine enabled
                notifyIcon1.Icon = Properties.Resources.active;
                notifyIcon1.Text = "Caffeine is active."; // Change our notification icon and text
                activateCaffeineToolStripMenuItem.Text = "Deactivate Caffeine";
            }
            catch (Exception ex) // Catch any errors
            {
                MessageBox.Show(ex.ToString(), Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Deactivate Caffeine
        /// </summary>
        private void deactivateCaffeine()
        {
            try
            {
                setCaffeineMode(false); // Disable caffeine
                notifyIcon1.Icon = Properties.Resources.inactive; // Set our notify icon and text
                notifyIcon1.Text = "Caffeine is inactive.";
                activateCaffeineToolStripMenuItem.Text = "Activate Caffeine";
               
            }
            catch (Exception ex) // Catch any errors
            {
                MessageBox.Show(ex.ToString(), Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Show out about box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void aboutCaffeineToolStripMenuItem_Click(object sender, EventArgs e)
        {
  
            About aboutBox = new About();
            aboutBox.ShowDialog();
        }

        /// <summary>
        /// Deactivate caffeine on exit, and exit the application.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {

            deactivateCaffeine();
            Application.Exit();
        }

        /// <summary>
        /// Show our preferences window (welcome screen)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void preferencesToolStripMenuItem_Click(object sender, EventArgs e)
        {

            PreferenceWindow preferences = new PreferenceWindow();
            preferences.ShowDialog();
        }

        /// <summary>
        /// Get our current enable interval, and disable Caffeine if time has been reached.
        /// </summary>
        private void checkInterval()
        {
            int millis;
            if (activationDuration == TimeInterval.Indefinite) { millis = -1; }
            else { millis = (int)(MinutesToMilliseconds)Enum.Parse(typeof(MinutesToMilliseconds),activationDuration.ToString()); }

            if (getCaffeineMode())
            {
                int currentInterval = getActiveTime(); 
                if ((currentInterval >= millis) && (millis != -1))
                {
                    deactivateCaffeine();
                }
            }
        }
        /// <summary>
        /// Check our interval on every timer tick.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {

            checkInterval();
        }

        /// <summary>
        /// Override application form closing and disable caffeine.
        /// </summary>
        /// <param name="e"></param>
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            
            base.OnFormClosing(e);
            deactivateCaffeine();
        }

        /// <summary>
        /// Activate for x time.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void indefinitelyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            activateCaffeine(TimeInterval.Indefinite);
        }
        /// <summary>
        /// Activate for x time.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void fiveMinuntesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            activateCaffeine(TimeInterval.fiveMinutes);
        }
        /// <summary>
        /// Activate for x time.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tenMinutesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            activateCaffeine(TimeInterval.tenMinutes);
        }
        /// <summary>
        /// Activate for x time.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void fifteenMinutesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            activateCaffeine(TimeInterval.fifteenMinutes);
        }
        /// <summary>
        /// Activate for x time.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void thirtyMinutesToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            activateCaffeine(TimeInterval.thirtyMinutes);
        }
        /// <summary>
        /// Activate for x time.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void oneHourToolStripMenuItem_Click(object sender, EventArgs e)
        {
            activateCaffeine(TimeInterval.oneHour);
        }
        /// <summary>
        /// Activate for x time.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void twoHoursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            activateCaffeine(TimeInterval.twoHours);
        }
        /// <summary>
        /// Activate for x time.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void fiveHoursToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            activateCaffeine(TimeInterval.fiveHours);
        }
        /// <summary>
        /// Toggle caffeine mode for the Activate/Deactivate contect menu.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void contextMenuStrip1_DoubleClick(object sender, EventArgs e)
        {

            bool currentMode = getCaffeineMode();
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
