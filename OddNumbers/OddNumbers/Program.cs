using System;
public class Exercise25
{
    public static void Main()
    {
        Console.WriteLine("Odd numbers from 1 to 99. Prints one number per line.");
        for (int n = 1; n < 100; n++)
        {
            if (n % 2 != 0)
            {
                Console.WriteLine(n.ToString());
                System.Threading.Thread.Sleep(100);
            }
        }

    }
}
