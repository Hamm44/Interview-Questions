using System.Net.Cache;

namespace ConsoleApp28
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person("Luka", "Lukia", 27);
            Console.WriteLine(person1);

        }
    }

    class Person
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string University { get; set; }
        public Person(string name, string lastName, int age, string university)
        {
            Name = name;
            LastName = lastName;
            Age = age;
            University = university;

        }
        public Person(string name, string lastName, int age)
        {
            Name = name;
            LastName = lastName;
            Age = age;
            University = "Algo Uni";
        }

        public override string ToString()
        {
            return $"Name {Name}, LastName{LastName}, Age{Age}, University{University}";
        }

    }
}

