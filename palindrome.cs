using System;

class Palindrome
{
    static void Main()
    {
        //11211
        string? x = Console.ReadLine();
        char[] y = x.ToCharArray();
        Array.Reverse(y);
        string z = new string(y);
        bool m = (x == z);
        Console.WriteLine(m);

    }
}
