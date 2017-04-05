using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_Nkandla
{
    public class SwimmingPool
    {
        private int height;
        private int width;

        public SwimmingPool()
        {

        }

        public int Height
        {
            get { return this.height; }
            set { this.height = value; }
        }

        public int Width
        {
            get { return this.width; }
            set { this.width = value; }
        }
    }
}
