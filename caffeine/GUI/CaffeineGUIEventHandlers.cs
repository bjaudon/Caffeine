/*
 * Name: CaffeineGUIMain Class - GUI Event Handlers
 * Synopsis: Main Forms Class - GUI Event Handlers
 * Author: Bryan Jaudon<bryan.jaudon@gmail.com>
 * Date: 5/23/2016
 */

using System;
using System.Windows.Forms;
using static Caffeine.CaffeineEnums;

namespace Caffeine
{
    public partial class CaffeineGUIMain : ApplicationContext
    {
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
        /// Check our interval on every timer tick.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {

            checkInterval();
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

            toggleCaffeineMode();

        }

        /// <summary>
        /// MouseDown event to see if user single clicked notify icon with the left button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void notifyIcon1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                toggleCaffeineMode();
            }
        }

        /// <summary>
        /// Application exit event. Cleanup to remove icon.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnApplicationExit(object sender, EventArgs e)
        {

            notifyIcon1.Visible = false;
            deactivateCaffeine();
        }
    }
}
