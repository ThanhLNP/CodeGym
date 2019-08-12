using System;
using System.Collections.Generic;
using System.Text;

namespace BasicExercises
{
    class BE57
    {
        static void Main()
        {
            Console.WriteLine(adjacent_Elements_Product(new int[] { 1, 3, 4, 5, 2 }));
            Console.WriteLine(adjacent_Elements_Product(new int[] { 1, 3, -4, 5, 2 }));
            Console.WriteLine(adjacent_Elements_Product(new int[] { 1, 0, -4, 0, 2 }));
        }
        public static int adjacent_Elements_Product(int[] input_Array)
        {
            int max = 0;
            for (int i = 0; i < input_Array.Length - 1;)
            {
                max = Math.Max(max, input_Array[i] * input_Array[++i]);
            }
            return max;
        }
    }
}
