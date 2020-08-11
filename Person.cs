using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class Person
    {
        public string Lastname { get; set; }
        public string Firstname { get; set; }

        public int Age { get; set; }

        public string Sayhello()
        {
            return $"{this.Lastname} say hello";
        }

        public string Say(string somethingToSay)
        {
            return $"{this.Lastname}: {somethingToSay}";
        }
        public int AskForAge()
        {
            try
            {
                Console.WriteLine($"How old is {this.Lastname}?");
                this.Age = int.Parse(Console.ReadLine());
                return this.Age;
            }
            catch (Exception)
            {
                //throw;
                Console.WriteLine("It's not a number!");
                return this.AskForAge();
            }

        }
        public static Person CreatePerson()
        {
            var person = new Person();
            person.AskForFirstname();
            person.AskForLastname();
            person.AskForAge();
            return person;
        }
        public string AskForLastname()
        {
            Console.WriteLine("What's the Lastname of this person?");
            return this.Lastname = Console.ReadLine();
        }
        public string AskForFirstname()
        {
            Console.WriteLine("What's the Firstname of this person?");
            return this.Firstname = Console.ReadLine();
        }
    }
}
