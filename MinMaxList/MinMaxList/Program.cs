using System;
using System.Collections.Generic;
using System.Linq;

namespace MaxAndMin
{
    public class Program
    {
        static void Main(string[] args)
        {
            int numberOfElements = Convert.ToInt32(Console.ReadLine());
            List<int> elements = new List<int>();
            for (int i = 0; i < numberOfElements;)
            {
                int element = 0;
                bool isNumber = int.TryParse(Console.ReadLine(), out element);
                if (isNumber)
                {
                    elements.Add(element);
                    i++;
                }
                else
                {
                    Console.WriteLine("Please insert only numbers");
                }

            }
            Console.WriteLine("Min: " + elements.Min());
            Console.WriteLine("Max: " + elements.Max());
            Console.Read();
        }
    }
}