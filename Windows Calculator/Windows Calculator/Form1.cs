using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool pointFlag, equalFlag, plusFlag, minusFlag, multiplicationFlag, divisionFlag, percentFlag;
        private bool rootFlag, cndbz;
        private bool writingMode = true;
        private double previousValue, memoryValue = 0;
        private int memoryCount = 0;
        private double[] memoryArray = new double[5];

        private void Calculation(string button)
        {
            string currentString = bigDisplay.Text;
            string currentString2 = smallDisplay.Text;
            double currentValue = Convert.ToDouble(currentString);
            
            if (plusFlag)
            {
                previousValue += currentValue;
                plusFlag = false;
                bigDisplay.Text = previousValue.ToString();
            }
            else if (minusFlag)
            {
                previousValue -= currentValue;
                minusFlag = false;
                bigDisplay.Text = previousValue.ToString();
            }
            else if (multiplicationFlag)
            {
                previousValue *= currentValue;
                multiplicationFlag = false;
                bigDisplay.Text = previousValue.ToString();
            }
            else if (divisionFlag)
            {
                if(currentValue != 0)
                {
                    previousValue /= currentValue;
                    divisionFlag = false;
                    bigDisplay.Text = previousValue.ToString();
                }
                else
                {
                    cndbz = true;
                    bigDisplay.Text = "Cannot divide by zero";
                    percentButton.Enabled = oneByXButton.Enabled = xSquareButton.Enabled = rootXButton.Enabled = false;
                    divisionButton.Enabled = multiplicationButton.Enabled = minusButton.Enabled = plusButton.Enabled = false;
                }
            }

            if (button == "plus")
            {
                if (currentString2 == "")
                {
                    smallDisplay.Text = currentString + " +";
                    previousValue = currentValue;
                }
                else if(rootFlag)
                {
                    rootFlag = false;
                    smallDisplay.Text += " +";
                }
                else
                {
                    smallDisplay.Text = currentString2 + " " + currentString + " +";
                }

                if (equalFlag)
                {
                    smallDisplay.Text = currentString + " +";
                    equalFlag = false;
                    previousValue = currentValue;
                }
            }
            else if (button == "minus")
            {
                if (currentString2 == "")
                {
                    smallDisplay.Text = currentString + " -";
                    previousValue = currentValue;
                }
                else if (rootFlag)
                {
                    rootFlag = false;
                    smallDisplay.Text += " -";
                }
                else
                {
                    smallDisplay.Text = currentString2 + " " + currentString + " -";
                }

                if (equalFlag)
                {
                    smallDisplay.Text = currentString + " -";
                    equalFlag = false;
                    previousValue = currentValue;
                }
            }
            else if (button == "multiplication")
            {
                if (currentString2 == "")
                {
                    smallDisplay.Text = currentString + " ×";
                    previousValue = currentValue;
                }
                else if (rootFlag)
                {
                    rootFlag = false;
                    smallDisplay.Text += " ×";
                }
                else
                {
                    smallDisplay.Text = currentString2 + " " + currentString + " ×";
                }

                if (equalFlag)
                {
                    smallDisplay.Text = currentString + " ×";
                    equalFlag = false;
                    previousValue = currentValue;
                }
            }
            else if (button == "division")
            {
                if (currentString2 == "")
                {
                    smallDisplay.Text = currentString + " ÷";
                    previousValue = currentValue;
                }
                else if (rootFlag)
                {
                    rootFlag = false;
                    smallDisplay.Text += " ÷";
                }
                else
                {
                    smallDisplay.Text = currentString2 + " " + currentString + " ÷";
                }

                if (equalFlag)
                {
                    smallDisplay.Text = currentString + " ÷";
                    equalFlag = false;
                    previousValue = currentValue;
                }
            }
            else if (button == "equal")
            {
                if (currentString2 == "")
                {
                    smallDisplay.Text = currentString + " =";
                    previousValue = currentValue;
                }
                else if (rootFlag || percentFlag)
                {
                    rootFlag = false;
                    percentFlag = false;
                    smallDisplay.Text += " =";
                }
                else
                {
                    smallDisplay.Text = currentString2 + " " + currentString + " =";
                }
            }

            
            writingMode = false;
            pointFlag = false;
        }

        private void Write(int number)
        {
            string currentString = Convert.ToString(bigDisplay.Text);
            if(cndbz)
            {
                smallDisplay.Text = "";
                cndbz = false;
            }

            if (currentString != "0" && writingMode)
            {
                bigDisplay.Text = currentString + number.ToString();
            }
            else
            {
                writingMode = true;
                bigDisplay.Text = number.ToString();
            }
        }




        private void BackspaceButton_Click(object sender, EventArgs e)
        {
            string currentString = Convert.ToString(bigDisplay.Text);
            int size = currentString.Length;
            if ((currentString != "0") && (size>1))
            {
                int pointCheck = currentString.IndexOf('.');
                if (pointCheck == size-1)
                {
                    pointFlag = false;
                }
                currentString = currentString.Substring(0, size - 1);
                bigDisplay.Text = currentString;
            }
            else
            {
                bigDisplay.Text = "0";
            }
        }
        
        private void ClearButton_Click(object sender, EventArgs e)
        {
            bigDisplay.Text = "0";
            smallDisplay.Text = "";
            previousValue = 0;

            cndbz = false;
            percentButton.Enabled = oneByXButton.Enabled = xSquareButton.Enabled = rootXButton.Enabled = true;
            divisionButton.Enabled = multiplicationButton.Enabled = minusButton.Enabled = plusButton.Enabled = true;
        }

        private void ClearEntryButton_Click(object sender, EventArgs e)
        {
            bigDisplay.Text = "0";

            if(cndbz)
            {
                cndbz = false;
                smallDisplay.Text = "";
                percentButton.Enabled = oneByXButton.Enabled = xSquareButton.Enabled = rootXButton.Enabled = true;
                divisionButton.Enabled = multiplicationButton.Enabled = minusButton.Enabled = plusButton.Enabled = true;
            }
        }
        
        

        

        private void ZeroButton_Click(object sender, EventArgs e)
        {
            Write(0);
        }

        private void OneButton_Click(object sender, EventArgs e)
        {
            Write(1);
        }

        private void TwoButton_Click(object sender, EventArgs e)
        {
            Write(2);
        }

        private void ThreeButton_Click(object sender, EventArgs e)
        {
            Write(3);
        }

        private void FourButton_Click(object sender, EventArgs e)
        {
            Write(4);
        }

        private void FiveButton_Click(object sender, EventArgs e)
        {
            Write(5);
        }

        private void SixButton_Click(object sender, EventArgs e)
        {
            Write(6);
        }
        
        private void SevenButton_Click(object sender, EventArgs e)
        {
            Write(7);
        }

        private void EightButton_Click(object sender, EventArgs e)
        {
            Write(8);
        }
        
        private void NineButton_Click(object sender, EventArgs e)
        {
            Write(9);
        }
        
        private void PointButton_Click(object sender, EventArgs e)
        {
            if(!pointFlag)
            {
                if (writingMode)
                {
                    string currentString = Convert.ToString(bigDisplay.Text);
                    bigDisplay.Text = currentString + ".";
                }
                else
                {
                    bigDisplay.Text = "0.";
                }
                pointFlag = true;
            }
        }

        private void PlusMinusButton_Click(object sender, EventArgs e)
        {
            double currentValue = Convert.ToDouble(bigDisplay.Text);
            currentValue *= (-1);
            bigDisplay.Text = currentValue.ToString();
            
            if (equalFlag)
            {
                smallDisplay.Text = "";
                equalFlag = false;
                previousValue = currentValue;
            }
        }




        private void DivisionButton_Click(object sender, EventArgs e)
        {
            Calculation("division");
            divisionFlag = true;
        }
        
        private void MultiplicationButton_Click(object sender, EventArgs e)
        {
            Calculation("multiplication");
            multiplicationFlag = true;
        }

        private void MinusButton_Click(object sender, EventArgs e)
        {
            Calculation("minus");
            minusFlag = true;
        }

        private void PlusButton_Click(object sender, EventArgs e)
        {
            Calculation("plus");
            plusFlag = true;
        }

        private void EqualButton_Click(object sender, EventArgs e)
        {
            Calculation("equal");
            equalFlag = true;

            previousValue = 0;
        }




        private void RootXButton_Click(object sender, EventArgs e)
        {
            if(equalFlag)
            {
                smallDisplay.Text = "";
            }

            double currentValue = Convert.ToDouble(bigDisplay.Text);
            previousValue = Math.Sqrt(currentValue);
            smallDisplay.Text += "√(" + currentValue.ToString() + ")";
            bigDisplay.Text = previousValue.ToString();
            rootFlag = true;
        }

        private void XSquareButton_Click(object sender, EventArgs e)
        {
            if (equalFlag)
            {
                smallDisplay.Text = "";
            }

            double currentValue = Convert.ToDouble(bigDisplay.Text);
            previousValue = currentValue * currentValue;
            smallDisplay.Text += "sqr(" + currentValue.ToString() + ")";
            bigDisplay.Text = previousValue.ToString();
            rootFlag = true;
        }

        private void OneByXButton_Click(object sender, EventArgs e)
        {
            if (equalFlag)
            {
                smallDisplay.Text = "";
            }

            double currentValue = Convert.ToDouble(bigDisplay.Text);
            previousValue = 1 / currentValue;
            smallDisplay.Text += "1/(" + currentValue.ToString() + ")";
            bigDisplay.Text = previousValue.ToString();
            rootFlag = true;
        }

        private void PercentButton_Click(object sender, EventArgs e)
        {
            percentFlag = true;

            if (!plusFlag && !minusFlag && !multiplicationFlag && !divisionFlag)
            {
                smallDisplay.Text = "0";
                bigDisplay.Text = "0";
            }
            else
            {
                double currentValue = Convert.ToDouble(bigDisplay.Text);
                currentValue /= 100;
                bigDisplay.Text = currentValue.ToString();
                smallDisplay.Text += " " + currentValue.ToString();
            }
        }




        private void MemoryPlusButton_Click(object sender, EventArgs e)
        {
            memoryButton.Enabled = memoryClearButton.Enabled = memoryReadButton.Enabled = true;

            smallDisplay.Text = "";
            double currentValue = Convert.ToDouble(bigDisplay.Text);
            memoryValue += currentValue;
            writingMode = false;
        }

        private void MemoryMinusButton_Click(object sender, EventArgs e)
        {
            memoryButton.Enabled = memoryClearButton.Enabled = memoryReadButton.Enabled = true;

            smallDisplay.Text = "";
            double currentValue = Convert.ToDouble(bigDisplay.Text);
            memoryValue -= currentValue;
            writingMode = false;
        }

        private void MemorySaveButton_Click(object sender, EventArgs e)
        {
            memoryButton.Enabled = memoryClearButton.Enabled = memoryReadButton.Enabled = true;

            smallDisplay.Text = "";
            double currentValue = Convert.ToDouble(bigDisplay.Text);
            memoryValue = currentValue;
            writingMode = false;


            if (memoryCount < 5)
            {
                memoryArray[memoryCount] = memoryValue;
                memoryCount++;
            }
            else
            {
                for (int i = 0; i < 4; i++)
                {
                    memoryArray[i] = memoryArray[i + 1];
                }
                memoryArray[memoryCount - 1] = memoryValue;
            }
        }

        private void MemoryReadButton_Click(object sender, EventArgs e)
        {
            bigDisplay.Text = memoryValue.ToString();
            writingMode = false;
        }

        private void MemoryClearButton_Click(object sender, EventArgs e)
        {
            memoryButton.Enabled = memoryClearButton.Enabled = memoryReadButton.Enabled = false;
            memoryValue = 0;
            memoryCount = 0;

            bigDisplay.Text = "0";
        }

        private void MemoryButton_Click(object sender, EventArgs e)
        {
            smallDisplay.Text = "";

            if (memoryCount < 0)
            {
                bigDisplay.Text = memoryValue.ToString();
            }
            else
            {
                bigDisplay.Text = "";
                for (int i=0; i<=memoryCount; i++)
                {
                    if(i==5)
                    {
                        continue;
                    }
                    bigDisplay.Text += " " + memoryArray[i].ToString();
                }
            }
        }

    }
}
