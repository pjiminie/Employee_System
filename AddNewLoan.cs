using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Employee1
{
    public partial class AddNewLoan: Form
    {
        MySqlConnection connectionString = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=employee;");
        public AddNewLoan()
        {
            InitializeComponent();
            LoadEmployeeID();
        }

        public void LoadEmployeeID()
        {
            try
            {
                connectionString.Open();
                string query = "SELECT Eid FROM employeeinfo";
                using (MySqlCommand cmd = new MySqlCommand(query, connectionString))
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    eID.Items.Clear();
                    while (reader.Read())
                    {
                        eID.Items.Add(reader["Eid"].ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading Employee ID: " + ex.Message);
            }
            finally
            {
                connectionString.Close();
            }
        }

        private void btnAddStu_Click(object sender, EventArgs e)
        {
            if (eID.Text == ""
                || amount.Text == ""
                || date.Text == "")
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    connectionString.Open();
                    string insertMemberQuery = "INSERT INTO loan (Eid, LoanAmount, Date) VALUES (@EmployeeID, @LoanAmount, @LoanDate)";

                    using (MySqlCommand cmd = new MySqlCommand(insertMemberQuery, connectionString))
                    {
                        cmd.Parameters.AddWithValue("@EmployeeID", eID.Text.Trim());
                        cmd.Parameters.AddWithValue("@LoanAmount", amount.Text.Trim());
                        cmd.Parameters.AddWithValue("@LoanDate", date.Text.Trim());


                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Added Successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clearFields();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connectionString.Close();
                }
            }
        }

        public void clearFields()
        {
            eID.SelectedIndex = -1;
            amount.Text = "";
            date.Text = "";
        }
    }
}
