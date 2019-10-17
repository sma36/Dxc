using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace billing
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] items = {"Apple","Ball","Cat","Dog","Egg",
            "Fish","Gun","Horse"};

            int[] priceList= { 10, 20,7000, 10000, 5, 500, 15000, 65000 };
            string item;
            int total=0;
            int[] quantity = new int[items.Length];

        up: Console.WriteLine("\nList of Products Availabe\n");

            for (int i = 0; i < items.Length; i++)
            {
                Console.WriteLine("-"+items[i]+"\tRs. "+priceList[i]);

            }

            Console.WriteLine("\nEnter required item or" +
                "\nEnter 0 to generate bill");

            item = Console.ReadLine();
            if (item=="0")
            {
                
                Console.WriteLine("\n\nItem\tQuantity\tTotal(Rs.)");
                for (int i = 0; i < items.Length; i++)
                {
                    if (quantity[i]!=0)
                    {
                        Console.WriteLine(items[i]+"\t"+quantity[i]+"\t\t"+priceList[i]*quantity[i]);
                    }
                    

                }
                Console.WriteLine("\n\tTotal\t\t"+total+"\n\n");

                goto end;
            }

            for (int i = 0; i < items.Length; i++)
            {
                string str = items[i];
                if(item.ToLower() == items[i].ToLower())
                {
                    Console.WriteLine("Enter the no. of {0}s required",items[i]);
                    quantity[i] = int.Parse(Console.ReadLine());
                    total += priceList[i] * quantity[i];
                    goto up;
                }
            }

                Console.WriteLine("\nInvalid entry,please enter a valid item\n");
                goto up;

        end: Console.ReadKey();
        }
    }
}
