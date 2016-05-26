/*
 * Name: Program Class
 * Synopsis: Main Program entry
 * Author: Bryan Jaudon <bryan.jaudon@gmail.com>
 * Date: 5/10/2016
 */

using System;
using System.Windows.Forms;
using System.Threading;

namespace Caffeine
{
    static class Program
    {

        // Use Mutex to ensure only one copy of Caffeine is running at a time.
        static Mutex mutex = new Mutex(true, "{cfb38b98-cccc-452e-8d48-fd2562757fbd}");

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (mutex.WaitOne(TimeSpan.Zero, true))
            {
                try
                {
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    Application.Run(new CaffeineGUIMain());
                }
                finally
                {
                    mutex.ReleaseMutex();
                }
            }
        }
    }
}
