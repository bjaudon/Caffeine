using System.Windows.Forms;
using Microsoft.Win32;

namespace Caffeine
{
    public partial class PreferenceWindow : Form
    {
        RegistryKey rk = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);

        public PreferenceWindow()
        {
            InitializeComponent();
            comboDefaultDuration.SelectedIndex = Properties.Settings.Default.defaultDuration;
            chkLaunchatStartup.Checked = Properties.Settings.Default.activateAtLaunch;
            chkShowMessage.Checked = Properties.Settings.Default.showWelcome;
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
            Properties.Settings.Default.defaultDuration = comboDefaultDuration.SelectedIndex;
            Properties.Settings.Default.Save();
        }

        private void chkAutoStart_CheckedChanged(object sender, System.EventArgs e)
        {
            
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
            Properties.Settings.Default.activateAtLaunch = chkLaunchatStartup.Checked;
            Properties.Settings.Default.Save();
        }

        private void chkShowMessage_CheckedChanged(object sender, System.EventArgs e)
        {
            Properties.Settings.Default.showWelcome = chkShowMessage.Checked;
            Properties.Settings.Default.Save();
        }
    }
}
