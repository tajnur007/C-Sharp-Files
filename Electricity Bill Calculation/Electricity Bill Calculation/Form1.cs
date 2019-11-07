using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Electricity_Bill_Calculation
{
    public partial class ElectricityBillCalculation : Form
    {
        /*
         * Radio Button Variables
         *      residentialRadioButton
         *      commercialRadioButton
         *      industrialRadioButton
         *      
         * Button Variables
         *      calculateBillButton
         *      
         * Text Box Variables
         *      peakHourTextBox
         *      offPeakHourTextBox
         *      totalBillTextBox 
         */

        //Variable Declaration
        double peakHour, offPeakHour, totalBill;

        public ElectricityBillCalculation()
        {
            InitializeComponent();
        }

        private void IndustrialRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            offPeakHourTextBox.Enabled = true;
        }

        private void CommercialRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            offPeakHourTextBox.Enabled = false;
        }

        private void PeakHourTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void ResidentialRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            offPeakHourTextBox.Enabled = false;
        }

        private void CalculateBillButton_Click(object sender, EventArgs e)
        {

            if (residentialRadioButton.Checked)
            {
                if(peakHourTextBox.Text == "")
                {
                    MessageBox.Show("Please, give an input.");
                }
                else
                {
                    peakHour = Convert.ToDouble(peakHourTextBox.Text);
                    totalBill = 10.0 + (peakHour * 0.053);
                    totalBillTextBox.Text = Convert.ToString(totalBill) + " Tk.";
                }
            }
            else if (commercialRadioButton.Checked)
            {
                if (peakHourTextBox.Text == "")
                {
                    MessageBox.Show("Please, give an input.");
                }
                else
                {
                    peakHour = Convert.ToDouble(peakHourTextBox.Text);
                    if(peakHour>800.0)
                    {
                        totalBill = 50.0 + ((peakHour - 800) * 0.042);
                    }
                    else
                    {
                        totalBill = 50.0;
                    }
                    totalBillTextBox.Text = Convert.ToString(totalBill) + " Tk.";
                }
            }
            else if (industrialRadioButton.Checked)
            {
                if (peakHourTextBox.Text == "" || offPeakHourTextBox.Text == "")
                {
                    MessageBox.Show("Please, give an input.");
                }
                else
                {
                    peakHour = Convert.ToDouble(peakHourTextBox.Text);
                    offPeakHour = Convert.ToDouble(offPeakHourTextBox.Text);
                    if (peakHour > 800.0)
                    {
                        totalBill = 70.0 + ((peakHour - 800.0) * 0.062);
                    }
                    else
                    {
                        totalBill = 70.0;
                    }
                    if (offPeakHour > 800.0)
                    {
                        totalBill += 35.0 + ((offPeakHour - 800.0) * 0.025);
                    }
                    else
                    {
                        totalBill += 35.0;
                    }
                    totalBillTextBox.Text = Convert.ToString(totalBill) + " Tk.";
                }
            }
        }
    }
}
