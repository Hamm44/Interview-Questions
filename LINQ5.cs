using System.Diagnostics;

namespace ConsoleApp45
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int> { 4, 5, 8, 12, 16, 55, 2, 3 };
            bool listNumb = list.Any(odd => odd % 2 == 1);
            Console.WriteLine(listNumb);
            bool numbList = (from n in list
                             where n % 2 == 1
                             select n).Any();
            Console.WriteLine(numbList);
        }
    }
}
