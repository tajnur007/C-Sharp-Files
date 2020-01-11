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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            try
            {
                string userName = userNameTextBox.Text.ToString();
                string password = passwordTextBox.Text.ToString();

                string sqlQuery = "SELECT * FROM users WHERE username='" + userName + "' AND password='" + password + "';";

                SqlConnection con = new SqlConnection("Data Source=PC-TAJNUR\\SQLEXPRESS;Initial Catalog=LMS;Integrated Security=True");
                SqlDataAdapter da;
                DataTable dt = new DataTable();
                DataRow dr;

                da = new SqlDataAdapter(sqlQuery, con);
                da.Fill(dt);
                con.Close();

                dr = dt.Rows[0];
                string fullName = dr[1].ToString();
                string status = dr[5].ToString();

                if(status == "false")
                {
                    MessageBox.Show("Wait for activate your account.", "Warning");
                }
                else if(dt.Rows.Count == 1)
                {
                    MessageBox.Show("Welcome " + fullName + "\nYou are successfully logged in LMS.", "Welcome");
                    this.Hide();
                    Dashboard dashboard = new Dashboard(fullName);
                    dashboard.Show();
                }

                passwordTextBox.Text = "";
            }
            catch(Exception error)
            {
                MessageBox.Show("Username/Password dosen't match.\nPlease input correct username and password.", "Incorrect Username/Password");
                passwordTextBox.Text = "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            CreateAccount createAccount = new CreateAccount();
            createAccount.Show();
        }

        private void forgoLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            ForgotPassword forgotPassword = new ForgotPassword();
            forgotPassword.Show();
        }
    }

}
