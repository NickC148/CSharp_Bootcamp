using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    public class FizzBuzzPrint
    {
        private int number = 100;
        private string multFive = "Buzz";
        private string multThree = "Fizz";

        public string print(int i)
        {
            //for (int i = 1; i <= number; i++)
            //{
            if (i % 5 == 0 && i % 3 == 0)
                return (multThree + multFive);
            else if (i % 3 == 0)
                return multThree;
            else if (i % 5 == 0)
                return multFive;
            else
                return i.ToString();
            //}
        }
    }
}
