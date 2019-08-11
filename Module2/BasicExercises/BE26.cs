using System;
using System.Collections.Generic;
using System.Text;

namespace BasicExercises
{
    class BE26
    {
        static void Main()
        {
            Console.WriteLine("Sum of the first 500 prime numbers: ");
            long sum = 0;
            int ctr = 0;
            int n = 2;
            while (ctr < 500)
            {
                if (isPrime(n))
                {
                    Console.WriteLine(n);
                    sum += n;
                    ctr++;
                }
                n++;
            }

            Console.WriteLine("Sum = " + sum.ToString());

        }
        public static bool isPrime(int n)
        {
            if (n < 2) return false;

            int x = (int)Math.Floor(Math.Sqrt(n));

            for (int i = 2; i <= x; i++)
            {
                if (n % i == 0) return false;
            }

            return true;
        }
    }
}