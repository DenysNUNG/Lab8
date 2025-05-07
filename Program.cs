using Lab8.Models;

namespace Lab8;

class Program
{
    static void Main(string[] args)
    {
        var people = new List<Person>
        {
            new Person { Name = "Tom", Age = 21, Salary = 1 },
            new Person { Name = "Bob", Age = 22, Salary = 1 },
            new Person { Name = "John", Age = 23, Salary = 1 },
            new Person { Name = "Jane", Age = 24, Salary = 1 },
            new Person { Name = "Sara", Age = 25, Salary = 1 },
            new Person { Name = "Martin", Age = 26, Salary = 1 },
            new Person { Name = "Boris", Age = 27, Salary = 1 },
            new Person { Name = "Sam", Age = 28, Salary = 1 },
            new Person { Name = "Stephen", Age = 29, Salary = 1 },
            new Person { Name = "Denys", Age = 30, Salary = 1 }
        };

        foreach (var person in people)
        {
            Console.WriteLine($"Name: {person.Name} Age: {person.Age}");
        }
    }
}
