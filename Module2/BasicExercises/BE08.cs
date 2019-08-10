using System;
using System.Collections.Generic;
using System.Text;

namespace BasicExercises
{
    class BE08
    {
        static void Main()
        {
            Console.Write("Enter the number: ");
            int number = int.Parse(Console.ReadLine());
            for(int i = 0; i <= 10; i++)
            {
                Console.WriteLine("{0} x {1} = {2}", number, i, number * i);
            }
        }
    }
}
