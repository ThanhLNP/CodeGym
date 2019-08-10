using System;
using System.Collections.Generic;
using System.Text;

namespace BasicExercises
{
    class BE18
    {
        static void Main()
        {
            Console.Write("Input first integer: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input second integer: ");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Check if one is negative and one is positive:");
            Console.WriteLine((x < 0 && y > 0) || (x > 0 && y < 0));
        }
    }
}
