using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalApplication
{
    class Bunny : Animal
    {
        public override string ToString()
        {
            return base.ToString() + "Carrots are tasty.";
        }
    }
}
