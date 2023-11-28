using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sewarage_bill
{
    internal class Program
    {
        static void Main(string[] args)
        {

            do
            {
                try
                {


                    string cusName;
                    double rate;
                    double amount;
                    double total;
                    double type;
                    Console.WriteLine("                                                Welcome To Sewarge Bill calculator     ");
                    Console.WriteLine("                                             .......................................");

                    Console.WriteLine("Enter the Customer Name:");
                    cusName = Console.ReadLine();

                    while (true)
                    {
                        Console.WriteLine("Enter Amount of Water consumed:\t\n");
                        amount = Convert.ToDouble(Console.ReadLine());
                        if (amount >= 0)
                        {
                            Console.WriteLine($"Your Monthly Consumption is:{amount} ");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Invalid input,Check and try Again!");
                        }
                    }
                    Console.WriteLine($"Your amount of water usage is:{amount}");



                    try
                    {
                        while (true)
                        {
                            Console.WriteLine("Choose your Type of Usage:");
                            Console.WriteLine("\t1:commercial");
                            Console.WriteLine("\t2:industrial");
                            Console.WriteLine("\t3:domestic");
                            Console.WriteLine("Enter your Type of Usage:");
                            type = Convert.ToDouble(Console.ReadLine());



                            if (type == 1)
                            {
                                rate = 10.00;
                                Console.WriteLine($"Your Bill is:\n{rate}*{amount} = {rate * amount}", rate, amount);
                                break;
                            }
                            else if (type == 2)
                            {
                                rate = 12.50;
                                Console.WriteLine($"Your Bill is:\n{rate}*{amount} ={rate * amount}", rate, amount);
                                break;
                            }
                            else if (type == 3)
                            {
                                rate = 15.00;
                                Console.WriteLine($"Your Bill is:\n{rate}*{amount} ={rate * amount}", rate, amount);
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Invalid Input! Please Try Again!");

                            }
                        }

                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("\tInvalid code!");
                    }

                    Console.ReadKey();
                }

                catch (FormatException)
                {

                  Console.WriteLine("Invalid Input!");
                }

                Console.WriteLine("Do you want to continue?(Y=yes,N=no):");
            }
            while (Console.ReadLine().ToUpper() == "Y");
                Console.WriteLine("Bye!");

                Console.ReadKey(true);
            
        }   
    }
}
