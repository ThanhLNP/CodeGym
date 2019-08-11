using System;
using System.Collections.Generic;
using System.Text;

namespace BasicExercises
{
    class BE39
    {
        static void Main()
        {
            Console.Write("Input first integer: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input second integer: ");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input third integer: ");
            int z = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Largest of three: " + Math.Max(x, Math.Max(y, z)));
            Console.WriteLine("Lowest of three: " + Math.Min(x, Math.Min(y, z)));
        }
    }
}
