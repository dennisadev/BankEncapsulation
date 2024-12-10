using System;

namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, ATM");
            Console.WriteLine("");
            Console.WriteLine("1 - Deposit $100");
            Console.WriteLine("2 - Deposit $200");
            Console.WriteLine("3 - Deposit $300");
            Console.WriteLine("");
            Console.WriteLine("Please Choose an Option 1-3");

            var customer = new BankAccount();

            var option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    customer.Deposit(100.01);
                    break;
                case "2":
                    customer.Deposit(200.00);
                    break;
                case "3":
                    customer.Deposit(300.00);
                    break;
                default:
                    Console.WriteLine("Invalid Entry. Please Start Over.");
                    break;
            }


            var currentBalance = customer.GetBalance();
            string currentBalanceLine = currentBalance.ToString();
            Console.WriteLine($"Your deposit was successful. Your current Balance is now: ${currentBalanceLine}");

        }
    }
}
