using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_Nkandla
{
    public class Homestead
    {
        private string name, district, province, country;

        public Homestead(string hName, string hDistrict, string hProvince, string hCountry)
        {
            this.name = hName;
            this.district = hDistrict;
            this.province = hProvince;
            this.country = hCountry;
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public string District
        {
            get { return this.district; }
            set { this.district = value; }
        }

        public string Province
        {
            get { return this.province; }
            set { this.province = value; }
        }

        public string Country
        {
            get { return this.country; }
            set { this.country = value; }
        }

        public string accept(Visitor visitor)
        {
            if (visitor != null)
                return visitor.visit(this);
            else
                return "False";
        }

        public string ToString()
        {
            return "HomeStead:" +
                " Name [" + this.name +
                "] District [" + this.district +
                "] Province [" + this.province +
                "] Country [" + this.country +
                "]";
        }

    }
}
