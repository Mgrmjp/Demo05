using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            // create a few Person objects
            Person person1 = new Person
            {
                Firstname = "Kirsi",
                Lastname = "Mainia",
                SocialSecurityNumber = "131414-2424"
            };
            Person person2 = new Person
            {
                Firstname = "Juho",
                Lastname = "Hauki",
                SocialSecurityNumber = "243234-2425"
            };
            Person person3 = new Person
            {
                Firstname = "Terho",
                Lastname = "Tunari",
                SocialSecurityNumber = "225534-1000"
            };

            // create a Persons object
            Persons myFriends = new Persons();

            // add person objexts to persons collection
            myFriends.AddPerson(person1);
            myFriends.AddPerson(person2);
            myFriends.AddPerson(person3);

            // get one person from Persons collection

            Person person4 = myFriends.GetPerson(10);
            if (person4 != null)
            {
                Console.WriteLine(person4.ToString());
            } else

            {
                Console.WriteLine("This person doesn't exist.");
            }

            // print collection
            myFriends.PrintCollection();

            Console.WriteLine();

            // find person 
            string sotu = "225534-1000";
            Console.WriteLine("Find sotu : " + sotu);
            Person person5 = myFriends.FindPerson(sotu);
            if (person5 != null)
            {
                Console.WriteLine(person5.ToString());
            } else
            {
                Console.WriteLine("Can't find person with that social security number.");
            }

        }
    }
}
