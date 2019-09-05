using System;
using System.IO;

namespace FileIO
{
    class Exercise01
    {
        public static void Main()
        {
            string fileName = "D:/code-gym/Module2/FileIO/Exercise01.txt";

            #region Output Array
            FileStream fsWrite = new FileStream(fileName, FileMode.Create);
            using (StreamWriter write = new StreamWriter(fsWrite))
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
                while (size < 0);

                write.WriteLine(size);

                for (int i = 0; i < size; i++)
                {
                    do
                    {
                        Console.Write("Input A[{0}]: ", i);
                        if (int.TryParse(Console.ReadLine(), out var number))
                        {
                            int v = number;
                            write.Write(v + " ");
                            break;
                        }
                    }
                    while (true);
                }
            }
            fsWrite.Close();
            #endregion

            #region Input Array
            int sum = 0;
            int[] arrayInt;
            FileStream fsRead = new FileStream(fileName, FileMode.Open);
            using (StreamReader read = new StreamReader(fsRead))
            {
                int length = int.Parse(read.ReadLine());
                string a = read.ReadLine();

                string[] arrayString = a.Split(" ");
                arrayInt = new int[length];

                for (int i = 0; i < length; i++)
                {
                    arrayInt[i] = int.Parse(arrayString[i]);
                    sum += arrayInt[i];
                }
            }
            fsRead.Close();
            #endregion

            #region Calculate
            FileStream fs = new FileStream(fileName, FileMode.Create);
            using (StreamWriter write = new StreamWriter(fs))
            {
                write.WriteLine("Tong gia tri: " + sum);

                write.Write("Cac so chan: ");
                foreach(int i in arrayInt)
                {
                    if(i % 2 == 0)
                    {
                        write.Write(i + " ");
                    }
                }
                write.WriteLine();

                Array.Sort(arrayInt);
                write.WriteLine("Day sap xep tang dan: " + string.Join(" ", arrayInt));
            }
            #endregion
        }
    }
}
