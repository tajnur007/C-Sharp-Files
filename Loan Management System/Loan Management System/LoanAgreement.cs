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
    public partial class LoanAgreement : Form
    {
        public LoanAgreement(string fullName)
        {
            InitializeComponent();
            userFullNameTextBox.Text = fullName;
            saveButton.Enabled = false;
        }

        private void LoanAgreement_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            if (!menuPanel.Visible)
            {
                menuPanel.Visible = true;
            }
            else
            {
                menuPanel.Visible = false;
            }
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You are successfully logged out.", "Logout");
            Application.Restart();
        }

        //Button click action in Menu
        private void menuDashboardButton_Click(object sender, EventArgs e)
        {
            String fullName = userFullNameTextBox.Text.ToString();
            this.Hide();
            Dashboard dashboard = new Dashboard(fullName);
            dashboard.Show();
        }

        private void menuCustomerInformationButton_Click(object sender, EventArgs e)
        {
            String fullName = userFullNameTextBox.Text.ToString();
            this.Hide();
            CustomerInformation customerInformation = new CustomerInformation(fullName);
            customerInformation.Show();
        }

        private void menuLoanInformationButton_Click(object sender, EventArgs e)
        {
            String fullName = userFullNameTextBox.Text.ToString();
            this.Hide();
            LoanInformation loanInformation = new LoanInformation(fullName);
            loanInformation.Show();
        }

        private void menuSattlementDetailsButton_Click(object sender, EventArgs e)
        {
            String fullName = userFullNameTextBox.Text.ToString();
            this.Hide();
            SattlementDetails sattlementDetails = new SattlementDetails(fullName);
            sattlementDetails.Show();
        }

        private void menuAccusativeCaseButton_Click(object sender, EventArgs e)
        {
            String fullName = userFullNameTextBox.Text.ToString();
            this.Hide();
            AccusativeCase accusativeCase = new AccusativeCase(fullName);
            accusativeCase.Show();
        }

        private void menuLoanAgreementButton_Click(object sender, EventArgs e)
        {
            menuPanel.Visible = false;
        }

        private void menuCashReceiveButton_Click(object sender, EventArgs e)
        {
            String fullName = userFullNameTextBox.Text.ToString();
            this.Hide();
            CashReceive cashReceive = new CashReceive(fullName);
            cashReceive.Show();
        }

        private void menuAboutUsButton_Click(object sender, EventArgs e)
        {
            String fullName = userFullNameTextBox.Text.ToString();
            this.Hide();
            AboutUs aboutUs = new AboutUs(fullName);
            aboutUs.Show();
        }


        //Control Buttons
        //Search Button Procedure
        private void searchButton_Click(object sender, EventArgs e)
        {
            try
            {
                string searchId = searchTextBox.Text.ToString();

                string sqlQuery = "SELECT * FROM loan_information WHERE loan_id =" + searchId + ";";

                SqlConnection con = new SqlConnection("Data Source=PC-TAJNUR\\SQLEXPRESS;Initial Catalog=LMS;Integrated Security=True");
                SqlDataAdapter da;
                DataTable dt = new DataTable();
                DataRow dr;

                con.Open();
                da = new SqlDataAdapter(sqlQuery, con);
                da.Fill(dt);
                con.Close();

                dr = dt.Rows[0];
                string loanId = dr[0].ToString();

                if (dt.Rows.Count == 1)
                {
                    loanIdTextBox.Text = loanId;
                }

            }
            catch (Exception error)
            {
                MessageBox.Show("Loan ID not found.", "Wrong ID");
                searchTextBox.Text = null;
                loanIdTextBox.Text = null;
            }
        }

        //Save Button Procedure
        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                string loanId = loanIdTextBox.Text.ToString();

                string sqlQuery = "UPDATE loan_information SET loan_agreement = 'Accepted' WHERE loan_id = " + loanId + ";";

                SqlConnection con = new SqlConnection("Data Source=PC-TAJNUR\\SQLEXPRESS;Initial Catalog=LMS;Integrated Security=True");
                SqlCommand sqlcmd = new SqlCommand(sqlQuery, con);
                con.Open();
                sqlcmd.ExecuteScalar();
                con.Close();

                MessageBox.Show("Record saved successfully.", "Successful");

                loanIdTextBox.Text = null;
            }
            catch (Exception error)
            {
                MessageBox.Show("Give correct input", "Wrong Information");

            }
        }




        //Next page
        private void nextButton_Click(object sender, EventArgs e)
        {
            String fullName = userFullNameTextBox.Text.ToString();
            this.Hide();
            CashReceive cashReceive = new CashReceive(fullName);
            cashReceive.Show();
        }

        //Previous page
        private void backButton_Click(object sender, EventArgs e)
        {
            String fullName = userFullNameTextBox.Text.ToString();
            this.Hide();
            AccusativeCase accusativeCase = new AccusativeCase(fullName);
            accusativeCase.Show();
        }

        private void termsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (termsCheckBox.Checked)
            {
                saveButton.Enabled = true;
            }
            else if (!termsCheckBox.Checked)
            {
                saveButton.Enabled = false;
            }
        }


    }
}
