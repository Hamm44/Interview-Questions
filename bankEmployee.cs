namespace ConsoleApp32
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee("Luka", 15000);
            employee.displayInfo();
            Manager manager = new Manager("Ani", 25000, 1000);
            manager.displayInfo();
            Developer developer = new Developer("Python", "Ani", 25000, 5000);
            developer.displayInfo();
        }
    }

    class Employee
    {
        private string name;
        private int salary;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Salary
        {
            get { return salary; }
            set
            {
                if (value < 1000)
                {
                    salary = 1000;
                }
                else
                {
                    salary = value;
                }
            }

        }
        public Employee(string name, int salary)
        {
            Salary = salary;
            Name = name;
        }
        public virtual void displayInfo()
        {
            Console.WriteLine($"{Name}, {Salary}");
        }

    }

    class Manager : Employee
    {
        public int Bonus { get; set; }
        public  Manager(string name, int salary, int bonus) : base(name, salary)
        {
            Bonus = bonus;
        }
        public int calculateTotalSalary()
        {
            int sum = Bonus + Salary;
            return sum;
        }
        public override void displayInfo()
        {
            Console.WriteLine($"{Name}, {Salary}, {Bonus}, {calculateTotalSalary()}");
        }
    }
    class Developer : Manager
    {
        public string programmingLanguage { get; set; }

        public Developer(string language, string name, int salary, int bonus) : base(name, salary, bonus)
        {
            programmingLanguage = language;

        }
        public void workOnProject(string projectName)
        {
            Console.WriteLine($"{Name},{projectName}, {programmingLanguage} ");
        }
        public override void displayInfo()
        {
            Console.WriteLine($"{Name}, {Salary}, {Bonus}, {programmingLanguage}, {calculateTotalSalary()}");
        }
    }
}
