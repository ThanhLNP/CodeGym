using System;
using System.Collections.Generic;
using System.Text;

namespace BasicExercises
{
    class BE46
    {
        static void Main()
        {
            Console.Write("Input an integer: ");
            int x = Convert.ToInt32(Console.ReadLine());
            int[] nums = { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 9 };
            Console.WriteLine((nums.Length > 0) && (nums[0] == x || nums[nums.Length - 1] == x));
        }
    }
}
