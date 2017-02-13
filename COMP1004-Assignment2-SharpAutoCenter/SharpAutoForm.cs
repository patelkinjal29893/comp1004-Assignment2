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
            this.AmountDueTextBox.Text = "";
            this.BasePriceTextBox.Text = "";
            this.AdditionalOptionsTextBox.Text = "";
            this.SubTotalTextBox.Text = "";
            this.SalesTaxTextBox.Text = "";
            this.TotalTextBox.Text = "";
            this.TradeInAllowanceTextBox.Text = "";
            this.AmountDueTextBox.Text = "";

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
        private void _checkedEvent()
        {
            const double StereoSystem = 380.75;
            double stereoHolder = 0;
            const double Leather = 832.50;
            double leatherHolder = 0;
            const double Navigator = 1470.99;
            double navHolder = 0;
            const double Detailing = 495.58;
            double detailingHolder = 0;
            const double Pearlizing = 364.83;
            double perlHolder = 0;

            if (StereoSystemCheckBox.Checked)
            {
                if (AdditionalOptionsTextBox.Text == "")
                {
                    AdditionalOptionsTextBox.Text = (StereoSystem).ToString();
                }
                else if (AdditionalOptionsTextBox.Text != "")
                {
                    stereoHolder = Convert.ToDouble((AdditionalOptionsTextBox.Text as string).TrimStart('$'));
                    AdditionalOptionsTextBox.Text = (stereoHolder + StereoSystem).ToString();
                }
                else
                {
                    stereoHolder = Convert.ToDouble((AdditionalOptionsTextBox.Text as string).TrimStart('$'));
                    stereoHolder = stereoHolder - StereoSystem;
                    //AdditionalOptionsTextBox.Text = "$" + stereoHolder.ToString();
                }

            }

            if (LeatherInteriorCheckBox.Checked)
            {
                if (AdditionalOptionsTextBox.Text == "")
                {
                    AdditionalOptionsTextBox.Text = (Leather).ToString();
                }
                else if (AdditionalOptionsTextBox.Text != "")
                {
                    leatherHolder = Convert.ToDouble((AdditionalOptionsTextBox.Text as string).TrimStart('$'));
                    AdditionalOptionsTextBox.Text = (leatherHolder + Leather).ToString();
                }
               
            }

            else
            {
                leatherHolder = Convert.ToDouble((AdditionalOptionsTextBox.Text as string).TrimStart('$'));
                leatherHolder = leatherHolder - Leather;
                //AdditionalOptionsTextBox.Text = "$" + leatherHolder.ToString();
            }

            if (ComputerNavigatorCheckBox.Checked)
            {
                if (AdditionalOptionsTextBox.Text == "")
                {
                    AdditionalOptionsTextBox.Text = (Navigator).ToString();
                }
                else if (AdditionalOptionsTextBox.Text != "")
                {
                    navHolder = Convert.ToDouble((AdditionalOptionsTextBox.Text as string).TrimStart('$'));
                    AdditionalOptionsTextBox.Text = (navHolder + Navigator).ToString();
                }
                                
            }
            else
            {
                navHolder = Convert.ToDouble((AdditionalOptionsTextBox.Text as string).TrimStart('$'));
                navHolder = navHolder - Navigator;
                //AdditionalOptionsTextBox.Text = "$" + navHolder.ToString();
            }

            if (CustomizedDetailingRadioButton.Checked)
            {
                if (AdditionalOptionsTextBox.Text == "")
                {
                    AdditionalOptionsTextBox.Text = (Detailing).ToString();
                }
                else if (AdditionalOptionsTextBox.Text != "")
                {
                    detailingHolder = Convert.ToDouble((AdditionalOptionsTextBox.Text as string).TrimStart('$'));
                    AdditionalOptionsTextBox.Text = (detailingHolder + Detailing).ToString();
                }
              
            }
            else
            {
                detailingHolder = Convert.ToDouble((AdditionalOptionsTextBox.Text as string).TrimStart('$'));
                detailingHolder = detailingHolder - Detailing;
                //AdditionalOptionsTextBox.Text = "$" + detailingHolder.ToString();
            }

            if (PearlizedRadioButton.Checked)
            {
                if (AdditionalOptionsTextBox.Text == "")
                {
                    AdditionalOptionsTextBox.Text = (Pearlizing).ToString();
                }
                else if (AdditionalOptionsTextBox.Text != "")
                {
                    perlHolder = Convert.ToDouble((AdditionalOptionsTextBox.Text as string).TrimStart('$'));
                    AdditionalOptionsTextBox.Text = (perlHolder + Navigator).ToString();
                }
            }
            else
            {
                perlHolder = Convert.ToDouble((AdditionalOptionsTextBox.Text as string).TrimStart('$'));
                perlHolder = perlHolder - Pearlizing;
                AdditionalOptionsTextBox.Text = "$" + perlHolder.ToString();
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

            
            SubTotalTextBox.Text = "$" + Convert.ToString(_subTotal);
            SalesTaxTextBox.Text = "$" + Convert.ToString(_salesTax);
            TotalTextBox.Text = "$" + Convert.ToString(_total);
            AmountDueTextBox.Text ="$" + Convert.ToString(_amountDue);
        }
        /// <summary>
        /// Stereo System Handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StereoSystemCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            _checkedEvent();
        }
        /// <summary>
        /// Leather Interior Handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LeatherInteriorCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            _checkedEvent();
        }
        /// <summary>
        /// Computer Navigator Handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ComputerNavigatorCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            _checkedEvent();
        }
        /// <summary>
        /// Standard Radio Button Handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StandardRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            _checkedEvent();
        }
        /// <summary>
        /// Pearlized Radio Button Handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PearlizedRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            _checkedEvent();
        }
        /// <summary>
        /// CustomizedDetailing Radio Button Handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CustomizedDetailingRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            _checkedEvent();
        }

    }
}


