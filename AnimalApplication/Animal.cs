using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalApplication
{
    class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Color { get; set; }

        public override string ToString()
        {
            return "My name < " + Name + "\nMy age < " + Age + "\nMah color < " + Color + "\n  -- ";
        }
    }
}
