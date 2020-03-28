using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    class Program
    {

        static void Main(string[] args)

        {

            int pin;
            int amount = 10000, transfer;
            string accountNumber;
            int smartCardNumber;
            string phoneNumber;

            Transfer t = new Transfer();
            {
                t.pin =1111;
                t.smartCardNumber = 1234567890;

            }

            Console.WriteLine("Enter Your Pin");
            pin = Int32.Parse(Console.ReadLine());
            
            {
                if (pin == t.pin)
                {
                    Console.WriteLine("1.Transfer\n2.BillPayment\n3.Recharge");
                }
                else
                {
                    Console.WriteLine("ERROR!!!, Incorrect Pin");
                }
                int option;

                Console.WriteLine("Enter any Option");
                option = Int32.Parse(Console.ReadLine());
                if (option ==1)
                {
                    

                        Console.WriteLine("Enter Account Number");
                        accountNumber = (Console.ReadLine());
                        if (accountNumber.Length == 10)
                        {
                            Console.WriteLine("Enter Amount");
                            transfer = Int32.Parse(Console.ReadLine());
                            if (transfer % 1 != 0)
                            {
                                Console.WriteLine();
                            }
                            else if (transfer > (amount - 1))
                            {
                                Console.WriteLine("Insufficient Funds");
                            }
                            else
                            {
                                amount = amount - transfer;
                                Console.WriteLine("Transfer Successful\nYour Current Balance is ${0}", amount);
                            }

                        }
                        else
                        {
                            Console.WriteLine("InCorrect Account Number");
                        }
                    
                }
                if (option==2)
                {
                            
                                Console.WriteLine("Dstv Subscription");
                                Console.WriteLine("Input SmartCard Number");
                                smartCardNumber = Int32.Parse(Console.ReadLine());
                                if (smartCardNumber == t.smartCardNumber)
                                {
                                    Console.WriteLine("1.Full Package\n2.Mini Package\n3.Low Package");
                                }
                                else
                                {
                                    Console.WriteLine("ERROR!!!, Incorrect Smard Card Number");
                                }
                                option = Int32.Parse(Console.ReadLine());
                    if (option == 1)
                    {
                        {
                            Console.WriteLine("This package Costs 10,000naira, are you sure you want to continue?\n1.yes\n2.No");
                        }
                        option = Int32.Parse(Console.ReadLine());
                        if (option == 1)
                        {
                            Console.WriteLine("Subcription Successsful");
                        }
                    }
                    if (option == 2)
                    {

                        {
                            Console.WriteLine("This package Costs 7,000naira, are you sure you want to continue?\n1.yes\n2.No");
                        }
                        option = Int32.Parse(Console.ReadLine());
                        if (option == 1)
                        {
                            Console.WriteLine("Subcription Successsful");
                        }
                    }

                     if (option == 3)
                    {

                        {
                            Console.WriteLine("This package Costs 4,000naira, are you sure you want to continue?\n1.yes\n2.No");
                        }
                        option = Int32.Parse(Console.ReadLine());
                        if (option == 1)
                        {
                            Console.WriteLine("Subcription Successsful");
                        }
                    }
                }
                if (option ==3)
                { 
                        int recharge;
                    Console.WriteLine("1.Self Recharge\n.2 other");
                    option = Int32.Parse(Console.ReadLine());
                    if (option == 1)
                        {
                            Console.WriteLine("Enter Amount");
                            recharge = Int32.Parse(Console.ReadLine());
                            if (recharge % 1 != 0)
                            {
                                Console.WriteLine();
                            }
                            else if (recharge > (amount - 1))
                            {
                                Console.WriteLine("Insufficient Funds");
                            }
                            else
                            {
                                amount = amount - recharge;
                                Console.WriteLine("Recharge Successful\nYour Current Balance is ${0}", amount);
                            }
                    }
                        if (option == 2)
                        {
                            Console.WriteLine("Enter Phone Number");
                            phoneNumber = (Console.ReadLine());
                        if (phoneNumber.Length == 11)
                        {
                            Console.WriteLine("Enter Amount");
                            recharge = Int32.Parse(Console.ReadLine());
                            if (recharge % 1 != 0)
                            {
                                Console.WriteLine();
                            }
                            else if (recharge > (amount - 1))
                            {
                                Console.WriteLine("Insufficient Funds");
                            }
                            else
                            {
                                amount = amount - recharge;
                                Console.WriteLine("Recharge Successful\nYour Current Balance is ${0}", amount);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Incorrect Phone Number");
                        }
                       }
                        
                }
                Console.ReadKey();
            }
        }
    }
}