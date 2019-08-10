using System;
using System.Collections.Generic;
using System.Text;

namespace BasicExercises
{
    class BE07
    {
        static void Main()
        {
            Console.Write("Input the first number: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Input the second number: ");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("{0} + {1} = {2}", num1, num2, num1 + num2);
            Console.WriteLine("{0} - {1} = {2}", num1, num2, num1 - num2);
            Console.WriteLine("{0} * {1} = {2}", num1, num2, num1 * num2);
            Console.WriteLine("{0} / {1} = {2}", num1, num2, num1 / num2);
            Console.WriteLine("{0} mod {1} = {2}", num1, num2, num1 % num2);
        }
    }
}
