using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Data;
using System.Configuration;
using Microsoft.Data.SqlClient;


namespace BusinessLayer
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string salary { get; set; }
        public string MID { get; set; }
    }

    public class EmployeeBusinessLayer
    {
        public IEnumerable<Employee> Employee
        {
            get
            {
                //"server = DAMINI\\SQLEXPRESS; database = Employees; Trusted_connection = true; TrustServerCertificate = True;"

                string connectionString = "Server=DAMINI\\SQLEXPRESS; database=Employees; Integrated Security=SSPI";
             // string connectionString = ConfigurationManager.GetConnectionStrings["DBCS"].ConnectionString;

                List<Employee> employeeList = new List<Employee>();

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand("spGetAllEmployees", con);
                    command.CommandType = CommandType.StoredProcedure;
                    con.Open();
                    SqlDataReader rdr = command.ExecuteReader();

                    while (rdr.Read())
                    {
                        Employee employee = new Employee();
                        employee.Id = Convert.ToInt32(rdr["ID"]);
                        employee.Name = rdr["Name"].ToString();
                        employee.salary = rdr["Gender"].ToString();
                        employee.MID = rdr["City"].ToString();

                        employeeList.Add(employee); // Correct way to add to the list
                    }
                }
                return employeeList;
            }
        }

        public string? GetEmployees()
        {
            throw new NotImplementedException();
        }
    }
}
