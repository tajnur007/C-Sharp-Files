using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank_Interest_Calculation
{
    public partial class BankInterestCalculation : Form
    {
        /*
         * Combo Box Variables
         *      bankNameComboBox
         *      
         * Text Box Variables
         *      timeTextBox
         *      balanceTextBox
         *      totalInterestTextBox
         * 
         */

        //Variable Declaration
        int time;
        double balance, totalInterest;

        public BankInterestCalculation()
        {
            InitializeComponent();
        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void TimeTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void BalanceTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar == '.'))
            {
                e.Handled = !char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar); 
            }
        }

        private void CalculateInterestButton_Click(object sender, EventArgs e)
        {
            if(timeTextBox.Text=="" || balanceTextBox.Text=="")
            {
                MessageBox.Show("Please give all input.");
            }
            else
            {
                time = Convert.ToInt32(timeTextBox.Text);
                balance = Convert.ToDouble(balanceTextBox.Text);
                if (bankNameComboBox.Text == "SONALI")
                {
                    totalInterest = (balance * 0.08) * (double)time;
                }
                else if (bankNameComboBox.Text == "BRAC")
                {
                    totalInterest = (balance * 0.05) * (double)time;
                }
                else if (bankNameComboBox.Text == "DBBL")
                {
                    totalInterest = (balance * 0.07) * (double)time;
                }
                else if (bankNameComboBox.Text == "HSBC")
                {
                    totalInterest = (balance * 0.06) * (double)time;
                }
                totalInterestTexBox.Text = Convert.ToString(totalInterest);
            }
        }
    }
}
