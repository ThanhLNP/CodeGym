using System;
using System.Collections.Generic;
using System.Text;

namespace BasicExercises
{
    class BE22
    {
        static void Main()
        {
            Console.Write("Input an integer: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(result(x));
        }

        public static bool result(int n)
        {
            if (Math.Abs(n - 100) <= 20 || Math.Abs(n - 200) <= 20)
                return true;
            return false;
        }
    }
}
