using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_SWITCHES
{
    class Program
    {
        static void Main(string[] args)
        {

            int number, sum = 0;

            Console.WriteLine("Enter a number:");
            number = Convert.ToInt32(Console.ReadLine());

            while (number > 0)
            {
                switch (number % 2)
                {
                    case 0:
                        Console.WriteLine("Adding " + number);
                        sum += number;
                        break;
                    default:
                        Console.WriteLine("Not Adding " + number);
                        break;
                }

                number -= 1;
            }

            Console.WriteLine("Sum is: " + sum);

        }
    }
}
