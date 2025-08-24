namespace ConsoleApp25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int z = getSum(256);
            Console.WriteLine(z);

        }

        public static int getSum(int number)
        {
            char[] z = number.ToString().ToCharArray();
            int sum = 0;
            for (int i = 0; i < z.Length; i++)
            {
                sum+= z[i]-'0';
            }

            return sum;
        }
    }
}
