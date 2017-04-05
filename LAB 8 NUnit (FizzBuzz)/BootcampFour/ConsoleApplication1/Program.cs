using FizzBuzz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            FizzBuzzPrint x = new FizzBuzzPrint();

            for (int i = 1; i <= 100; i++)
                Console.WriteLine(x.print(i));

            Console.ReadLine();
        }
    }
}
