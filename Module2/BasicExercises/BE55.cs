using System;
using System.Collections.Generic;
using System.Text;

namespace BasicExercises
{
    class BE55
    {
        static void Main()
        {
            Console.WriteLine(array_adjacent_elements_product(new int[] { 2, 4, 2, 6, 9, 3 }) == 27);
            Console.WriteLine(array_adjacent_elements_product(new int[] { 0, -1, -1, -2 }) == 2);
            Console.WriteLine(array_adjacent_elements_product(new int[] { 6, 1, 12, 3, 1, 4 }) == 36);
            Console.WriteLine(array_adjacent_elements_product(new int[] { 1, 4, 3, 0 }) == 16);
        }
        public static int array_adjacent_elements_product(int[] input_array)
        {
            int max_product = input_array[0] * input_array[1];
            int product = 0;
            for (int i = 1; i < input_array.Length - 1; i++)
            {
                product = input_array[i] * input_array[i + 1];
                if (product > max_product)
                {
                    max_product = product;
                }
            }
            return max_product;
        }
    }
}
