using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Employee1
{
    class LoanAdd
    {
        MySqlConnection connectionString = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=employee;");

        public int EmployeeID { get; set; }
        public int LoanAmount { get; set; }
        public string LoanDate { get; set; }

    }
}
