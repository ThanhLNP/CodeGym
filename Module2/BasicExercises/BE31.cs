using System;
using System.Collections.Generic;
using System.Text;

namespace BasicExercises
{
    class BE31
    {
        static void Main()
        {
            int[] first_array = { 1, 3, -5, 4 };
            int[] second_array = { 1, 4, -5, -2 };

            Console.WriteLine("Array1: [{0}]", string.Join(", ", first_array));
            Console.WriteLine("Array2: [{0}]", string.Join(", ", second_array));

            Console.WriteLine("Multiply corresponding elements of two arrays: ");

            for (int i = 0; i < first_array.Length; i++)
            {
                Console.WriteLine(first_array[i] * second_array[i]);
            }
        }
    }
}
