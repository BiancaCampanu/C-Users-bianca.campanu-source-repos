using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter The Year:");
            int year = int.Parse(Console.ReadLine());
            if (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0))
            {
                Console.WriteLine("It's a leap year");
            }
            else
            {
                Console.WriteLine("It's not a leap year");
            }
            Console.ReadLine();
        }
    }
}
