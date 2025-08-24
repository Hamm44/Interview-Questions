using System.Text;

namespace ConsoleApp22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter sentece");
            string z = Console.ReadLine();
            string v = changeWord(z);
            Console.WriteLine(v);


        }
        public static string changeWord(string word)
        {
            string[] x = word.Split(' ');
            StringBuilder sb = new StringBuilder();
            for (int i = x.Length - 1; i >= 0; i --)
            {
                sb.Append(x[i] + ' ');
            }

            return sb.ToString();
        }
    }
}
