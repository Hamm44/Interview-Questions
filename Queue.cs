namespace ConsoleApp35
{
    internal class Program
    {
        static void Main(string[] args)
        {
            queue myqueue = new queue();
            Queue<string> ints = myqueue.doEnqueue(14);
            Console.WriteLine(ints.ToString());
        }
    }

    class queue
    {
        public Queue <string>  doEnqueue(int z)
        {
            Queue<string> ints = new Queue<string>();
            ints.Enqueue("1");
            for (int i = 0; i < z; i++)
            {
                string m = ints.Dequeue();
                Console.WriteLine(m);
                ints.Enqueue(m + "0");
                ints.Enqueue(m + "1");
            }

            return ints;
        }
    }
}
