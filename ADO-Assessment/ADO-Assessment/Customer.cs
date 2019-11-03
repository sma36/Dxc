using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace ADO_Assessment
{
    class Customer
    {       
        private string name;
        private int  id,quantity,productId,supplierId;

        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        string connString = "data source=IN5CG9292JSR; database=ADOdemo; integrated security=true;";

        public string Name { get => name; set => name = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public int ProductId { get => productId; set => productId = value; }
        public int SupplierId { get => supplierId; set => supplierId = value; }
        public int Id { get => id; set => id = value; }

        public int InsertCustomer(Customer customer)
        {
            con.ConnectionString = connString;
            cmd.Connection = con;
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "InsertCustomer";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("Id", customer.Id);
            cmd.Parameters.AddWithValue("Name", customer.Name);
            cmd.Parameters.AddWithValue("Quantity", customer.Quantity);
            cmd.Parameters.AddWithValue("ProductId", customer.ProductId);
            cmd.Parameters.AddWithValue("SupplierId", customer.SupplierId);
            con.Open();
            int rowCount=cmd.ExecuteNonQuery();
            con.Close();
            return rowCount;
        }

        public void DisplayProducts()
        {
            con.ConnectionString = connString;
            cmd.Connection = con;    
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "DisplayProducts";
            cmd.Parameters.Clear();
            Console.WriteLine("Id\tProducts\n");
            con.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                Console.WriteLine($"{rdr[0]}\t{rdr[1]}");
            }
            con.Close();
        }

        public void DisplaySuppliers(int ProductId)
        {
            con.ConnectionString = connString;
            cmd.Connection = con;
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "DisplaySuppliers";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("ProductId", ProductId);
            Console.WriteLine("Id\tName\tLocation\tPrice\n");
            con.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                Console.WriteLine($"{rdr[0]}\t{rdr[1]}\t{rdr[2]}\t\t{rdr[3]}");
            }
            con.Close();
        }

        public void DisplayCustomers()
        {
            con.ConnectionString = connString;
            cmd.Connection = con;
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "DisplayCustomers";            
            Console.WriteLine("Id\tName\n");
            con.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                Console.WriteLine($"{rdr[0]}\t{rdr[1]}");
            }
            con.Close();
        }

        public void UpdateCustomerCount()
        {
            con.ConnectionString = connString;
            cmd.Connection = con;
            cmd.CommandText = "update CustomerCount set CusCount=CusCount+1 where Id=1";
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public int RetrieveCustomerCount()
        {
            int count=0;
            con.ConnectionString = connString;
            cmd.Connection = con;
            cmd.CommandText = "select * from CustomerCount";
            con.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {                
                count = int.Parse(Convert.ToString(rdr[1]));
            }
            con.Close();
            return count;
        }

        public void CustomerDetails(int Id)
        {
            con.ConnectionString = connString;
            cmd.Connection = con;
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "CustomerDetails";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("Id", Id);            
            Console.WriteLine("\nProduct\t\tQty\tSupplier\tPrice(per item)\n");
            con.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                Console.WriteLine($"{rdr[0]}\t" +
                    $"\t{rdr[1]}\t{rdr[2]}\t\t{rdr[3]}");
            }
            con.Close();
        }        

    }
}
