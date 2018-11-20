using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquirrelsInheritance
{
    class Chipmunk: Animal
    {
        public Chipmunk(string _name, string _fact)
        {
            Name = _name;
            Fact = _fact;
        }

        override public string About()
        {
            return Name + " is a chipmunk that " + Fact;
        }
    }
}
