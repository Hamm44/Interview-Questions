using System.Text;

namespace ConsoleApp21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter word");
            string x = Console.ReadLine();
            string y = reverseWord(x);
            Console.WriteLine(y);

        }
        public static string reverseWord(string word)
        {
            StringBuilder ne = new StringBuilder();
            for (int i = word.Length - 1; i >= 0; i--)
            {
                ne.Append(word[i]);
            }
            return ne.ToString();
        }
    }
}
