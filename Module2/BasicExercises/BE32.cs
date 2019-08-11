using System;
using System.Collections.Generic;
using System.Text;

namespace BasicExercises
{
    class BE32
    {
        static void Main()
        {
            Console.Write("Input a string : ");
            string str = Console.ReadLine();
            if (str.Length >= 4)
            {
                for (int i = 0; i < 4; i++)
                {
                    Console.Write(str.Substring(str.Length - 4));
                }
            }
            else
            {
                Console.WriteLine(str);
            }
        }
    }
}
