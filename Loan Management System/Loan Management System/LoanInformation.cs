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
    public partial class LoanInformation : Form
    {
        public LoanInformation(string fullName)
        {
            InitializeComponent();
            userFullNameTextBox.Text = fullName;

            load_loan_id();
        }

        public void load_loan_id()
        {
            string sqlQuery = "SELECT * FROM statistic WHERE type_name = 'Loan';";

            SqlConnection con = new SqlConnection("Data Source=PC-TAJNUR\\SQLEXPRESS;Initial Catalog=LMS;Integrated Security=True");
            SqlDataAdapter da;
            DataTable dt = new DataTable();
            DataRow dr;

            con.Open();
            da = new SqlDataAdapter(sqlQuery, con);
            da.Fill(dt);
            dr = dt.Rows[0];
            con.Close();

            int count = Convert.ToInt32(dr[1]);
            count += 5000001;
            loanIdTextBox.Text = count.ToString();
        }

        private void LoanInformation_FormClosed(object sender, FormClosedEventArgs e)
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
            menuPanel.Visible = false;
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
            String fullName = userFullNameTextBox.Text.ToString();
            this.Hide();
            LoanAgreement loanAgreement = new LoanAgreement(fullName);
            loanAgreement.Show();
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
        private void searchButton_Click_1(object sender, EventArgs e)
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
                string customerId = dr[1].ToString();
                string name = dr[2].ToString();
                string loanAmount = dr[3].ToString();
                string loanType = dr[4].ToString();
                string cashReceived = dr[12].ToString();

                if (dt.Rows.Count == 1)
                {
                    loanIdTextBox.Text = loanId;
                    customerIdTextBox.Text = customerId;
                    nameTextBox.Text = name;
                    loanAmountTextBox.Text = loanAmount;
                    loanTypeComboBox.Text = loanType;

                    loanAmount2TextBox.Text = loanAmount;
                    cashReceivedTextBox.Text = cashReceived;
                    double tempLoanAmount = Convert.ToDouble(loanAmount);
                    double tempCashReceive = Convert.ToDouble(cashReceived);
                    double cashDue = tempLoanAmount - tempCashReceive;
                    cashDueTextBox.Text = cashDue.ToString();
                }

            }
            catch (Exception error)
            {
                MessageBox.Show("Loan ID not found.", "Wrong ID");
                searchTextBox.Text = null;
                customerIdTextBox.Text = null;
                nameTextBox.Text = null;
                loanAmountTextBox.Text = null;
                loanTypeComboBox.Text = null;

                loanAmount2TextBox.Text = null;
                cashReceivedTextBox.Text = null;
                cashDueTextBox.Text = null;

                load_loan_id();
            }
        }

        //Save Button Procedure
        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                string loanId, customerId, name, loanAmount, loanType, dateTime;
                                
                loanId = loanIdTextBox.Text.ToString();
                customerId = customerIdTextBox.Text.ToString();
                name = nameTextBox.Text.ToString();
                loanAmount = loanAmountTextBox.Text.ToString();
                loanType = loanTypeComboBox.Text.ToString();
                dateTime = System.DateTime.Today.ToString();

                string sqlQuery = "INSERT INTO loan_information VALUES('" + loanId + "', '" + customerId + "', '" + name + "', " + loanAmount + ", '" + loanType + "', ' ', ' ', ' ', ' ', ' ', ' ', '" + dateTime + "', '0.00', '0');";
                string customerValidity = "SELECT id FROM customer_information WHERE id = '" + customerId + "' ;";

                SqlConnection con = new SqlConnection("Data Source=PC-TAJNUR\\SQLEXPRESS;Initial Catalog=LMS;Integrated Security=True");
                SqlDataAdapter tda;
                DataTable tdt = new DataTable();
                DataRow tdr;

                con.Open();
                tda = new SqlDataAdapter(customerValidity, con);
                tda.Fill(tdt);
                tdr = tdt.Rows[0];

                SqlCommand sqlcmd = new SqlCommand(sqlQuery, con);
                sqlcmd.ExecuteScalar();

                MessageBox.Show("New loan information save successfully.", "Successful");

                searchTextBox.Text = null;
                customerIdTextBox.Text = null;
                nameTextBox.Text = null;
                loanAmountTextBox.Text = null;
                loanTypeComboBox.Text = null;

                loanAmount2TextBox.Text = null;
                cashReceivedTextBox.Text = null;
                cashDueTextBox.Text = null;

                sqlQuery = "SELECT * FROM statistic WHERE type_name = 'Loan';";
                SqlDataAdapter da;
                DataTable dt = new DataTable();
                DataRow dr;


                da = new SqlDataAdapter(sqlQuery, con);
                da.Fill(dt);
                dr = dt.Rows[0];
                int count = Convert.ToInt32(dr[1]);
                count++;
                sqlQuery = "update statistic set total_count = '" + count.ToString() + "' where type_name = 'Loan';";
                SqlCommand sqlCommand = new SqlCommand(sqlQuery, con);
                sqlCommand.ExecuteScalar(); 
                con.Close();

                load_loan_id();
            }
            catch (Exception error)
            {
                MessageBox.Show("Give correct input", "Wrong Information");

            }
        }
                
        //Delete Button Procedure
        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                string loanId = loanIdTextBox.Text.ToString();

                string sqlQuery = "SELECT * FROM loan_information WHERE loan_id ='" + loanId + "';";
                string deleteStatement = "DELETE FROM loan_information WHERE loan_id = '" + loanId + "';";

                SqlConnection con = new SqlConnection("Data Source=PC-TAJNUR\\SQLEXPRESS;Initial Catalog=LMS;Integrated Security=True");
                SqlDataAdapter da;
                DataTable dt = new DataTable();
                DataRow dr;

                da = new SqlDataAdapter(sqlQuery, con);
                da.Fill(dt);
                if (dt.Rows.Count == 1)
                {
                    SqlCommand sqlCommand = new SqlCommand(deleteStatement, con);

                    if (MessageBox.Show("Are you really want to delete this loan Information?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        con.Open();
                        sqlCommand.ExecuteScalar();
                        con.Close();

                        MessageBox.Show("Loan information successfully deleted.", "Deleted");
                    }
                }
                else
                {
                    MessageBox.Show("Customer not found.", "Invalid Customer");
                }

                searchTextBox.Text = null;
                customerIdTextBox.Text = null;
                nameTextBox.Text = null;
                loanAmountTextBox.Text = null;
                loanTypeComboBox.Text = null;

                loanAmount2TextBox.Text = null;
                cashReceivedTextBox.Text = null;
                cashDueTextBox.Text = null;

                load_loan_id();

            }
            catch (Exception error)
            {
                MessageBox.Show("Loan ID not found.", "Invalid Loan ID");

            }
        }

        //Print Button Procedure
        private void printButton_Click(object sender, EventArgs e)
        {

        }


        //Next page
        private void nextButton_Click(object sender, EventArgs e)
        {
            String fullName = userFullNameTextBox.Text.ToString();
            this.Hide();
            SattlementDetails sattlementDetails = new SattlementDetails(fullName);
            sattlementDetails.Show();
        }

        //Previous page
        private void backButton_Click(object sender, EventArgs e)
        {
            String fullName = userFullNameTextBox.Text.ToString();
            this.Hide();
            CustomerInformation customerInformation = new CustomerInformation(fullName);
            customerInformation.Show();
        }


    }
}
