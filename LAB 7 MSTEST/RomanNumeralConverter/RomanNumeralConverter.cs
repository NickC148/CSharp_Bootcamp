using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RomanNumeralConverter
{
    public class ArabicNumeralConverter
    {
        public string ConvertRomanNumeral(string rNumeral)
        {

            if (rNumeral.Contains("MMMM") | rNumeral.Contains("DDDD") | rNumeral.Contains("CCCC") | rNumeral.Contains("LLLL") | rNumeral.Contains("XXXX") | rNumeral.Contains("VVVV") | rNumeral.Contains("IIII"))
            {
                throw new ArgumentException("The Roman Numerals Supplied are Invalid");
            }
            else if (rNumeral == null | rNumeral == "")
            {
                throw new ArgumentException("Invalid Roman Numerals");
            }

            int number = 0;
            for (int i = 0; i < rNumeral.Length; i++)
            {
                if (i + 1 < rNumeral.Length && RomanMap[rNumeral[i]] < RomanMap[rNumeral[i + 1]])
                {
                    number -= RomanMap[rNumeral[i]];
                }
                else
                {
                    number += RomanMap[rNumeral[i]];
                }
            }
            return Convert.ToString(number);
        }

        private static Dictionary<char, int> RomanMap = new Dictionary<char, int>()
        {
            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'M', 1000}
        };
    }

    
}