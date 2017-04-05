using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_3_PROGRAM_FLOW
{
    class Program
    {
        static void Main(string[] args)
        {

            int price, paid, change, x;
            string denom = "";

            Console.WriteLine("Price: ");
            price = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Paid: ");
            paid = Convert.ToInt32(Console.ReadLine());

            change = paid - price;
            x = change;

            while (x > 0)
            {
                if (x - 100 >= 0)
                {
                    denom += "100, ";
                    x -= 100;
                }
                else if (x - 50 >= 0)
                {
                    denom += "50, ";
                    x -= 50;
                }
                else if (x - 20 >= 0)
                {
                    denom += "20, ";
                    x -= 20;
                }
                else if (x - 5 >= 0)
                {
                    denom += "5, ";
                    x -= 5;
                }
                else if (x - 2 >= 0)
                {
                    denom += "2, ";
                    x -= 2;
                }
                else if (x - 1 >= 0)
                {
                    denom += "1, ";
                    x -= 1;
                }

            }

            Console.WriteLine("Your change is " + change + ": " + denom);

        }
    }
}
