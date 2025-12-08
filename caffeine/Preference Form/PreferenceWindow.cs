/*
 * Name: Preference Window Form
 * Synopsis: Caffeine Welcome/Preferences window.
 * Author: Bryan Jaudon <bryan.jaudon@gmail.com>
 * Date: 5/10/2016
 */

using System.Windows.Forms;
using Microsoft.Win32;
using static Caffeine.CaffeineStrings;

namespace Caffeine
{
    public partial class PreferenceWindow : Form
    {
        // Our Registry key for Current User Run items.
        RegistryKey rk = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);

        public PreferenceWindow()
        {
            InitializeComponent();

            // Set Texts
            btnClose.Text = _strPrefClose;
            lblWelcome.Text = _strPrefWelcome;
            chkAutoStart.Text = _strPrefAutoStart;
            chkLaunchatStartup.Text = _strPrefActivateAtLaunch;
            chkShowMessage.Text = _strPrefShowThisMessage;
            lblDefaultDuration.Text = _strPrefDefaultDuration;
            comboDefaultDuration.Items.AddRange(new object[] {
            _strPrefIndefinitely, _strPref5Minutes, _strPref10Minutes, _strPref15Minutes, _strPref30Minutes,
            _strPref1Hour, _strPref2Hours, _strPref5Hours,_strPref8Hours,_strPref1Day});
            Text = _strPrefWelcomeTitle;


            // Set our preferences
            comboDefaultDuration.SelectedIndex = Properties.Settings.Default.defaultDuration;
            chkLaunchatStartup.Checked = Properties.Settings.Default.activateAtLaunch;
            chkShowMessage.Checked = Properties.Settings.Default.showWelcome;

            // Check if the Caffeine run value is set. If so, check our box.
            if (rk.GetValue(_strName, null) != null)
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
                rk.SetValue(_strName, "\"" + System.Environment.ProcessPath + "\"", RegistryValueKind.String);
            }
            else
            {
                rk.DeleteValue(_strName, false);
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
