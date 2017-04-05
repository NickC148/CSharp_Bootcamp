using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_Nkandla
{
    public class Politician : Person, Visitor
    {

        public Politician(string pName, int pAge, string pGender, string pType, string pParty) : base (pName, pAge, pGender, pType, pParty)
        {

        }

        public string visit(Homestead homeStead)
        {
            if (base.Type.Equals("Politician") && !base.PoliticalParty.Equals("ANC"))
               return base.Name + ": Pay back the money!!!";
            else
               return base.Name + ", welcome to Nkandla!";
        }

        public string ToString()
        {
            return "Politician" + base.ToString();
        }
    }
}
