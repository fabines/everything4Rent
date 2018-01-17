using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Everything4Rent.Common;

namespace Everything4Rent
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
            main mainForm = new main();
            Router.root = mainForm;
            Application.Run(mainForm);
        }
    }
}
