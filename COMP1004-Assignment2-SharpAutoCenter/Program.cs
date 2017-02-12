//AppName : Sharp Auto Center
//Author's Name : Kinjal Patel  
//Student ID : 200334364
//App Creation Date : 2nd Feb, 2017
//App Description : This is an Appication for Sharp Auto Center with Different cars with different functionalities.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP1004_Assignment2_SharpAutoCenter
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
            Application.Run(new SharpAutoForm());
        }
    }
}
