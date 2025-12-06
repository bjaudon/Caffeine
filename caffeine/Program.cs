/*
 * Name: Program Class
 * Synopsis: Main Program entry
 * Author: Bryan Jaudon <bryan.jaudon@gmail.com>
 * Date: 5/10/2016
 */

using System;
using System.Windows.Forms;

namespace Caffeine
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            // Request Per-Monitor V2 DPI awareness before any UI is created.
            Application.SetHighDpiMode(HighDpiMode.PerMonitorV2);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Run the ApplicationContext that already exists in the project.
            Application.Run(new CaffeineGUIMain());
        }
    }
}
