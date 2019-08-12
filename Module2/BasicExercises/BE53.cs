using System;
using System.Collections.Generic;
using System.Text;

namespace BasicExercises
{
    class BE53
    {
        static void Main()
        {
            int[] nums = { 2, 4, 7, 8, 6 };
            Console.WriteLine("Original array: [{0}]", string.Join(", ", nums));
            Console.WriteLine("Check if an array contains an odd number? " + even_odd(nums));
        }

        public static bool even_odd(int[] nums)
        {
            foreach (var n in nums)
            {
                if (n % 2 != 0)
                    return true;
            }
            return false;
        }
    }
}
