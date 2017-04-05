using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_ARRAYS
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[5];

            Console.WriteLine("Please enter 5 numbers.");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Number " + (i + 1) + ":");
                a[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Now in reverse order: ");
            for (int j = 4; j >= 0; j--)
            {
                Console.WriteLine(a[j]);
            }

            //Console.ReadKey();
            

        }
    }
}
