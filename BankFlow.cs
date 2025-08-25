namespace ConsoleApp30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankInfo bank = new BankInfo(23);
            bank.inputMoney(200);
            bank.outputMoney(100);
        }
    }

    class BankInfo
    {
        private decimal _Balance;

        public BankInfo(decimal balance)
        {
            _Balance = balance;
        }

        public void inputMoney(decimal input)
        {
            if (input > 0)
            {
                if (input < 1000)
                {
                    Console.WriteLine($"{input}");
                }
                else
                {
                    Console.WriteLine("Exceed limitation");
                }
            }

        }
        public void outputMoney(decimal output)
        {
            if (output > 0)
            {
                if (output <= _Balance)
                {
                    _Balance = _Balance - output;
                    Console.WriteLine($"{_Balance}");
                }
                else
                {
                    Console.WriteLine("No money no honey");
                }
            }
        }

    }
}
