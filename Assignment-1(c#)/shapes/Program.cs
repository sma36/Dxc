using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice,l,b,h;
            CalcArea calcArea = new CalcArea();
    up:     Console.WriteLine("\nCalculate the area of: \n0.Exit \n1.Circle" +
                "\n2.Rectangle \n3.Cuboid");
            choice=int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 0: break;

                case 1: Console.WriteLine("Enter radius");
                    l = int.Parse(Console.ReadLine());
                    calcArea.area(l);
                    goto up;
                case 2:
                    Console.WriteLine("Enter length and breadth");
                    l = int.Parse(Console.ReadLine());
                    b = int.Parse(Console.ReadLine());
                    calcArea.area(l,b);
                    goto up;
                case 3:
                    Console.WriteLine("Enter length,breadth and height");
                    l = int.Parse(Console.ReadLine());
                    b = int.Parse(Console.ReadLine());
                    h = int.Parse(Console.ReadLine());
                    calcArea.area(l,b,h);
                    goto up;

                default:
                    Console.WriteLine("Invalid entry");
                    goto up;
                    
            }
            
        }
    }
}
