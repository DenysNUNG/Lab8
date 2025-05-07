using Lab8.Models;

namespace Lab8;

class Program
{
    static void Main(string[] args)
    {
        var people = new List<Person>
        {
            new Person { Name = "Tom", Age = 21 },
            new Person { Name = "Bob", Age = 22 },
            new Person { Name = "John", Age = 23 },
            new Person { Name = "Jane", Age = 24 },
            new Person { Name = "Sara", Age = 25 },
            new Person { Name = "Martin", Age = 26 },
            new Person { Name = "Boris", Age = 27 },
            new Person { Name = "Sam", Age = 28 },
            new Person { Name = "Stephen", Age = 29 },
            new Person { Name = "Denys", Age = 30 }
        };

        foreach(var person in people)
        {
            Console.WriteLine($"Name: {person.Name} Age: {person.Age}");
        }
    }
}
