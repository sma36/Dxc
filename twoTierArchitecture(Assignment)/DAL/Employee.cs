using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAL
{
    public class Employee
    {
        
        private string name,location,gender;
        private int salary, id;


        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        string connString = "data source=IN5CG9292JSR; database=ADOdemo; integrated security=true;";

        public string Name { get => name; set => name = value; }
        public string Location { get => location; set => location = value; }
        public string Gender { get => gender; set => gender = value; }
        public int Salary { get => salary; set => salary = value; }
        public int Id { get => id; set => id = value; }

        public int insertEmployeeDetails(Employee employee)
        {
            con.ConnectionString = connString;
            cmd.Connection = con;
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "insertEmployee";
            cmd.Parameters.AddWithValue("name", employee.Name);
            cmd.Parameters.AddWithValue("gender", employee.Gender);
            cmd.Parameters.AddWithValue("location", employee.Location);
            cmd.Parameters.AddWithValue("salary", employee.Salary);
            con.Open();
            int rowCount = cmd.ExecuteNonQuery();
            con.Close();
            return rowCount;
        }
        public int updateEmployeeDetails(Employee employee)
        {
            con.ConnectionString = connString;
            cmd.Connection = con;
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "updateEmployee";
            cmd.Parameters.AddWithValue("id", employee.Id);
            cmd.Parameters.AddWithValue("name", employee.Name);
            cmd.Parameters.AddWithValue("gender", employee.Gender);
            cmd.Parameters.AddWithValue("location", employee.Location);
            cmd.Parameters.AddWithValue("salary", employee.Salary);
            con.Open();
            int rowCount = cmd.ExecuteNonQuery();
            con.Close();
            return rowCount;
        }

        public int deleteEmployeeDetails(Employee employee)
        {
            con.ConnectionString = connString;
            cmd.Connection = con;
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "deleteEmployee";
            cmd.Parameters.AddWithValue("id", employee.Id); 
            
            con.Open();
            int rowCount = cmd.ExecuteNonQuery();
            con.Close();
            return rowCount;
        }

        public void searchEmployeeDetails(Employee employee)
        {
            con.ConnectionString = connString;
            cmd.Connection = con;
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "searchEmployee";
            cmd.Parameters.AddWithValue("id", employee.Id);
                     
            
            con.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                Console.WriteLine($"{rdr[0]}\t{rdr[1]}\t{rdr[2]}\t{rdr[3]}\t{rdr[4]}");
            }
            
            con.Close();
            
        }
        public void allEmployeeDetails()
        {
            con.ConnectionString = connString;
            cmd.Connection = con;            
            cmd.CommandText = "select * from employee";
            con.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                Console.WriteLine($"{rdr[0]}\t{rdr[1]}\t{rdr[2]}\t{rdr[3]}\t{rdr[4]}");
            }

            con.Close();

        }
    }
}
