namespace ConsoleApp41
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] z = { 1, 2, 3, 4, 5 };
            //var m = z.Where(x => x % 2 == 0);
            //foreach (var x in m)
            //{
            //    Console.WriteLine(x);
            //}
            var evenNumbers = from num in z
                              where num % 2 == 0
                              select num;

            foreach (var numbs in evenNumbers)
            {
                Console.WriteLine(numbs);
            }
        }
    }
}
