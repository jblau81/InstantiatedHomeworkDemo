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
            string firstName = "";
            string lastName = "";
            int age = 0;
            string streetAddress = "";
            string city = "";
            string state = "";
            int zipCode = 0;
            string choice = "";

            bool wantToExit = false;
            do
            {
                Console.Write("What is your first name (or type exit to stop):");
                firstName = Console.ReadLine();

                Console.Write("What is your last name: ");
                lastName = Console.ReadLine();

                Console.Write("What is your age:");

                age = int.Parse(Console.ReadLine()); 

                string age = Console.ReadLine();

                Console.Write("What is your street address:");
                streetAddress = Console.ReadLine();

                Console.Write("What is your city:");
                city = Console.ReadLine();

                Console.Write("What is your state:");
                state = Console.ReadLine();

                Console.Write("What is your zip code:");
                zipCode = int.Parse(Console.ReadLine());

                Console.Write("Do you want to stop adding people:(yes/no) ");
                choice = Console.ReadLine();



                //Console.WriteLine($"First Name: {personOne.FirstName} Last Name: {personOne.LastName} Age: {personOne.Age} ");
                //Console.WriteLine($"Street: {addressOne.StreetAddress} " +
                //                    $"City:{addressOne.City} " +
                //                    $"State: {addressOne.State} " +
                //                    $"Zip Code: {addressOne.PostalCode}");

                //ProcessPerson.GreetPerson(personOne);



                PersonModel person1 = new PersonModel();
                person1.FirstName = firstName;
                person1.LastName = lastName;
                person1.Age = age;
                people.Add(person1);

                AddressModel address = new AddressModel();
                address.StreetAddress = streetAddress;
                address.City = city;
                address.State = state;
                address.PostalCode = zipCode;
                
                if (choice.ToLower() == "yes")
                {
<<<<<<< HEAD
                    wantToExit = true;
=======
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

                    
>>>>>>> 38e1947fed6351b482ecf7c6325e1a4eb98a8dde
                }

                // test comment
            

        } while (wantToExit != true);

            foreach (PersonModel p in people)
            {
                ProcessPerson.GreetPerson(p);
            }

    Console.ReadLine();
        }
    }
}
