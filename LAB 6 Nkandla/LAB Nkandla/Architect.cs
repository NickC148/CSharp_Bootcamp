using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_Nkandla
{
    public class Architect : Person
    {

        public Architect(string pName, int pAge, string pGender, string pType, string pParty) : base(pName, pAge, pGender, pType, pParty)
        {
        }

        public string ToString()
        {
            return "Architect" + base.ToString();
        }
    }
}
