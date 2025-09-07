namespace ConsoleApp44
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string> { "Mercedes", "Porsche", "Subaru", "Koenigsegg" };
            var sort = list.OrderByDescending(name => name);
            var sort1 = list.OrderBy(name => name);
            foreach (var item in sort1)
            {
                Console.WriteLine(item);
            }
            var Sort = from n in list
                       orderby n
                       select n;
            foreach (var item in sort1)
            {
                Console.WriteLine(item);
            }
        }
    }
}
