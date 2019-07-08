using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

using Note_Phong.View;

namespace Note_Phong
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
            Application.Run(new Main_form());
        }
    }
}
