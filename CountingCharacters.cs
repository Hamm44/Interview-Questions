namespace ConsoleApp23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            countLetters("Hello Worldd");

        }

        public static void countLetters(string letter)
        {
            Dictionary<char, int> x = new Dictionary<char, int>();
            foreach (char c in letter)
            {
                if (c != ' ')
                {
                    if (!x.ContainsKey(c))
                    {
                        x.Add(c, 1);
                    }
                    else
                    {
                        x[c]++;
                    }
                }
            }
            foreach (var d in x)
            {
                Console.WriteLine("{0} {1}", d.Key, d.Value);
            }
        }
    }
}
