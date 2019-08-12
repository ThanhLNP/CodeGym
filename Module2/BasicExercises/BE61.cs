using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BasicExercises
{
    class BE61
    {
        static void Main()
        {
            int[] x = sort_numbers(new int[] { -5, 236, 120, 70, -5, -5, 698, 280 });
            foreach (var item in x)
            {
                Console.WriteLine(item);
            }
        }

        public static int[] sort_numbers(int[] arra)
        {
            //lay ra nhung phan tu khac -5 va sap xep
            int[] num = arra.Where(x => x != -5).OrderBy(x => x).ToArray();
            int ctr = 0;
            Console.WriteLine(String.Join(", ", num));
            
            return arra.Select(x => x >= 0 ? num[ctr++] : -5).ToArray();
        }
    }
}
