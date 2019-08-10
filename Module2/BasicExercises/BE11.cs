using System;
using System.Collections.Generic;
using System.Text;

namespace BasicExercises
{
    class BE11
    {
        static void Main()
        {
            int age;
            Console.Write("Enter your age ");
            age = Convert.ToInt32(Console.ReadLine());
            Console.Write("You look younger than {0} ", age);
        }
    }
}
