using System;

namespace Exam2
{
    class Cau01
    {
        static void Main(string[] args)
        {
            int n = InputSize("row");

            int m = InputSize("column");

            int[,] array = CreateMatrix(n, m);

            Console.WriteLine("Max = {0}", FindMax(array));

            ShowMatrix(array);
        }

        public static int InputSize(string a)
        {
            int size = -1;
            do
            {
                Console.Write("Input {0}: ", a);
                if (int.TryParse(Console.ReadLine(), out var number))
                {
                    size = number;
                }
            }
            while (size <= 0);
            return size;
        }

        public static int[,] CreateMatrix(int row, int column)
        {
            int[,] array = new int[row, column];
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    do
                    {
                        Console.Write("Input Array[{0}, {1}]: ", i, j);
                        if (int.TryParse(Console.ReadLine(), out var number))
                        {
                            array[i, j] = number;
                            break;
                        }
                    }
                    while (true);
                }
            }
            return array;
        }

        public static int FindMax(int[,] array)
        {
            int max = array[0, 0];

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (max < array[i, j])
                    {
                        max = array[i, j];
                    }
                }
            }

            return max;
        }

        public static void ShowMatrix(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (i >= j)
                    {
                        Console.Write(array[i, j] + " ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
