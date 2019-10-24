/*
 * ProTimer - Minimalist countdown timer for .NET.
 * Don't forget to change the assembly information.
 * 
 */

using System;
using System.Windows.Forms;

namespace ProTimer
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new Views.MainForm());
        }
    }
}