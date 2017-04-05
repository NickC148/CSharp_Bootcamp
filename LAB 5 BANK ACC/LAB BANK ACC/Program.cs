using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_BANK_ACC
{
    class Program
    {
        static void Main(string[] args)
        {
            bool active = true;
            BankAccount acc1 = new BankAccount();

            while (active)
            {
                string selection;
                double amount;

                Console.WriteLine("1) Transact");
                Console.WriteLine("2) QUIT");
                Console.WriteLine("Enter the Number: ");
                selection = Console.ReadLine();

                if (selection == "1")
                {
                    Console.WriteLine("1) Check Balance");
                    Console.WriteLine("2) Deposit Money");
                    Console.WriteLine("3) Withdraw Money");
                    Console.WriteLine("Enter the Number: ");
                    selection = Console.ReadLine();

                    if (selection == "1")
                    {
                        acc1.checkBalance();
                        Console.WriteLine("");
                        continue;
                    }
                    else if (selection == "2")
                    {
                        Console.WriteLine("Enter Amount");
                        amount = Convert.ToDouble(Console.ReadLine());
                        acc1.deposit(amount);
                        acc1.checkBalance();
                        Console.WriteLine("");
                        continue;

                    }
                    else if (selection == "3")
                    {
                        Console.WriteLine("Enter Amount");
                        amount = Convert.ToDouble(Console.ReadLine());
                        acc1.withdraw(amount);
                        acc1.checkBalance();
                        Console.WriteLine("");
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("Not a valid selection");
                        Console.WriteLine("");
                        continue;
                    }
                }
                else if (selection == "2")
                {
                    active = false;
                    Console.WriteLine("");
                    continue;
                }
                else
                {
                    Console.WriteLine("Not a valid selection");
                    Console.WriteLine("");
                    continue;
                }
            }
        }
    }

    public class BankAccount
    {
        int accNo;
        double balance;
        int accountDefault = 0;

        public BankAccount():this(0)
        { }
        public BankAccount(double aBalance)
        {
            this.accNo = ++accountDefault;
            this.balance = aBalance;
        }

        public void deposit(double amount)
        {
            if (amount > 0 )
            {
                this.balance += amount;
            }
            else
            {
                Console.WriteLine("Amount cannot be 0 or less");
            }
        }

        public void withdraw(double amount)
        {
            if (amount > 0 )
            {
                if (this.balance > amount)
                {
                    this.balance -= amount;
                }
                else
                {
                    Console.WriteLine("Not enough funds available.");
                }
                
            }
            else
            {
                Console.WriteLine("Amount cannot be 0 or less");
            }
        }

        public void checkBalance()
        {
            Console.WriteLine("Available funds: " + this.balance);
        }
    }
}

