using System;
using System.Collections.Generic;
using System.Text;

namespace Exam
{
    class Cau02
    {
        static int[] array;
        public static void Main()
        {
            InitMenu();
        }

        public static void InitMenu()
        {
            int option = 0;

            do
            {
                Console.WriteLine("Management array");
                Console.WriteLine("1. Create array");
                Console.WriteLine("2. Check array");
                Console.WriteLine("3. Sort array");
                Console.WriteLine("4. Find in array");
                Console.WriteLine("5. Exit");

                Console.Write("Please select an option from 1 to 5: ");
                if (int.TryParse(Console.ReadLine(), out var number))
                {
                    option = number;
                }

                Console.WriteLine("\n********************");
            }
            while (option < 1 || option > 5);

            Process(option);
        }

        public static void Process(int selected)
        {
            Console.WriteLine("Option: {0}", selected);

            switch (selected)
            {
                case 1:
                    array = InitArray();
                    break;
                case 2:
                    if (IsIncreaseArray(array))
                    {
                        Console.WriteLine("Array is increase");
                    }
                    else
                    {
                        Console.WriteLine("Array is not increase");
                    }
                    break;
                case 3:
                    SelectedSort(array);
                    Console.WriteLine("Sorted!");
                    break;
                case 4:
                    if (IsIncreaseArray(array))
                    {
                        Console.WriteLine(Find(array));
                    }
                    else
                    {
                        Console.WriteLine("You need sort first!");
                    }
                    break;
                case 5:
                    {
                        Console.WriteLine("Exit");
                        Environment.Exit(Environment.ExitCode);
                        break;
                    }
            }

            Console.WriteLine("\n********************");

            InitMenu();
        }

        public static int[] InitArray()
        {
            int size = -1;
            do
            {
                Console.Write("Intput size of array: ");
                if (int.TryParse(Console.ReadLine(), out var number))
                {
                    size = number;
                }
            }
            while (size <= 0);

            int[] array = new int[size];
            for (int i = 0; i < size; i++)
            {
                do
                {
                    Console.Write("Input Array[{0}]: ", i);
                    if (int.TryParse(Console.ReadLine(), out var number))
                    {
                        array[i] = number;
                        break;
                    }
                }
                while (true);
            }
            return array;
        }

        public static bool IsIncreaseArray(int[] array)
        {
            bool isIncreaseArray = true;

            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i + 1] < array[i])
                {
                    isIncreaseArray = false;
                }
            }

            return isIncreaseArray;
        }

        public static void SelectedSort(int[] array)
        {
            int index;
            int temp;
            for (int i = 0; i < array.Length - 1; i++)
            {
                index = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[index] > array[j])
                    {
                        index = j;
                    }
                }
                if (index != i)
                {
                    temp = array[i];
                    array[i] = array[index];
                    array[index] = temp;
                }
            }
        }

        public static string Find(int[] array)
        {
            int n;
            do
            {
                Console.Write("Input number: ");
                if (int.TryParse(Console.ReadLine(), out var number))
                {
                    n = number;
                    break;
                }
            }
            while (true);

            int index = BinarySearch(array, n);

            if (index != -1)
            {
                return index.ToString();
            }
            else
            {
                return "Khong tim thay!";
            }

        }

        public static int BinarySearch(int[] array, int value)
        {
            int left = 0;
            int right = array.Length - 1;
            int mid;

            while (left <= right)
            {
                mid = (left + right) / 2;
                if (array[mid] == value)
                {
                    return mid;
                }
                else if (array[mid] > value)
                {
                    right = mid - 1;
                }
                else
                {
                    left = mid + 1;
                }
            }

            return -1;
        }
    }
}
