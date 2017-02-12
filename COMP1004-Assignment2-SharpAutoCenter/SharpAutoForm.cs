//AppName : Sharp Auto Center
//Author's Name : Kinjal Patel  
//Student ID : 200334364
//App Creation Date : 2nd Feb, 2017
//App Description : This is an Appication for Sharp Auto Center with Different cars with different functionalities.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP1004_Assignment2_SharpAutoCenter
{
    public partial class SharpAutoForm : Form
    {
        /// <summary>
        /// This is the entry point for application
        /// </summary>
        public SharpAutoForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This handler is works to exit from the Application via exit menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// This Handler is works to exit from the Appication via Exit Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// For Display About MessageBox Short Summary
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("This is for about message", MessageBoxButtons.OKCancel,MessageBoxIcon.Information);

        }
        /// <summary>
        /// This is for displaying Font dialog from the FontMenuStrip
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialogBox.ShowDialog();
            AmountDueTextBox.Font = fontDialogBox.Font;
            BasePriceTextBox.Font = fontDialogBox.Font;
        }
        /// <summary>
        /// This is for displaying Color dialog from the ColorMenuStrip
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialogBox.ShowDialog();
            AmountDueTextBox.BackColor = colorDialogBox.Color;
            BasePriceTextBox.BackColor = colorDialogBox.Color;
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            

        }
    }
}
