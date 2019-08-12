using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BasicExercises
{
    class BE45
    {
        static void Main()
        {
            Console.Write("Input an integer: ");
            int x = Convert.ToInt32(Console.ReadLine());
            int[] nums = { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 9 };
            Console.WriteLine("Number of " + x + " present in the said array: " + nums.Count(n => n == x));
        }
    }
}
