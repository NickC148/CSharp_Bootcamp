using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_LeapYear
{
    public class LeapYears
    {

        public bool YearTest(int i)
        {

            if (i % 100 == 0 && i % 400 == 0)
                return true;
            else if (i % 100 == 0 && i % 400 != 0)
                return false;
            else if (i % 4 == 0 && i % 100 == 0)
                return false;
            else if (i % 4 == 0 && i % 100 != 0)
                return true;
            else
                return false;

        }

    }
}
