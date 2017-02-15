using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalApplication
{
    class Dog : Animal
    {
        public override string ToString()
        {
            return base.ToString() + "X gon give it to you ruff.";
        }
        
    }
}
