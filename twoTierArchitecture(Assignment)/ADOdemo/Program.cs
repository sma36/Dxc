using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace ADOdemo
{
    class Program
    {
        Employee employee;
        static void Main(string[] args)
        {
            Program p = new Program();

    up:     Console.WriteLine("\n\n1.All Employees\t2.Insert Employee" +
                "\t3.Update Employee\t4.Delete Employee\t5.Search Employee\t6.Exit\n");

            switch (int.Parse(Console.ReadLine()))
            {
                case 1:p.allEmployeeDetails();
                    break;
                case 2: p.insertEmployeeDetails();
                    break;
                case 3:
                    p.updateEmployeeDetails();
                    break;
                case 4:
                    p.deleteEmployeeDetails();
                    break;
                case 5:
                    p.printEmployeeDetails();
                    break;

                case 6: goto end;                  

                default:
                    Console.WriteLine("Invalid choice. Try again");
                    goto up;                    
            }
            goto up;

        end: Console.WriteLine("Press any key to exit...");
            Console.ReadKey();

        }
        public void insertEmployeeDetails()
        {
            employee = new Employee();
            Console.WriteLine("\nEnter name, gender location and salary");
            employee.Name = Console.ReadLine();
            employee.Gender = Console.ReadLine();
            employee.Location = Console.ReadLine();
            employee.Salary =int.Parse(Console.ReadLine());
            int count=employee.insertEmployeeDetails(employee);
            if (count > 0)
            {
                Console.WriteLine("\nInsertion successfull");
            }
        }

        public void printEmployeeDetails()
        {
            employee = new Employee();
            Console.WriteLine("\nEnter employee id");
            employee.Id = int.Parse(Console.ReadLine());
            employee.searchEmployeeDetails(employee);           
        }

        public void allEmployeeDetails()
        {
            employee = new Employee();
            employee.allEmployeeDetails();
        }

        public void updateEmployeeDetails()
        {
            employee = new Employee();
            Console.WriteLine("\nEnter employee id, name, gender location and salary");
            employee.Id = int.Parse(Console.ReadLine());
            employee.Name = Console.ReadLine();
            employee.Gender = Console.ReadLine();
            employee.Location = Console.ReadLine();
            employee.Salary = int.Parse(Console.ReadLine());
            int count= employee.updateEmployeeDetails(employee);
            if (count > 0)
            {
                Console.WriteLine("\nUpdate successfull");
            }
        }

        public void deleteEmployeeDetails()
        {
            employee = new Employee();
            Console.WriteLine("\nEnter employee id");
            employee.Id = int.Parse(Console.ReadLine());
            int count = employee.deleteEmployeeDetails(employee);
            if (count > 0)
            {
                Console.WriteLine("\nSuccessfully deleted");
            }
        }
    }
}
