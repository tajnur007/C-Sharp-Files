using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Loan_Management_System
{
    public partial class CreateAccount : Form
    {
        public CreateAccount()
        {
            InitializeComponent();
        }


        //Variable declaration start
        string username, fullname, designation, mobileNumber, password, confirmPassword;

        private void createAccountButton_Click(object sender, EventArgs e)
        {
            username = userNameTextBox.Text.ToLower().ToString();
            fullname = fullNameTextBox.Text.ToString();
            designation = designationTextBox.Text.ToString();
            mobileNumber = mobileNumberTextBox.Text.ToString();
            password = passwordTextBox.Text.ToString();
            confirmPassword = confirmPasswordTextBox.Text.ToString();

            try
            {
                if (password != confirmPassword)
                {
                    MessageBox.Show("Password does not match.");
                }
                else
                {
                    String sqlStatement = "INSERT INTO users VALUES ('" + username + "', '" + fullname + "', '" + designation + "', '" + mobileNumber + "', '" + password + "', 'false')";

                    SqlConnection con = new SqlConnection("Data Source=PC-TAJNUR\\SQLEXPRESS;Initial Catalog=LMS;Integrated Security=True");
                    SqlCommand sqlcmd = new SqlCommand(sqlStatement, con);
                    con.Open();
                    sqlcmd.ExecuteScalar();
                    con.Close();

                    MessageBox.Show("User successfully created.\nWait for activate of your account by Administrator.\nThank You.", "Success");
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("User is not created.", "Error");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void CreateAccount_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Restart();
        }

        private void termsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (termsCheckBox.Checked)
            {
                createAccountButton.Enabled = true;
            }
            else if (!termsCheckBox.Checked)
            {
                createAccountButton.Enabled = false;
            }
        }
    }
}
