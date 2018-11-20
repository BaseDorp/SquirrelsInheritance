using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquirrelsInheritance
{
    class Animal
    {
        protected string Name;
        protected string Fact;

        public Animal()
        {

        }

        public Animal(string _name, string _fact)
        {
            Name = _name;
            Fact = _fact;
        }

        virtual public string About()
        {
            return Name + " is an animal that " + Fact;
        }
    }
}
