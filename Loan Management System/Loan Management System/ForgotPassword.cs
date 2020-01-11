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
    public partial class ForgotPassword : Form
    {
        public ForgotPassword()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=PC-TAJNUR\\SQLEXPRESS;Initial Catalog=LMS;Integrated Security=True");
        SqlDataAdapter da;
        DataTable dt = new DataTable();
        DataRow dr;

        String username, password, mobileNumber;

        private void ForgotPassword_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Restart();
        }

        private void getUsernameButton_Click(object sender, EventArgs e)
        {
            try
            {
                mobileNumber = mobileNumberTextBox.Text.ToString();

                String query = "SELECT username, password FROM users WHERE mobile = " + mobileNumber + " ;";
                da = new SqlDataAdapter(query, con);
                da.Fill(dt);
                con.Close();

                dr = dt.Rows[0];

                if (dt.Rows.Count == 1)
                {
                    username = dr[0].ToString();
                    password = dr[1].ToString();

                    MessageBox.Show("A message has been sent to your mobile number with your Username and Password.\nThank You.", "Message Sent");

                    MessageBox.Show("Your username: " + username + " and password: " + password + ". Do not share this username and password with others.", "Message");
                }
            }
            catch(Exception errors)
            {
                MessageBox.Show("Mobile number not found.", "Mobile Number Error");
            }
        }
    }
}
