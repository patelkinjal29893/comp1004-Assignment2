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
              MessageBox.Show("This is for about message");

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
        /// <summary>
        /// Clear Button handler for set all values of each controls to null or default
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <param name="form"></param>

        private void ClearButton_Click(object sender, EventArgs e)
        {
            // Set values to null
            this.AmountDueTextBox = null;
            this.BasePriceTextBox = null;
            this.SubTotalTextBox = null;
            this.SalesTaxTextBox = null;
            this.TotalTextBox = null;
            this.TradeInAllowanceTextBox = null;
            this.AmountDueTextBox = null;

            // Set allchecked value to false
            this.StereoSystemCheckBox.Checked = false;
            this.ComputerNavigatorCheckBox.Checked = false;
            this.LeatherInteriorCheckBox.Checked = false;

            // Select default radio button
            this.StandardRadioButton.Select();
        }

        /// <summary>
        /// Private method for track radio button and check box event handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _checkedEvent(bool value)
        {
            const double StereoSystem = 380.75;
            const double Leather = 832.50;
            const double Navigator = 1470.99;
            const double Detailing = 495.58;
            const double Pearlizing = 364.83;

            if (StereoSystemCheckBox.Checked == true)
            {
                AdditionalOptionsTextBox.Text += StereoSystem;
            }
            if (LeatherInteriorCheckBox.Checked == true)
            {
                AdditionalOptionsTextBox.Text += Leather;
            }
            if (ComputerNavigatorCheckBox.Checked == true)
            {
                AdditionalOptionsTextBox.Text += Navigator;
            }
            if (CustomizedDetailingRadioButton.Checked == true)
            {
                AdditionalOptionsTextBox.Text += Detailing;
            }
            if (PearlizedRadioButton.Checked == true)
            {
                AdditionalOptionsTextBox.Text += Pearlizing;
            }

            // Display the Additional options Price in the appropriate TextBox
            AdditionalOptionsTextBox.Text = (AdditionalOptionsTextBox.Text.ToString());
        }
      
        /// <summary>
        /// Calculate Button Handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CalculateButton_Click(object sender, EventArgs e)
        {
            //variables
            double _basePrice;
            double _additionalOptions;            
            double _subTotal;
            double _salesTax;
            double _total;
            double _allowance;
            double _amountDue;
           
            //TRY & CATCH blocks
            try
            {
                _basePrice = Convert.ToDouble(BasePriceTextBox.Text);
            }
            catch
            {
                _basePrice = 0;
            }
            try
            {
                _additionalOptions = Convert.ToDouble(AdditionalOptionsTextBox.Text);
            }
            catch
            {
                _additionalOptions = 0;
            }

            try
            {
                _allowance = Convert.ToDouble(TradeInAllowanceTextBox.Text);
            }
            catch
            {
                _allowance = 0;
            }
           
            //Calculation for SalesTax , SubTotal and AmountDue
            _subTotal = _additionalOptions + _basePrice;
            _salesTax = _subTotal * 0.13;
            _total = _subTotal + _salesTax;
            _amountDue = _total - _allowance;

            
            SubTotalTextBox.Text = Convert.ToString(_subTotal);
            SalesTaxTextBox.Text = Convert.ToString(_salesTax);
            TotalTextBox.Text = Convert.ToString(_total);
            AmountDueTextBox.Text = Convert.ToString(_amountDue);
        }
        /// <summary>
        /// Stereo System Handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StereoSystemCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            _checkedEvent(StereoSystemCheckBox.Checked);
            _checkedEvent(LeatherInteriorCheckBox.Checked);
            _checkedEvent(ComputerNavigatorCheckBox.Checked);

            _checkedEvent(StandardRadioButton.Checked);
            _checkedEvent(PearlizedRadioButton.Checked);
            _checkedEvent(CustomizedDetailingRadioButton.Checked);
        }
    }
}


