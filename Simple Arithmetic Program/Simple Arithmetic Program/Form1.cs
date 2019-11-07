using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simple_Arithmetic_Program
{
    public partial class SimpleArithmeticProgram : Form
    {
        /*
         * Text Box Variables
         *      firstNumberTextBox
         *      secondNumberTextBox
         *      resultNumberTextBox
         *      
         * Button Variables
         *      plusButton
         *      minusButton
         *      multiplicationButton
         *      divisionButton
         *      clearButton
         *      
         * Label Variables
         *      hintsLabel
         *      resultLabel
         *      resultViewLabel
         */

        //Variable declaration 
        double firstNumber, secondNumber, result;
        string inputMessage = "Please give correct input.";

        public SimpleArithmeticProgram()
        {
            InitializeComponent();
        }

        private void FirstNumberTextBox_TextChanged(object sender, EventArgs e)
        {
            showHints();
        }

        private void SecondNumberTextBox_TextChanged(object sender, EventArgs e)
        {
            showHints();
        }

        private void HintsLabel_Click(object sender, EventArgs e)
        {
            
        }

        private void showHints()
        {
            if (firstNumberTextBox.Text == "")
            {
                hintsLabel.Text = "*Hints: Enter the first number.";
            }
            else if (firstNumberTextBox.Text != "" && secondNumberTextBox.Text == "")
            {
                hintsLabel.Text = "*Hints: Enter the second number.";
            }
            else if (firstNumberTextBox.Text != "" && secondNumberTextBox.Text != "")
            {
                hintsLabel.Text = "*Hints: Press a button to get result.";
            }
        }

        private void PlusButton_Click(object sender, EventArgs e)
        {
            if (firstNumberTextBox.Text != "" && secondNumberTextBox.Text != "")
            {
                firstNumber = Convert.ToDouble(firstNumberTextBox.Text);
                secondNumber = Convert.ToDouble(secondNumberTextBox.Text);
                result = firstNumber + secondNumber;
                resultViewLabel.Text = "Addition is: " + result;
            }
            else
            {
                MessageBox.Show(inputMessage);
            }
        }

        private void MinusButton_Click(object sender, EventArgs e)
        {
            if(firstNumberTextBox.Text != "" && secondNumberTextBox.Text != "")
            {
                firstNumber = Convert.ToDouble(firstNumberTextBox.Text);
                secondNumber = Convert.ToDouble(secondNumberTextBox.Text);
                result = firstNumber - secondNumber;
                resultViewLabel.Text = "Substitution is: " + result;
            }
            else
            {
                MessageBox.Show(inputMessage);
            }
        }

        private void MultiplicationButton_Click(object sender, EventArgs e)
        {
            if(firstNumberTextBox.Text != "" && secondNumberTextBox.Text != "")
            {
                firstNumber = Convert.ToDouble(firstNumberTextBox.Text);
                secondNumber = Convert.ToDouble(secondNumberTextBox.Text);
                result = firstNumber * secondNumber;
                resultViewLabel.Text = "Multiplication is: " + result;
            }
            else
            {
                MessageBox.Show(inputMessage);
            }
        }

        private void FirstNumberTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void SecondNumberTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void DivisionButton_Click(object sender, EventArgs e)
        {
            if (firstNumberTextBox.Text != "" && secondNumberTextBox.Text != "")
            {
                firstNumber = Convert.ToDouble(firstNumberTextBox.Text);
                secondNumber = Convert.ToDouble(secondNumberTextBox.Text);

                if (secondNumber == 0.0)
                {
                    string message = "Arithmatic Error! Something cannot divided by zero(0).";
                    MessageBox.Show(message);
                }
                else
                {
                    result = firstNumber / secondNumber;
                    resultViewLabel.Text = "Division is: " + result;
                }
            }
            else
            {
                MessageBox.Show(inputMessage);
            }      
            
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            firstNumberTextBox.Text = null;
            secondNumberTextBox.Text = null;
            resultViewLabel.Text = null;
        }
    }
}
