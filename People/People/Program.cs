using System.Collections.Generic;
using System.IO;
using System;
using System.Linq;

namespace PeopleConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = ReadPeople(@"C:\Users\bianca.campanu\Downloads\people.txt");
            string personName = ReadPersonName();
            Person searchedPerson = SearchPersonByName(people, personName);
            if (searchedPerson == null)
            {
                Console.WriteLine("The person doesn't exist in the file");
                return;
            }
            PrintIfPersonHasEighteenYears(searchedPerson);
        }

        private static List<Person> ReadPeople(string path)
        {
            var lines = File.ReadAllLines(path);
            var people = new List<Person>();
            foreach (string line in lines)
            {
                var texts = line.Split(' ');
                string name = texts[0];
                int? age = texts.Length > 1 ? (int.Parse(texts[1]) as int?) : null;
                people.Add(new Person(name, age));
            }
            return people;
        }

        private static string ReadPersonName()
        {
            Console.WriteLine("Enter name of person: ");
            return Console.ReadLine();
        }

        private static Person SearchPersonByName(List<Person> people, string personName)
        {
            return people.FirstOrDefault(person => person.Name == personName);
        }

        private static void PrintIfPersonHasEighteenYears(Person searchedPerson)
        {
            string isPersonEighteenYearsOld = (searchedPerson.Age ?? 0) > 18 ? "yes" : "no";
            Console.WriteLine("(" + isPersonEighteenYearsOld + " , " + searchedPerson.Name + " " + searchedPerson.Age + ")");
            Console.ReadLine();
        }
    }

    public class Person
    {
        public string Name { get; }
        public int? Age { get; }

        public Person(string name, int? age)
        {
            Name = name;
            Age = age;
        }
    }
}
