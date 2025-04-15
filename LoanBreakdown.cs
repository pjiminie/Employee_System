using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Employee1
{
    public partial class LoanBreakdown: Form
    {
        MySqlConnection conn = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=employee;");
        private int employeeID;

        public LoanBreakdown(int eid)
        {
            InitializeComponent();
            employeeID = eid;
            LoadEmployeeDetails();
            LoadLoanBreakdown();
        }

        private void LoadEmployeeDetails()
        {
            try
            {
                conn.Open();
                string query = @"
                    SELECT E.Name, E.DeptCode, D.DeptDescription 
                    FROM employeeinfo E 
                    JOIN departmentinfo D ON E.DeptCode = D.DeptCode 
                    WHERE E.Eid = @eid";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@eid", employeeID);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            lblEmpID.Text = employeeID.ToString();
                            lblName.Text = reader["Name"].ToString();
                            lblDeptCode.Text = reader["DeptCode"].ToString();
                            lblDeptDesc.Text = reader["DeptDescription"].ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading employee details: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void LoadLoanBreakdown()
        {
            try
            {
                conn.Open();
                string query = "SELECT LoanAmount, Date FROM loan WHERE Eid = @eid";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@eid", employeeID);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    loanGrid.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading loan data: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }


        private void EmployeeInfo_Load(object sender, EventArgs e)
        {

        }

        private void loanGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = loanGrid.Rows[e.RowIndex];
                employeeID = Convert.ToInt32(row.Cells["EmployeeID"].Value);  // Make sure the column name is correct
            }
        }
    }
}
