using System;
using System.Collections.Generic;
using System.Text;

namespace BasicExercises
{
    class BE13
    {
        static void Main()
        {
            int x;

            Console.Write("Enter a number: ");
            x = Convert.ToInt32(Console.ReadLine());

            for(int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (i == 0 || i == 4 || j == 0 || j == 2)
                    {
                        Console.Write(x);
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
