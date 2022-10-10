using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4
{
    class Personn
    {
        public string name;
        public Personn(string name)
        {
            this.name = name;
        }

        public string Name
        {
            get { return name; }
            //set { name = value; }
            set
            {
                if (Name != String.Empty) { name = value; }
                else { throw new ArgumentException("Name cannot be empty", "Name"); }
            }
        }


        public string toString()
        {
            return name;
        }
    }
}
