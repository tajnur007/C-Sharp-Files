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
    public partial class CustomerInformation : Form
    {
        public CustomerInformation(string fullName)
        {
            InitializeComponent();
            userFullNameTextBox.Text = fullName;

            load_customer_id();
        }

        public void load_customer_id()
        {
            string sqlQuery = "SELECT * FROM statistic WHERE type_name = 'Customer';";

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
            count += 1000001;
            customerIdTextBox.Text = count.ToString();
        }

        private void CustomerInformation_FormClosed(object sender, FormClosedEventArgs e)
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
            menuPanel.Visible = false;
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

                string sqlQuery = "SELECT * FROM customer_information WHERE id=" + searchId + ";";

                SqlConnection con = new SqlConnection("Data Source=PC-TAJNUR\\SQLEXPRESS;Initial Catalog=LMS;Integrated Security=True");
                SqlDataAdapter da;
                DataTable dt = new DataTable();
                DataRow dr;

                con.Open();
                da = new SqlDataAdapter(sqlQuery, con);
                da.Fill(dt);
                con.Close();

                dr = dt.Rows[0];
                string id = dr[0].ToString();
                string full_name = dr[1].ToString();
                string f_name = dr[2].ToString();
                string m_name = dr[3].ToString();
                string address = dr[4].ToString();
                string dob = dr[5].ToString();
                string nid = dr[6].ToString();
                string gender = dr[7].ToString();
                string ms = dr[8].ToString();
                string religion = dr[9].ToString();
                                
                if (dt.Rows.Count == 1)
                {
                    customerIdTextBox.Text = id;
                    customerFullNameTextBox.Text = full_name;
                    fatherNameTextBox.Text = f_name;
                    motherNameTextBox.Text = m_name;
                    addressTextBox.Text = address;
                    dateOfBirthTextBox.Text = dob;
                    nationalIdTextBox.Text = nid;
                    genderComboBox.Text = gender;
                    maritalStatusComboBox.Text = ms;
                    religionComboBox.Text = religion;
                }

            }
            catch (Exception error)
            {
                MessageBox.Show("Customer ID not found.", "Wrong ID");
                searchTextBox.Text = null;
                customerIdTextBox.Text = null;
                customerFullNameTextBox.Text = null;
                fatherNameTextBox.Text = null;
                motherNameTextBox.Text = null;
                addressTextBox.Text = null;
                dateOfBirthTextBox.Text = null;
                nationalIdTextBox.Text = null;
                genderComboBox.Text = null;
                maritalStatusComboBox.Text = null;
                religionComboBox.Text = null;

                load_customer_id();
            }
        }

        //Save Button Procedure
        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                string id, full_name, f_name, m_name, address, dob, nid, gender, ms, religion;

                id = customerIdTextBox.Text.ToString();
                full_name = customerFullNameTextBox.Text.ToString();
                f_name = fatherNameTextBox.Text.ToString();
                m_name = motherNameTextBox.Text.ToString();
                address = addressTextBox.Text.ToString();
                dob = dateOfBirthTextBox.Text.ToString();
                nid = nationalIdTextBox.Text.ToString();
                gender = genderComboBox.Text.ToString();
                ms = maritalStatusComboBox.Text.ToString();
                religion = religionComboBox.Text.ToString();
                
                string sqlQuery = "INSERT INTO customer_information VALUES('"+id+"', '"+full_name+"', '"+f_name+"', '"+m_name+"', '"+address+"', '"+dob+"', '"+nid+"', '"+gender+"', '"+ms+"', '"+religion+"');";
                
                SqlConnection con = new SqlConnection("Data Source=PC-TAJNUR\\SQLEXPRESS;Initial Catalog=LMS;Integrated Security=True");
                SqlCommand sqlcmd = new SqlCommand(sqlQuery, con);
                con.Open();
                sqlcmd.ExecuteScalar();
                con.Close();

                MessageBox.Show("New customer information save successfully.", "Successful");

                customerIdTextBox.Text = " ";
                customerFullNameTextBox.Text = " ";
                fatherNameTextBox.Text = " ";
                motherNameTextBox.Text = " ";
                addressTextBox.Text = " ";
                dateOfBirthTextBox.Text = " ";
                nationalIdTextBox.Text = " ";
                genderComboBox.Text = null;
                maritalStatusComboBox.Text = null;
                religionComboBox.Text = null;

                sqlQuery = "SELECT * FROM statistic WHERE type_name = 'Customer';";
                SqlDataAdapter da;
                DataTable dt = new DataTable();
                DataRow dr;

                con.Open();
                da = new SqlDataAdapter(sqlQuery, con);
                da.Fill(dt);
                dr = dt.Rows[0];
                int count = Convert.ToInt32(dr[1]);
                count++;
                sqlQuery = "update statistic set total_count = " + count.ToString() + " where type_name = 'Customer';";
                SqlCommand sqlCommand = new SqlCommand(sqlQuery, con);
                sqlCommand.ExecuteScalar();
                con.Close();

                load_customer_id();
            }
            catch (Exception error)
            {
                MessageBox.Show("Give correct input", "Wrong Information");
                
            }
        }

        //Update Button Procedure
        private void d_Click(object sender, EventArgs e)
        {
            try
            {
                string id, full_name, f_name, m_name, address, dob, nid, gender, ms, religion;

                id = customerIdTextBox.Text.ToString();
                full_name = customerFullNameTextBox.Text.ToString();
                f_name = fatherNameTextBox.Text.ToString();
                m_name = motherNameTextBox.Text.ToString();
                address = addressTextBox.Text.ToString();
                dob = dateOfBirthTextBox.Text.ToString();
                nid = nationalIdTextBox.Text.ToString();
                gender = genderComboBox.Text.ToString();
                ms = maritalStatusComboBox.Text.ToString();
                religion = religionComboBox.Text.ToString();

                //string sqlQuery = "SELECT * FROM customer_information WHERE id ='" + id + "';";
                string updateStatement = "UPDATE customer_information SET full_name = '" + full_name + "', f_name = '" + f_name + "', m_name = '" + m_name + "', address = '" + address +
                                "', dob = '" + dob + "', nid = '" + nid + "', gender = '" + gender + "', ms = '" + ms + "', religion = '" + religion + "' WHERE id = '" + id + "';";
                
                string sqlQuery = "SELECT * FROM customer_information WHERE id = '" + id + "';";
                
                SqlConnection con = new SqlConnection("Data Source=PC-TAJNUR\\SQLEXPRESS;Initial Catalog=LMS;Integrated Security=True");
                SqlDataAdapter da;
                DataTable dt = new DataTable();
                DataRow dr;

                da = new SqlDataAdapter(sqlQuery, con);
                da.Fill(dt);
                if(dt.Rows.Count == 1)
                {
                    SqlCommand sqlCommand = new SqlCommand(updateStatement, con);

                    con.Open();
                    sqlCommand.ExecuteScalar();
                    con.Close();

                    MessageBox.Show("Customer information successfully updated.", "Updated");
                }
                else
                {
                    MessageBox.Show("Customer not found.", "Invalid Customer");
                }

                customerIdTextBox.Text = " ";
                customerFullNameTextBox.Text = " ";
                fatherNameTextBox.Text = " ";
                motherNameTextBox.Text = " ";
                addressTextBox.Text = " ";
                dateOfBirthTextBox.Text = " ";
                nationalIdTextBox.Text = " ";
                genderComboBox.Text = null;
                maritalStatusComboBox.Text = null;
                religionComboBox.Text = null;

                load_customer_id();
            }
            catch (Exception error)
            {
                MessageBox.Show("Customer not found.", "Invalid Customer");
                
            }
        }

        //Delete Button Procedure
        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {                
                string id = customerIdTextBox.Text.ToString();

                string sqlQuery = "SELECT * FROM customer_information WHERE id ='" + id + "';";
                string deleteStatement = "DELETE FROM customer_information WHERE id = '" + id + "';";

                SqlConnection con = new SqlConnection("Data Source=PC-TAJNUR\\SQLEXPRESS;Initial Catalog=LMS;Integrated Security=True");
                SqlDataAdapter da;
                DataTable dt = new DataTable();
                DataRow dr;

                da = new SqlDataAdapter(sqlQuery, con);
                da.Fill(dt);
                if (dt.Rows.Count == 1)
                {
                    SqlCommand sqlCommand = new SqlCommand(deleteStatement, con);

                    if (MessageBox.Show("Are you really want to delete this customer Information?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        con.Open();
                        sqlCommand.ExecuteScalar();
                        con.Close();

                        MessageBox.Show("Customer information successfully deleted.", "Deleted");
                    }
                }
                else
                {
                    MessageBox.Show("Customer not found.", "Invalid Customer");
                }

                customerIdTextBox.Text = " ";
                customerFullNameTextBox.Text = " ";
                fatherNameTextBox.Text = " ";
                motherNameTextBox.Text = " ";
                addressTextBox.Text = " ";
                dateOfBirthTextBox.Text = " ";
                nationalIdTextBox.Text = " ";
                genderComboBox.Text = null;
                maritalStatusComboBox.Text = null;
                religionComboBox.Text = null;

                load_customer_id();

            }
            catch (Exception error)
            {
                MessageBox.Show("Customer not found.", "Invalid Customer");

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
            LoanInformation loanInformation = new LoanInformation(fullName);
            loanInformation.Show();
        }


    }
}
