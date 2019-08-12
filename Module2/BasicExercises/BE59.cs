using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BasicExercises
{
    class BE59
    {
        static void Main()
        {
            Console.WriteLine(test_Increasing_Sequence(new int[] { 1, 3, 5, 6, 9 }));
            Console.WriteLine(test_Increasing_Sequence(new int[] { 0, 10 }));
            Console.WriteLine(test_Increasing_Sequence(new int[] { 1, 3, 1, 3 }));
        }

        //kiem tra mang co tang nghiem ngat hay ko
        public static bool test_Increasing_Sequence(int[] intArray)
        {
            int[] tempArray = (int[])intArray.Clone();
            Array.Sort(tempArray);
            return intArray.SequenceEqual(tempArray);
        }
    }
}
