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
    public partial class CashReceive : Form
    {
        public CashReceive(string fullName)
        {
            InitializeComponent();
            userFullNameTextBox.Text = fullName;
        }

        private void CashReceive_FormClosed(object sender, FormClosedEventArgs e)
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
            String fullName = userFullNameTextBox.Text.ToString();
            this.Hide();
            LoanAgreement loanAgreement = new LoanAgreement(fullName);
            loanAgreement.Show();
        }

        private void menuCashReceiveButton_Click(object sender, EventArgs e)
        {
            menuPanel.Visible = false;
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
                string searchLoanId = searchLoanIdTextBox.Text.ToString();
                string searchMonth = searchMonthComboBox.Text.ToString();
                string searchYear = searchYearTextBox.Text.ToString();


                string sqlQuery;
                if (searchYear != "")
                {
                    SqlConnection con = new SqlConnection("Data Source=PC-TAJNUR\\SQLEXPRESS;Initial Catalog=LMS;Integrated Security=True");
                    SqlDataAdapter da;
                    DataTable dt = new DataTable();
                    DataRow dr;


                    sqlQuery = "SELECT * FROM cash_receive WHERE loan_id = " + searchLoanId + "AND month = '"+ searchMonth +"' AND year = "+ searchYear +";";

                    con.Open();
                    da = new SqlDataAdapter(sqlQuery, con);
                    da.Fill(dt);
                    dr = dt.Rows[0];
                    con.Close();

                    if (dt.Rows.Count == 1)
                    {
                        loanAmountTextBox.Text = null;
                        interestRateTextBox.Text = null;
                        cashReceiveTextBox.Text = null;
                        cashDueTextBox.Text = null;

                        loanIdTextBox.Text = dr[0].ToString();
                        monthComboBox.Text = dr[1].ToString();
                        yearTextBox.Text = dr[2].ToString();
                        installmentTextBox.Text = dr[3].ToString();
                        amountTextBox.Text = dr[4].ToString();
                        paymentDateTextBox.Text = dr[5].ToString();
                    }
                }
                else if (searchLoanId != "" && searchYear == "")
                {
                    SqlConnection con = new SqlConnection("Data Source=PC-TAJNUR\\SQLEXPRESS;Initial Catalog=LMS;Integrated Security=True");
                    SqlDataAdapter da;
                    DataTable dt = new DataTable();
                    DataRow dr;


                    sqlQuery = "SELECT * FROM loan_information WHERE loan_id = " + searchLoanId + ";";

                    con.Open();
                    da = new SqlDataAdapter(sqlQuery, con);
                    da.Fill(dt);
                    dr = dt.Rows[0];
                    con.Close();

                    if (dt.Rows.Count == 1)
                    {
                        loanAmountTextBox.Text = dr[3].ToString();
                        interestRateTextBox.Text = dr[8].ToString();
                        cashReceiveTextBox.Text = dr[12].ToString();
                        double tempLoanAmount = Convert.ToDouble(dr[3]);
                        double tempCashReceive = Convert.ToDouble(dr[12]);
                        double cashDue = tempLoanAmount - tempCashReceive;
                        cashDueTextBox.Text = cashDue.ToString();

                        loanIdTextBox.Text = dr[0].ToString();
                        int installment = Convert.ToInt32(dr[13]);
                        installment++;
                        installmentTextBox.Text = installment.ToString();
                        monthComboBox.Text = null;
                        yearTextBox.Text = null;
                        amountTextBox.Text = null;
                        paymentDateTextBox.Text = System.DateTime.Today.ToString();
                    }
                }
                


            }
            catch (Exception error)
            {
                MessageBox.Show("Record not found.", "Wrong ID");
                searchLoanIdTextBox.Text = null;
                searchMonthComboBox.Text = null;
                searchYearTextBox.Text = null;
                loanAmountTextBox.Text = null;
                interestRateTextBox.Text = null;
                cashReceiveTextBox.Text = null;
                cashDueTextBox.Text = null;
                loanIdTextBox.Text = null;
                monthComboBox.Text = null;
                yearTextBox.Text = null;
                installmentTextBox.Text = null;
                amountTextBox.Text = null;
                paymentDateTextBox.Text = null;
            }
        }

        //Save Button Procedure
        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                string loanId = loanIdTextBox.Text.ToString();
                string month = monthComboBox.Text.ToString();
                string year = yearTextBox.Text.ToString();
                string installment = installmentTextBox.Text.ToString();
                string amount = amountTextBox.Text.ToString();
                string paymentDate = paymentDateTextBox.Text.ToString();

                string sqlQuery = "INSERT INTO cash_receive VALUES('" + loanId + "', '" + month + "', '" + year + "', " + installment + ", '" + amount + "', '" + paymentDate + "');";
                string query2 = "SELECT * FROM loan_information WHERE loan_id = '" + loanId + "' ;";
                
                SqlConnection con = new SqlConnection("Data Source=PC-TAJNUR\\SQLEXPRESS;Initial Catalog=LMS;Integrated Security=True");
                SqlDataAdapter tda;
                DataTable tdt = new DataTable();
                DataRow tdr;
                con.Open();

                SqlCommand sqlcmd = new SqlCommand(sqlQuery, con);
                sqlcmd.ExecuteScalar();

                tda = new SqlDataAdapter(query2, con);
                tda.Fill(tdt);
                tdr = tdt.Rows[0];
                double temp, tAmount;
                temp = Convert.ToDouble(tdr[12]);
                tAmount = Convert.ToDouble(amount);
                tAmount += temp;
                amount = tAmount.ToString();
                int tInstallment = Convert.ToInt32(tdr[13]);
                tInstallment++;
                installment = tInstallment.ToString();
                string query3 = "UPDATE loan_information SET total_paid = " + amount + ", installment2 = " + installment + " WHERE loan_id = " + loanId + ";";
                SqlCommand sqlcmd2 = new SqlCommand(query3, con);
                sqlcmd2.ExecuteScalar();
                con.Close();


                MessageBox.Show("Record saved successfully.", "Successful");
                searchLoanIdTextBox.Text = null;
                searchMonthComboBox.Text = null;
                searchYearTextBox.Text = null;
                loanAmountTextBox.Text = null;
                interestRateTextBox.Text = null;
                cashReceiveTextBox.Text = null;
                cashDueTextBox.Text = null;
                loanIdTextBox.Text = null;
                monthComboBox.Text = null;
                yearTextBox.Text = null;
                installmentTextBox.Text = null;
                amountTextBox.Text = null;
                paymentDateTextBox.Text = null;


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
                string month = monthComboBox.Text.ToString();
                string year = yearTextBox.Text.ToString();
                string amount = amountTextBox.Text.ToString();
                string installment = installmentTextBox.Text.ToString();

                string deleteStatement = "DELETE FROM cash_receive WHERE loan_id = " + loanId + " AND month = '" + month + "' AND year = " + year + " ;";
                string query2 = "SELECT * FROM loan_information WHERE loan_id = '" + loanId + "' ;";
                
                
                if (MessageBox.Show("Are you really want to delete this Information?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    SqlConnection con = new SqlConnection("Data Source=PC-TAJNUR\\SQLEXPRESS;Initial Catalog=LMS;Integrated Security=True");
                    SqlDataAdapter da;
                    DataTable dt = new DataTable();
                    DataRow dr;

                    con.Open();
                    SqlCommand sqlcmd1 = new SqlCommand(deleteStatement, con);
                    sqlcmd1.ExecuteScalar();
                    MessageBox.Show("Loan information successfully deleted.", "Deleted");

                    da = new SqlDataAdapter(query2, con);
                    da.Fill(dt);
                    dr = dt.Rows[0];
                    double temp, tAmount;
                    temp = Convert.ToDouble(dr[12]);
                    tAmount = Convert.ToDouble(amount);
                    temp -= tAmount;
                    amount = temp.ToString();
                    int tInstallment = Convert.ToInt32(dr[13]);
                    tInstallment--;
                    installment = tInstallment.ToString();
                    string query3 = "UPDATE loan_information SET total_paid = " + amount + ", installment2 = " + installment + " WHERE loan_id = " + loanId + ";";
                    SqlCommand sqlcmd2 = new SqlCommand(query3, con);
                    sqlcmd2.ExecuteScalar();
                    con.Close();

                    searchMonthComboBox.Text = null;
                    searchYearTextBox.Text = null;
                    loanAmountTextBox.Text = null;
                    interestRateTextBox.Text = null;
                    cashReceiveTextBox.Text = null;
                    cashDueTextBox.Text = null;
                    loanIdTextBox.Text = null;
                    monthComboBox.Text = null;
                    yearTextBox.Text = null;
                    installmentTextBox.Text = null;
                    amountTextBox.Text = null;
                    paymentDateTextBox.Text = null;
                }



            }
            catch (Exception error)
            {
                MessageBox.Show("Invalid information.", "Wrong");

            }
        }

        //Print Button Procedure
        private void printButton_Click(object sender, EventArgs e)
        {

        }


        //Previous page
        private void backButton_Click(object sender, EventArgs e)
        {
            String fullName = userFullNameTextBox.Text.ToString();
            this.Hide();
            LoanAgreement loanAgreement = new LoanAgreement(fullName);
            loanAgreement.Show();

        }

    }
}