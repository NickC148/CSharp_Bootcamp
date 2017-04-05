using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_Nkandla
{
    public class Nkandla : Homestead
    {
        private ChickenRun chickenRun;
        private SwimmingPool swimmingPool;
        private Amphitheatre ampT;

        public Nkandla(string hName, string hDistrict, string hProvince, string hCountry) : base (hName, hDistrict, hProvince, hCountry)
        {

        }

        public ChickenRun ChickenRun
        {
            get { return this.chickenRun; }
            set { this.chickenRun = value; }
        }

        public SwimmingPool SwimmingPool
        {
            get { return this.swimmingPool; }
            set { this.swimmingPool = value; }
        }

        public Amphitheatre AmpT
        {
            get { return this.ampT; }
            set { this.ampT = value; }
        }

    }
}
