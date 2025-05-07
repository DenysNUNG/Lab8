using Lab8.Models;

namespace Lab8;

class Program
{
    static void Main(string[] args)
    {
        var people = new List<Person>
        {
            new Person { Name = "John Doe1", Age = 21 },
            new Person { Name = "John Doe2", Age = 22 },
            new Person { Name = "John Doe3", Age = 23 },
            new Person { Name = "John Doe4", Age = 24 },
            new Person { Name = "John Doe5", Age = 25 },
            new Person { Name = "John Doe6", Age = 26 },
            new Person { Name = "John Doe7", Age = 27 },
            new Person { Name = "John Doe8", Age = 28 },
            new Person { Name = "John Doe9", Age = 29 },
            new Person { Name = "John Doe0", Age = 30 }
        };

        people.ForEach(Console.WriteLine);
    }
}
