using System;
using System.Collections.Generic;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            var guillaume = new Person { Lastname = "Guillaume", Firstname = "SEVAUX", Age = 10 };
            var dorian = new Person { Lastname = "Dorian", Firstname = "LEBOUCHER", Age = 20 };
            var mamie = new Person { Lastname = "Christine", Firstname = "SEVAUX", Age = 30 };
            var kemen = new Person { Lastname = "Kemen", Firstname = "DAGUERRE", Age = 40 };
            var laetitia = new Person { Lastname = "Laetitia", Firstname = "DAGUERRE", Age = 50 };
            
            var average = 0;
            var numberOfPerson = 0;
            List<Person> famille = new List<Person>() { dorian, guillaume, mamie, kemen, laetitia};
            
            foreach (Person person in famille)
            {
                Console.WriteLine($"{person.Lastname} {person.Firstname} is {person.Age} years old.");
            }
            
            foreach (Person person in famille)
            {
                average = average + person.Age;
                numberOfPerson = numberOfPerson + 1;
            }
            average = average / numberOfPerson;
            double standardDeviation = 0;
            
            foreach (Person person in famille)
            {
                standardDeviation= standardDeviation + Math.Pow(person.Age - average, 2);
            }
            standardDeviation= Math.Sqrt(standardDeviation / numberOfPerson);
            Console.WriteLine("Average age is " + average + ".");
            Console.WriteLine("Standard deviation is " + standardDeviation);
        }
    }
}
