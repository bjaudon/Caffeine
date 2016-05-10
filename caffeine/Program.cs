﻿using System;
using System.Windows.Forms;
using System.Threading;

namespace Caffeine
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>


        //Ensure only one copy of Caffeine is running at a time.
        static Mutex mutex = new Mutex(true, "{cfb38b98-cccc-452e-8d48-fd2562757fbd}");

        [STAThread]
        static void Main()
        {
            if (mutex.WaitOne(TimeSpan.Zero,true))
            {
                try
                {
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    Application.Run(new Form1());
                }
                finally
                {
                    mutex.ReleaseMutex();
                }
            }
            else { MessageBox.Show("Only one instance of Caffeine can be run at a time!", "Caffeine", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            
        }
    }
}