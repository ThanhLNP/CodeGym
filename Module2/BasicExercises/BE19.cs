using System;
using System.Collections.Generic;
using System.Text;

namespace BasicExercises
{
    class BE19
    {
        static void Main()
        {
            Console.Write("Enter first number: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine(sumTriple(num1, num2));
        }
        public static int sumTriple(int a, int b)
        {
            return a == b ? (a + b) * 3 : a + b;
        }
    }
}
