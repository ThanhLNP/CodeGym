using System;
using System.Collections.Generic;
using System.Text;

namespace BasicExercises
{
    class BE10
    {
        static void Main()
        {
            Console.Write("Enter first number: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            int num2 = int.Parse(Console.ReadLine());
            Console.Write("Enter third number: ");
            int num3 = int.Parse(Console.ReadLine());
            Console.WriteLine("({0} + {1}).{2} = {3}", num1, num2, num3, (num1 + num2) * num3);
            Console.WriteLine("{0}.{1} + {1}.{2} = {3}", num1, num2, num3, num1 * num2 + num2 * num3);
        }
    }
}
