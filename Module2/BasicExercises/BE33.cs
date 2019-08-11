using System;
using System.Collections.Generic;
using System.Text;

namespace BasicExercises
{
    class BE33
    {
        static void Main()
        {
            Console.Write("Input integer: ");
            int x = Convert.ToInt32(Console.ReadLine());
            if (x > 0)
            {
                Console.WriteLine(x % 3 == 0 || x % 7 == 0);
            }
        }
    }
}
