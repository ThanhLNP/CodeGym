using System;
using System.Collections.Generic;
using System.Text;

namespace BasicExercises
{
    class BE21
    {
        static void Main()
        {
            int x, y;

            Console.Write("Input first integer: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input second integer: ");
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(x == 20 || y == 20 || (x + y == 20));
        }
    }
}
