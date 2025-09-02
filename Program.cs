namespace ConsoleApp34
{
    internal class Program
    {
        static void Main(string[] args)
        {
            stack mystack = new stack();
            Stack<char> chars = mystack.getPush("LUKA");
            foreach (char c in chars)
            {
                Console.Write(c);
            }
            Console.WriteLine();
            Stack<char> reverse = mystack.getPop(chars);
            foreach (char c in reverse)
            {
                Console.Write(c);
            }


        }
    }
    class stack
    {
        public Stack<char> getPush(string m)
        {
            Stack<char> charie = new Stack<char>();
            foreach (var n in m)
            {
                charie.Push(n);
            }
            return charie;

        }
        public Stack<char> getPop(Stack<char> k)
        {
            Stack<char> popie = new Stack<char>();
            while (k.Count > 0)
            {
                var n = k.Pop();
                popie.Push(n);
            }
            return popie;
        }

    }
}
