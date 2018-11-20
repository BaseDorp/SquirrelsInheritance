using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquirrelsInheritance
{
    class Squirrel: Animal
    {
        public Squirrel(string _name, string _fact)
        {
            Name = _name;
            Fact = _fact;
        }

        override public string About()
        {
            return Name + " is a squirrel that " + Fact;
        }
    }
}
