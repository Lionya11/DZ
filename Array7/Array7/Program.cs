using System;
using System.Collections.Generic;

namespace Console1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            int N = Convert.ToInt32(Console.ReadLine());

            for (int i = N; i >= 0; i--)
            {
                numbers.Add(i);
            }

            foreach (int value in numbers)
            {
                Console.WriteLine(value);
            }



        }
    }
}
