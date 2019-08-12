using System;
using System.Collections.Generic;
using System.Text;

namespace BasicExercises
{
    class BE52
    {
        static void Main()
        {
            int[] array1 = { 1, 2, 5 };
            Console.WriteLine("Array1: [{0}]", string.Join(", ", array1));
            int[] array2 = { 0, 3, 8 };
            Console.WriteLine("Array2: [{0}]", string.Join(", ", array2));
            int[] array3 = { -1, 0, 2 };
            Console.WriteLine("Array3: [{0}]", string.Join(", ", array3));
            int[] new_array = { array1[1], array2[1], array3[1] };
            Console.WriteLine("New array: [{0}]", string.Join(", ", new_array));
        }
    }
}
