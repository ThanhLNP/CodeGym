using System;
using System.Collections.Generic;
using System.Text;

namespace BasicExercises
{
    class BE51
    {
        static void Main()
        {
            int[] nums = { 1, 2, 5, 7, 8 };
            Console.WriteLine("Array1: [{0}]", string.Join(", ", nums));
            var h_val = nums[0];
            for (var i = 1; i < nums.Length; i++)
            {
                if (nums[i] > h_val)
                    h_val = nums[i];
            }
            Console.WriteLine("Highest value between first and last values of the said array: {0}", h_val);
        }
    }
}
