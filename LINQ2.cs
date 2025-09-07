namespace ConsoleApp42
{
    namespace Luka
    {
        internal class Program
        {
            static void Main(string[] args)
            {
                List<string> list = new List<string> { "Anna", "Banna", "Alex", "Andrea", "Mary" };
                char letter = 'A';
                var listString = list.Where(n => n.StartsWith(letter.ToString()));
                var stringList = from word in list
                                 where word.StartsWith(letter.ToString())
                                 select word;

                foreach (var console in listString)
                {
                    Console.WriteLine(console);
                }
                foreach (var line in stringList)
                {
                    Console.WriteLine(line);
                }

            }
        }
    }

}
