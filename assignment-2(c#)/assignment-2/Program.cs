using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_2
{         
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nWelcome to Bank\n");

            AccountDetails[] account = new AccountDetails[10];
            account[0] = new AccountDetails();
            account[1] = new AccountDetails();
            account[2] = new AccountDetails();
            account[3] = new AccountDetails();

            account[0].Details("Messi", 111, 8734567);
            account[1].Details("Ronaldo", 222, 77876987);
            account[2].Details("Mcgregor", 333, 876544);
            account[3].Details("lungi", 444, 700);

            int id, index=-1, option, newAccountIndex=4, choice, choice2;
            string newName;
            double newBalance;

            

    up:     Console.WriteLine("\nChoose Option:\n" +
                "1. Existing Customer\n2. New Customer\n0. Exit\n");
            option=int.Parse(Console.ReadLine());

            switch (option)
            {
                case 0: goto end;

                case 1:
         up2:       Console.Write("Enter your Account Id :\t");
                    id = int.Parse(Console.ReadLine());

                    for (int i = 0; i < account.Length; i++)
                    {
                        if (account[i].checkId(id))
                        {
                            index = i;
                            break;
                        }
                    }

                    if (index == -1)
                    {
                        Console.WriteLine("\nInvalid account id! Try again!\n");
                        goto up2;
                    }
                    else
                    {
                        double deposit, withdrawal;
                        Console.WriteLine("\nAccount Information");
                        Console.WriteLine("\n\tName:" + account[index].getName());
                        Console.WriteLine("\tId:" + account[index].getId());
                        Console.WriteLine("\tBalance:" + account[index].getBalance());
        up3:            Console.WriteLine("\nChoose an option");
                        Console.WriteLine("1. Deposit\n2. Withdrawal\n0. Exit\n");
                        choice = int.Parse(Console.ReadLine());
                        switch (choice)
                        {
                            case 0:goto end;

                            case 1: Console.WriteLine("\nEnter deposit amount");
                                deposit = double.Parse(Console.ReadLine());
                                account[index].depositAmount(deposit);
                                Console.WriteLine("\nDeposit successful!!! \nBalance:" + account[index].getBalance());
                                break;

                            case 2:
                                Console.WriteLine("\nEnter withdrawal amount");
                                withdrawal = double.Parse(Console.ReadLine());
                                if( (account[index].getBalance()-withdrawal) >= 500)
                                { 
                                    account[index].withdrawalAmount(withdrawal);
                                    Console.WriteLine("\nWithdrawal successful!!! \nBalance:" + account[index].getBalance());

                                }
                                else
                                {
                                    Console.WriteLine("\nMinimum balance cannot be below Rs.500");
                                    goto up3;
                                }
                                break;

                            default:
                                Console.WriteLine("\nInvalid option. Try again.");
                                goto up3;
                                
                        }
                    }
                    break;

                case 2:
                    while (true)
                    {
                        Console.WriteLine("\nEnter Name and deposit amount greater than Rs.500");
                        newName = Console.ReadLine();
                        newBalance = double.Parse(Console.ReadLine());
                        if(newBalance >= 500)
                        {
                            account[newAccountIndex] = new AccountDetails();
                            account[newAccountIndex].Details(newName,(newAccountIndex+1)*111, newBalance);
                            Console.WriteLine("Your new account id is: " + (newAccountIndex+1) * 111);
                            newAccountIndex++;
                            break;
                        }
                        else
                        {
                            Console.WriteLine("\nOpening deposit must be greater than 500.Try again.");
                        }
                    }
                    goto up;

                default:
                    Console.WriteLine("Invalid option.Try again.");
                    goto up;
                    
            }

            Console.WriteLine("\nWould you like to do another transaction?\n" +
                "1. Yes \n2. No\n");
            choice2 = int.Parse(Console.ReadLine());
            if (choice2 == 1)
            {
                goto up;
            }

    end:     Console.WriteLine("\nEnter any key to exit...");
            Console.ReadKey();
        }
    }
}
