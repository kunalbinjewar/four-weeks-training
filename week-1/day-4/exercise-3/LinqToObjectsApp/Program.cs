namespace LinqToObjectsApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>
            {
                new Person { Name = "John", Age = 25, Country = "USA" },
                new Person { Name = "Jane", Age = 30, Country = "Canada" },
                new Person { Name = "Mark", Age = 28, Country = "USA" },
                new Person { Name = "Emily", Age = 22, Country = "Australia" }
            };


            //Write queries using LINQ for following operations
            //1. Get all people from USA
            //2. Get all people above 30
            //3. Sort people by name
            //4. Project/Select only Name and Country of all people

        }
    }

    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Country { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Country { get; set; }
}
class Program
{
    static void Main(string[] args)
    {
        List<Person> people = new List<Person>
        {
            new Person { Name = "Raman", Age = 31, Country = "India" },
            new Person { Name = "Rohit", Age = 32, Country = "India" },
            new Person { Name = "Riya", Age = 19, Country = "India" },
            new Person { Name = "Rakesh", Age = 25, Country = "India" },
        };
        // Filtering people above a certain age
        int minimumAge = 30;
        var filteredPeople = people.Where(p => p.Age > minimumAge);
        Console.WriteLine("People above a certain age:");
        foreach (var person in filteredPeople)
        {
            Console.WriteLine($"Name: {person.Name}, Age: {person.Age}, Country: {person.Country}");
        }
        Console.WriteLine();
        // Sorting the list by name in ascending order
        var sortedPeople = people.OrderBy(p => p.Name);
        Console.WriteLine("People sorted by name:");
        foreach (var person in sortedPeople)
        {
            Console.WriteLine($"Name: {person.Name}, Age: {person.Age}, Country: {person.Country}");
        }
        Console.WriteLine();
        // Projecting the list into a new list of objects with just Name and Country properties
        var projectedPeople = people.Select(p => new { p.Name, p.Country });
        Console.WriteLine("Projected list:");
        foreach (var person in projectedPeople)
        {
            Console.WriteLine($"Name: {person.Name}, Country: {person.Country}");
        }
    }
}





