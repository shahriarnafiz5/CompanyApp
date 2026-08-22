using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login_and_Register
{
    class Employee
    {
        private static string myConn = ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString;
        public string EmpId { get; set; }
        public string EmpName { get; set; }
        public string Age { get; set; }
        public string ContactNo { get; set; }
        public string Gender { get; set; }

        private const string SelectQuery = "Select * from Emp_details";
        private const string InsertQuery = "Insert Into Emp_details(EmpId, EmpName, EmpAge, EmpContact, EmpGender) Values (@EmpId, @EmpName, @EmpAge, @EmpContact, @EmpGender)";
        private const string UpdateQuery = "Update Emp_details set EmpName=@EmpName, EmpAge=@EmpAge, EmpContact=@EmpContact, EmpGender=@EmpGender where EmpId=@EmpId";
        private const string DeleteQuery = "Delete from Emp_details where EmpId=@EmpId";

        public DataTable GetEmployees()
        {
            var datatable = new DataTable();
            using (SqlConnection con = new SqlConnection(myConn))
            {
                con.Open();
                using(SqlCommand com = new SqlCommand(SelectQuery, con))
                {
                    using(SqlDataAdapter adapter = new SqlDataAdapter(com))
                    {
                        adapter.Fill(datatable);
                    }
                }
            }
            return datatable;
        }

        public bool InsertEmployee(Employee employee)
        {
            int rows;
            using (SqlConnection con = new SqlConnection(myConn))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(InsertQuery, con))
                {
                    com.Parameters.AddWithValue("@EmpId", employee.EmpId);
                    com.Parameters.AddWithValue("@EmpName", employee.EmpName);
                    com.Parameters.AddWithValue("@EmpAge", employee.Age);
                    com.Parameters.AddWithValue("@EmpContact", employee.ContactNo);
                    com.Parameters.AddWithValue("@EmpGender", employee.Gender);
                    rows = com.ExecuteNonQuery();
                }
            }
            return (rows > 0) ? true: false;
        }

        public bool UpdateEmployee(Employee employee)
        {
            int rows;
            using (SqlConnection con = new SqlConnection(myConn))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(UpdateQuery, con))
                {                  
                    com.Parameters.AddWithValue("@EmpName", employee.EmpName);
                    com.Parameters.AddWithValue("@EmpAge", employee.Age);
                    com.Parameters.AddWithValue("@EmpContact", employee.ContactNo);
                    com.Parameters.AddWithValue("@EmpGender", employee.Gender);
                    com.Parameters.AddWithValue("@EmpId", employee.EmpId);
                    rows = com.ExecuteNonQuery();
                }
            }
            return (rows > 0) ? true : false;
        }

        public bool DeleteEmployee(Employee employee)
        {
            int rows;
            using (SqlConnection con = new SqlConnection(myConn))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(DeleteQuery, con))
                {
                    com.Parameters.AddWithValue("@EmpId", employee.EmpId);
                    rows = com.ExecuteNonQuery();
                }
            }
            return (rows > 0) ? true : false;
        }
    }
}
