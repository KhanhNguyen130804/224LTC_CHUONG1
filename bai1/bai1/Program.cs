using System;

class Program
{
    static void Main()
    {
        int i221, n221;
        long S221;
        S221 = 0;
        i221 = 1;

        Console.Write("\nNhap n: ");
        n221 = Convert.ToInt32(Console.ReadLine());

        while (i221 <= n221)
        {
            S221 = S221 + i221;
            i221++;
        }

        Console.WriteLine("\nTong 1 + 2 + ... + {0} la {1}", n221, S221);
        Console.ReadKey();
    }
}
