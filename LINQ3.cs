namespace ConsoleApp43
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var listNumber = list.First(numb => numb > 8);
            Console.WriteLine(listNumber);
            var numberList = (from num in list
                              where num > 8
                              select num).First();

            Console.WriteLine(numberList);
        }
    }
}
