using System;
using System.Collections.Generic;
using System.Text;

namespace BasicExercises
{
    class BE06
    {
        static void Main()
        {
            int num1, num2, num3;
            Console.Write("Input the first number to multiply: ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("Input the second number to multiply: ");
            num2 = int.Parse(Console.ReadLine());
            Console.Write("Input the third number to multiply: ");
            num3= int.Parse(Console.ReadLine());
            Console.WriteLine("{0} x {1} x {2} = {3}", num1, num2, num3, num1 * num2 * num3);
        }
    }
}
