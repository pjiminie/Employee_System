using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Employee1
{
    class EmployeeAdd
    {
        MySqlConnection connectionString = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=employee;");

        public int EmployeeID { get; set; }
        public string EmployeeName { get; set; }
        public string Position { get; set; }
        public int Salary { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public string DepartmentCode { get; set; }

        public List<EmployeeAdd> addEmployee()
        {
            List<EmployeeAdd> listData = new List<EmployeeAdd>();

            try
            {
                if (connectionString.State == ConnectionState.Closed)
                {
                    connectionString.Open();
                }

                string selectData = "SELECT * FROM employeeinfo";

                using (MySqlCommand cmd = new MySqlCommand(selectData, connectionString))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader()) // Use MySqlDataReader
                    {
                        while (reader.Read())
                        {
                            EmployeeAdd add = new EmployeeAdd
                            {
                                EmployeeID = Convert.ToInt32(reader["Eid"]),
                                EmployeeName = reader["Name"].ToString(),
                                Position = reader["Position"].ToString(),
                                Salary = Convert.ToInt32(reader["Salary"]),
                                Age = Convert.ToInt32(reader["Age"]),
                                Address = reader["Address"].ToString(),
                                DepartmentCode = reader["DeptCode"].ToString()
                            };

                            listData.Add(add);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error Connecting Database: " + ex.Message);
            }
            finally
            {
                if (connectionString.State == ConnectionState.Open)
                {
                    connectionString.Close();
                }
            }

            return listData;
        }
    }
}
