using System;
using System.Collections.Generic;
using System.Text;

namespace BasicExercises
{
    class BE49
    {
        static void Main()
        {
            int[] nums1 = { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1 };
            Console.WriteLine("Array1: [{0}]", string.Join(", ", nums1));
            int[] nums2 = { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 5 };
            Console.WriteLine("Array2: [{0}]", string.Join(", ", nums2));

            Console.WriteLine("Check if the first element or the last element of the two arrays (length 1 or more) are equal.");
            Console.WriteLine(nums1.Length > 0 && nums2.Length > 0 && (nums1[0].Equals(nums2[0]) || nums1[nums1.Length - 1].Equals(nums2[nums2.Length - 1])));
        }
    }
}
