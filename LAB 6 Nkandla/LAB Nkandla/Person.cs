using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_Nkandla
{
    public class Person
    {

        private string name, gender, type, party;
        private int age;

        public Person(string pName, int pAge, string pGender, string pType, string pParty)
        {
            this.Name = pName;
            this.Age = pAge;
            this.Gender = pGender;
            this.Type = pType;
            this.party = pParty;
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public int Age
        {
            get { return this.age; }
            set { this.age = value; }
        }

        public string Gender
        {
            get { return this.gender; }
            set { this.gender = value; }

        }

        public string Type
        {
            get { return this.type; }
            set { this.type = value; }
        }

        public string PoliticalParty
        {
            get { return this.party; }
            set { this.party = value; }
        }

        public string ToString()
        {
            return " Person:" +
                " Name [" + this.name +
                "], Age [" + this.age +
                "], Gender [" + this.gender +
                "], Type [" + this.type +
                "], PoliticalParty [" + this.party +
                "]";
        }

    }
}
