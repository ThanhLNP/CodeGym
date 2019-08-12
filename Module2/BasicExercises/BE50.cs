﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BasicExercises
{
    class BE50
    {
        static void Main()
        {
            int[] nums = { 1, 2, 8 };
            Console.WriteLine("Array1: [{0}]", string.Join(", ", nums));
            var temp = nums[0];
            for (var i = 0; i < nums.Length - 1; i++)
            {
                nums[i] = nums[i + 1];
            }
            nums[nums.Length - 1] = temp;
            Console.WriteLine("After rotating array becomes: [{0}]", string.Join(", ", nums));
        }
    }
}
