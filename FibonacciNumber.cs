namespace FibonacciNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            string? x = Console.ReadLine();
            int y = int.Parse(x);
            int first = 0;
            int second = 1;
            if (y <= 0)
            {
                Console.WriteLine("number must be positive");
            }
            else if (y == 1)
            {
                Console.WriteLine(first);
            }
            else
            {
                Console.WriteLine($"{first} \n{second}");
                for (int i = 2; i < y; i++)
                {
                    int nextNum = first + second;
                    Console.WriteLine(nextNum);
                    first = second;
                    second = nextNum;
                }
            }

        }
    }
}
