namespace ConsoleApp13
{
    internal class MergedLists
    {
        static void Main(string[] args)
        {
            List<int> list1 = new List<int>();
            List<int> list2 = new List<int>();
            list1.Add(1);
            list1.Add(2);
            list1.Add(3);
            list2.Add(4);
            list2.Add(3);
            list2.Add(5);
            list1.AddRange(list2);
            list1.Sort();
            foreach (int i in list1)
            {
                Console.WriteLine(i);
            }

        }
    }
}
