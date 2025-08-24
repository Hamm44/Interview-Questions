using System.Diagnostics;

namespace ConsoleApp24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            string x = removeDuplicate("Hello Hello");
            Console.WriteLine(x);
        }

        public static string removeDuplicate(string name)
        {
            string m = "";
            for (int i = 0; i < name.Length; i++)
            {
                bool exists = false;
                for (int j = 0; j < m.Length; j++)
                {
                    if (m[j] == name[i])
                    {
                        exists = true;
                        break;
                    }
                }
                if (!exists)
                {
                    m += name[i];
                }
            }
            return m;
        }
    }
}
