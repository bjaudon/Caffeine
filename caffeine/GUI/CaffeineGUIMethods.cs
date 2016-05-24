/*
 * Name: CaffeineGUIMain Class - GUI Methods
 * Synopsis: Main Forms Class - GUI Methods
 * Author: Bryan Jaudon<bryan.jaudon@gmail.com>
 * Date: 5/23/2016
 */

using System;
using System.Drawing;
using System.Windows.Forms;
using static Caffeine.CaffeineCore;
using static Caffeine.CaffeineEnums;
using static Caffeine.CaffeineStrings;


namespace Caffeine
{
    public partial class CaffeineGUIMain : ApplicationContext
    {
        /// <summary>
        /// Define our Active and Inactive icons.
        /// </summary>
        Icon _activeIcon = Properties.Resources._16x16_Active;
        Icon _inactiveIcon = Properties.Resources._16x16_Inactive;

        /// <summary>
        /// Declare our activationDuration interval
        /// </summary>
        TimeInterval _activationDuration;

        /// <summary>
        /// Caffeine Main window. Hidden from view because we only use the NotifyIcon.
        /// </summary>
        public CaffeineGUIMain()
        {

            InitializeComponent();

            // Set initial state as deactivated.
            notifyIcon1.Icon = _inactiveIcon;
            notifyIcon1.Text = _strCaffeineInactive;
            activateCaffeineToolStripMenuItem.Text = _strActivateCaffeine;

            // Load User Preferences
            if (Properties.Settings.Default.activateAtLaunch) { activateCaffeine((TimeInterval)Properties.Settings.Default.defaultDuration); }

            if (Properties.Settings.Default.showWelcome) { preferencesToolStripMenuItem_Click(this, null); }
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
                _activationDuration = duration; // Set our duration
                setCaffeineMode(true); // Set caffeine enabled
                notifyIcon1.Icon = _activeIcon;
                notifyIcon1.Text = _strCaffeineActive; // Change our notification icon and text
                activateCaffeineToolStripMenuItem.Text = _strDeactivateCaffeine;
            }
            catch (Exception ex) // Catch any errors
            {
                MessageBox.Show(ex.ToString(), _strName, MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                notifyIcon1.Icon = _inactiveIcon; // Set our notify icon and text
                notifyIcon1.Text = _strCaffeineInactive;
                activateCaffeineToolStripMenuItem.Text = _strActivateCaffeine;

            }
            catch (Exception ex) // Catch any errors
            {
                MessageBox.Show(ex.ToString(), _strName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Toggles the caffeine mode
        /// </summary>
        private void toggleCaffeineMode()
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

        /// <summary>
        /// Get our current enable interval, and disable Caffeine if time has been reached.
        /// </summary>
        private void checkInterval()
        {
            int millis;
            if (_activationDuration == TimeInterval.Indefinite) { millis = -1; }
            else { millis = (int)(MinutesToMilliseconds)Enum.Parse(typeof(MinutesToMilliseconds), _activationDuration.ToString()); }

            if (getCaffeineMode())
            {
                int currentInterval = getActiveTime();
                if ((currentInterval >= millis) && (millis != -1))
                {
                    deactivateCaffeine();
                }
            }
        }
    }
}
