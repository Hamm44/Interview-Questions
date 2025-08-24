
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] x = { 10, 12, 17, 25, 15 };
            int first = int.MinValue;
            int second = int.MinValue;
            int third = int.MinValue;
            for (int i = 0; i < x.Length; i++)
            {
                if (x[i] > first)
                {
                    third = second;
                    second = first;
                    first = x[i];
                }
                else if (x[i] > second && x[i] < first)
                {
                    third = second;
                    second = x[i];
                }
                else if (x[i] > third && x[i] < second)
                {
                    third = x[i];
                }
            }
            Console.WriteLine(third);


        }


    }



