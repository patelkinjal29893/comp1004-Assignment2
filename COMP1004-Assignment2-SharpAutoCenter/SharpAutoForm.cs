//AppName : Sharp Auto Center
//Author's Name : Kinjal Patel  
//Student ID : 200334364
//App Creation Date : 6th February, 2017
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
            //1. Create a new AboutForm using About Box inbuilt form
            AboutForm aboutForm = new AboutForm();

            //2.Show the about form with ShowDialog
            aboutForm.ShowDialog();

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
            // Set all textboxes to blank
            this.AmountDueTextBox.Text = "";
            this.BasePriceTextBox.Text = "";
            this.AdditionalOptionsTextBox.Text = "";
            this.SubTotalTextBox.Text = "";
            this.SalesTaxTextBox.Text = "";
            this.TotalTextBox.Text = "";
            this.TradeInAllowanceTextBox.Text = "";
            this.AmountDueTextBox.Text = "";

            // Set all checkboxes value to false
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
        private void _checkedEvent()
        {
            const double StereoSystem = 380.75;           
            const double Leather = 832.50;          
            const double Navigator = 1470.99;
            const double Standard = 0.0;          
            const double Detailing = 495.58;            
            const double Pearlizing = 364.83;           
            double value = 0.0;

            if (StereoSystemCheckBox.Checked)
            {
                value += StereoSystem;
            }
            if (LeatherInteriorCheckBox.Checked)
            {
                value += Leather;
            }
            if (ComputerNavigatorCheckBox.Checked)
            {
                value += Navigator;
            }
            if (StandardRadioButton.Checked)
            {
                value += Standard;
            }
            if (CustomizedDetailingRadioButton.Checked)
            {
                value += Detailing;
            }
            if (PearlizedRadioButton.Checked)
            {
                value += Pearlizing;
            }
            AdditionalOptionsTextBox.Text = value.ToString("c");
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

            //TRY & CATCH block           
            try
            {
                _basePrice = Convert.ToDouble((BasePriceTextBox.Text as string).TrimStart('$'));
                _additionalOptions = Convert.ToDouble((AdditionalOptionsTextBox.Text as string).TrimStart('$'));
                _allowance = Convert.ToDouble((TradeInAllowanceTextBox.Text as string).TrimStart('$'));
                if (_allowance < 0)
                {
                    MessageBox.Show("You can enter Less than 0");
                    TradeInAllowanceTextBox.Text = "0";
                    _allowance = 0;
                }
            }
            catch
            {
                _basePrice = 0;
                _additionalOptions = 0;
                _allowance = 0;
            }
           
            if (_basePrice < 0)
            {
                MessageBox.Show("You can enter Less than 0");
                BasePriceTextBox.Text = "0";
            }
            else
            {

                //Calculation for SalesTax , SubTotal and AmountDue
                _subTotal = System.Math.Round(_additionalOptions + _basePrice, 2);
                _salesTax = System.Math.Round(_subTotal * 0.13, 2);
                _total = System.Math.Round(_subTotal + _salesTax, 2);
                _amountDue = System.Math.Round((_total - _allowance), 2);


                SubTotalTextBox.Text = "$" + Convert.ToString(_subTotal);
                SalesTaxTextBox.Text = "$" + Convert.ToString(_salesTax);
                TotalTextBox.Text = "$" + Convert.ToString(_total);
                AmountDueTextBox.Text = "$" + Convert.ToString(_amountDue);
            }
        }
        /// <summary>
        /// Private method for update checkBox and radioButton Values
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SharpAutoFunctionalities(object sender, EventArgs e)
        {
            this._checkedEvent();

        }
        /// <summary>
        /// Clear MenuStrip Handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Set all textbox to blank
            this.AmountDueTextBox.Text = "";
            this.BasePriceTextBox.Text = "";
            this.AdditionalOptionsTextBox.Text = "";
            this.SubTotalTextBox.Text = "";
            this.SalesTaxTextBox.Text = "";
            this.TotalTextBox.Text = "";
            this.TradeInAllowanceTextBox.Text = "";
            this.AmountDueTextBox.Text = "";

            // Set all checkboxes value to false
            this.StereoSystemCheckBox.Checked = false;
            this.ComputerNavigatorCheckBox.Checked = false;
            this.LeatherInteriorCheckBox.Checked = false;

            // Select default radio button
            this.StandardRadioButton.Select();
        }
    }
}


