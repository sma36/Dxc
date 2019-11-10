using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Assessment
{
    class Program
    {
        static void Main(string[] args)
        {
            dbEntityEntities entity = new dbEntityEntities();
    up:     Console.WriteLine("\nSelect a department Id");
            Console.WriteLine("Id\tName\n");
            
            foreach (var item in entity.Departments)
            {
                Console.WriteLine($"{item.Id}.\t{item.Name}");
            }
            Console.WriteLine();
            getEmployees(int.Parse(Console.ReadLine()));
            Console.WriteLine("1. Continue\t2. Exit\n");
            switch (int.Parse(Console.ReadLine()))
            {
                case 1:goto up;
                case 2: goto end;
                default:
                    Console.WriteLine("Invalid input. Try again.");
                    goto up;
            }
            
        end: Console.WriteLine("Bye!!");

        }
        public static void getEmployees(int id)
        {
            dbEntityEntities entity = new dbEntityEntities();
            Console.WriteLine("\nId\tName\n");

            foreach (var item in entity.Employees)
            {
                if (item.DepartmentId == id)
                {
                    Console.WriteLine($"{item.Id}.\t{item.Name}");
                }
            }
            Console.WriteLine();
        }
    }
}
