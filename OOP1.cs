namespace ConsoleApp29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat("fishkuna", 3);
            cat.letSpeak();
        }
    }

    class Cat
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public void letSpeak()
        {
            Console.WriteLine("meow");
        }
        public Cat(string name, int age)
        {
            Name = name;
            Age = age;
        }

        
    }
}
