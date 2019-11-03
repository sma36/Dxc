using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO_Assessment
{
    class Program
    {         
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome! Choose an option");
        l1: Console.WriteLine("\n1. Add Customer\t 2. Show Customers\t3. Exit\n");

            switch (int.Parse(Console.ReadLine()))
            {
                case 1:
                    insert();
                    break;
                case 2:
                    Customer customer = new Customer();
                    customer.DisplayCustomers();
                    Console.WriteLine("Select customer Id");
                    int cId = int.Parse(Console.ReadLine());
                    customer.CustomerDetails(cId);
                    break;
                case 3: goto end;
                default:
                    Console.WriteLine("Invalid choice. Try again!");
                    goto l1;
            }
            goto l1;

        end: Console.WriteLine("Bye!!");
        }


        public static void insert()
        {
            string str;
            int idd;
            
            Console.WriteLine("Welcome!\nEnter your name");
            str = Console.ReadLine();

            Customer cus = new Customer();
            cus.UpdateCustomerCount();
            idd = cus.RetrieveCustomerCount();

            Customer customer = new Customer();
    up:     customer.Name = str;
            customer.Id = idd;

         customer.DisplayProducts();
            Console.WriteLine("\nSelect a product Id");
            customer.ProductId = int.Parse(Console.ReadLine());

            customer.DisplaySuppliers(customer.ProductId);
            Console.WriteLine("\nSelect a Supplier Id");
            customer.SupplierId = int.Parse(Console.ReadLine());

            Console.WriteLine("\nEnter quantity");
            customer.Quantity = int.Parse(Console.ReadLine());

            int flag = customer.InsertCustomer(customer);
            if (flag > 0)
            {
                Console.WriteLine("Item Added");
            }
            Console.WriteLine("1.Continue Shopping 2.Exit");
            if (int.Parse(Console.ReadLine()) == 1)
            {
                goto up;
            }            
        }
    }
}
