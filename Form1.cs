using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Employee1
{
    public partial class Form1: Form
    {
        MySqlConnection connectionString = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=employee;");
        private int empID = 0;
        public Form1()
        {
            InitializeComponent();
            displayEmployee();

            DataGridView1.CellClick += DataGridView1_CellClick;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            AddNewLoan newLoan = new AddNewLoan();
            newLoan.Show();
        }

        private void btnAddEMP_Click(object sender, EventArgs e)
        {
            if (empName.Text == ""
                || empPosition.Text == ""
                || empSalary.Text == ""
                || empAge.Text == ""
                || empAddress.Text == ""
                || deptCode.Text == "")
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    connectionString.Open();
                    string insertMemberQuery = "INSERT INTO employeeinfo (Name, Position, Salary, Age, Address, DeptCode) VALUES (@EmployeeName, @Position, @Salary, @Age, @Address, @DepartmentCode)";

                    using (MySqlCommand cmd = new MySqlCommand(insertMemberQuery, connectionString))
                    {
                        cmd.Parameters.AddWithValue("@EmployeeName", empName.Text.Trim());
                        cmd.Parameters.AddWithValue("@Position", empPosition.Text.Trim());
                        cmd.Parameters.AddWithValue("@Salary", empSalary.Text.Trim());
                        cmd.Parameters.AddWithValue("@Age", empAge.Text.Trim());
                        cmd.Parameters.AddWithValue("@Address", empAddress.Text.Trim());
                        cmd.Parameters.AddWithValue("@DepartmentCode", deptCode.Text.Trim());


                        cmd.ExecuteNonQuery();
                        displayEmployee();
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
            empName.Text = "";
            empPosition.SelectedIndex = -1;
            empSalary.Text = "";
            empAge.Text = "";
            empAddress.Text = "";
            deptCode.SelectedIndex = -1;
            empID = 0;

            btnUDEMP.Enabled = false;
            btnDLEMP.Enabled = false;

        }

        public void displayEmployee()
        {
            EmployeeAdd add = new EmployeeAdd();
            List<EmployeeAdd> listData = add.addEmployee();
            DataGridView1.DataSource = listData;
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = DataGridView1.Rows[e.RowIndex];

                //show member id in the datagridview
                empID = Convert.ToInt32(row.Cells[0].Value);

                empName.Text = row.Cells[1].Value.ToString();
                empPosition.Text = row.Cells[2].Value.ToString();
                empSalary.Text = row.Cells[3].Value.ToString();
                empAge.Text = row.Cells[4].Value.ToString();
                empAddress.Text = row.Cells[5].Value.ToString();
                deptCode.Text = row.Cells[6].Value.ToString();

                btnUDEMP.Enabled = true;
                btnDLEMP.Enabled = true;

            }
        }

        private void btnCLEMP_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void btnUDEMP_Click(object sender, EventArgs e)
        {
            if (empID == 0)
            {
                MessageBox.Show("Please select a employee first.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult check = MessageBox.Show("Are you sure you want to UPDATE Employee ID: " + empID + "?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (check == DialogResult.Yes)
            {
                try
                {
                    connectionString.Open();
                    string updateQuery = "UPDATE employeeinfo SET " +
                                        "Name = @EmployeeName, " +
                                        "Position = @Position, " +
                                        "Salary = @Salary, " +
                                        "Age = @Age, " +
                                        "Address = @Address, " +
                                        "DeptCode = @ProfNum " +
                                        "WHERE Eid = @ID";

                    using (MySqlCommand cmd = new MySqlCommand(updateQuery, connectionString))
                    {
                        cmd.Parameters.AddWithValue("@EmployeeName", empName.Text.Trim());
                        cmd.Parameters.AddWithValue("@Position", empPosition.Text.Trim());
                        cmd.Parameters.AddWithValue("@Salary", empSalary.Text.Trim());
                        cmd.Parameters.AddWithValue("@Age", empAge.Text.Trim());
                        cmd.Parameters.AddWithValue("@Address", empAddress.Text.Trim());
                        cmd.Parameters.AddWithValue("@DepartmentCode", deptCode.Text.Trim());
                        cmd.Parameters.AddWithValue("@ID", empID);

                        cmd.ExecuteNonQuery();
                        displayEmployee();
                        MessageBox.Show("Updated Successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btnDLEMP_Click(object sender, EventArgs e)
        {
            if (empID == 0)
            {
                MessageBox.Show("Please select a employee first.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult check = MessageBox.Show("Are you sure you want to DELETE Employee ID: " + empID+ "?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (check == DialogResult.Yes)
            {
                try
                {
                    connectionString.Open();
                    string deleteQuery = "DELETE FROM employeeinfo WHERE Eid = @ID";

                    using (MySqlCommand cmd = new MySqlCommand(deleteQuery, connectionString))
                    {
                        cmd.Parameters.AddWithValue("@ID", empID);
                        cmd.ExecuteNonQuery();

                        displayEmployee();
                        MessageBox.Show("Deleted Successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if (empID != 0)
            {
                LoanBreakdown form = new LoanBreakdown(empID);
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select an employee first.");
            }
        }

        private void Search_TextChanged(object sender, EventArgs e)
        {
            string searchTerm = Search.Text.Trim().ToLower();

            EmployeeAdd add = new EmployeeAdd();
            List<EmployeeAdd> listData = add.addEmployee();

            var filteredList = listData.Where(emp =>
                emp.EmployeeID.ToString().Contains(searchTerm) ||
                emp.EmployeeName.ToLower().Contains(searchTerm) ||
                emp.DepartmentCode.ToLower().Contains(searchTerm)).ToList();

            DataGridView1.DataSource = filteredList;
        }
    }
}
