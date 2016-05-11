/*
 * Name: Preference Window Form
 * Synopsis: Caffeine Welcome/Preferences window.
 * Author: Bryan Jaudon <bryan.jaudon@gmail.com>
 * Date: 5/10/2016
 */

using System.Windows.Forms;
using Microsoft.Win32;

namespace Caffeine
{
    public partial class PreferenceWindow : Form
    {
        // Our Registry key for Current User Run items.
        RegistryKey rk = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);

        public PreferenceWindow()
        {
            InitializeComponent();
            
            // Set our preferences
            comboDefaultDuration.SelectedIndex = Properties.Settings.Default.defaultDuration;
            chkLaunchatStartup.Checked = Properties.Settings.Default.activateAtLaunch;
            chkShowMessage.Checked = Properties.Settings.Default.showWelcome;
            
            // Check if the Caffeine run value is set. If so, check our box.
            if (rk.GetValue("Caffeine",null) != null)
            {
                chkAutoStart.Checked = true;
            }   
            else
            {
                chkAutoStart.Checked = false;
            }

        }

        private void comboDefaultDuration_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            // Set our Default duration setting.
            Properties.Settings.Default.defaultDuration = comboDefaultDuration.SelectedIndex;
            Properties.Settings.Default.Save();
        }

        private void chkAutoStart_CheckedChanged(object sender, System.EventArgs e)
        {
            // Set our Registry run key for Startup at logon.
            if (chkAutoStart.Checked)
            {
                rk.SetValue("Caffeine", "\"" + System.Reflection.Assembly.GetExecutingAssembly().Location + "\"", RegistryValueKind.String);
            }
            else
            {
                rk.DeleteValue("Caffeine",false);
            }

        }

        private void chkLaunchatStartup_CheckedChanged(object sender, System.EventArgs e)
        {
            // Activate caffeine on startup preference.
            Properties.Settings.Default.activateAtLaunch = chkLaunchatStartup.Checked;
            Properties.Settings.Default.Save();
        }

        private void chkShowMessage_CheckedChanged(object sender, System.EventArgs e)
        {
            // Show the Welcome screen at Caffeine startup preference.
            Properties.Settings.Default.showWelcome = chkShowMessage.Checked;
            Properties.Settings.Default.Save();
        }
    }
}
