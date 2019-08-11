using System;
using System.Collections.Generic;
using System.Text;

namespace BasicExercises
{
    class BE40
    {
        static void Main()
        {
            Console.Write("Input first integer: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input second integer: ");
            int y = Convert.ToInt32(Console.ReadLine());
            int n = 20;
            var val1 = Math.Abs(x - n);
            var val2 = Math.Abs(y - n);
            Console.WriteLine(val1 == val2 ? 0 : (val1 < val2 ? x : y));
        }
    }
}
