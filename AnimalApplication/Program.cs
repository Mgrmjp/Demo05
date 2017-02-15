using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal();

            List<Animal> animals = new List<Animal>
                    {
                        new Cat(){ Name = "Kissi", Age=10, Color = "Dark Gray" },
                        new Dog(){ Name = "Haukku", Age=8, Color = "Yellow" },
                        new Bunny(){ Name = "Jyrsija", Age=12, Color = "Brown" }
                    };

            foreach (Animal ani in animals)
            {
                Console.WriteLine(ani.ToString());
            }
        }
    }
}
