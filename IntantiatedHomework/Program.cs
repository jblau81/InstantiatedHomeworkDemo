using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace InstantiatedHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            List<PersonModel> people = new List<PersonModel>();
            string firstName= "";

            
            

            do
            {
                Console.Write("What is your first name (or type exit to stop):");
                firstName = Console.ReadLine();

                Console.Write("What is your last name: ");
                string lastName = Console.ReadLine();

                Console.Write("What is your age:");
                string age = Console.ReadLine();

                Console.Write("What is your street address:");
                string streetAddress = Console.ReadLine();

                Console.Write("What is your city:");
                string city = Console.ReadLine();

                Console.Write("What is your state:");
                string state = Console.ReadLine();

                Console.Write("What is your zip code:");
                string postalCode = Console.ReadLine();



               

                if (firstName.ToLower() != "exit")
                {
                    PersonModel person1 = new PersonModel();
                    person1.FirstName = firstName;
                    person1.LastName = lastName;
                    person1.Age = age;
                    people.Add(person1);

                    AddressModel address = new AddressModel();
                    address.StreetAddress = streetAddress;
                    address.City = city;
                    address.State = state;
                    address.PostalCode = postalCode;

                    // test comment
                }

            } while (firstName.ToLower() != "exit");

            foreach (PersonModel p in people)
            {
                ProcessPerson.GreetPerson(p);
            }

            Console.ReadLine();
        }
    }
}
