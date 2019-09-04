using System;
using System.IO;

namespace FileIO
{
    class FileStreamTest
    {
        public static class Helper
        {
            private static string fileName = $"D:/code-gym/Module2/FileIO/Log_{DateTime.Now.ToString("dd_MM_yyyy")}.txt";

            public static void WriteLog(string message)
            {
                FileStream file = new FileStream(fileName, FileMode.Append);
                using (StreamWriter writer = new StreamWriter(file))
                {
                    writer.WriteLine($"[Error]: {DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss tt")}: {message}");
                }
            }

            public static string ReadLog()
            {
                string line;

                FileStream fsReader = new FileStream(fileName, FileMode.Open);
                using (StreamReader reader = new StreamReader(fsReader))
                {
                    line = reader.ReadToEnd();
                }

                return line;
            }
        }

        static void Main(string[] args)
        {
            #region Try Catch and File IO
            try
            {
                Console.Write("Input a = ");
                var a = int.Parse(Console.ReadLine());
                Console.Write("Input b = ");
                var b = int.Parse(Console.ReadLine());
                var result = a / b;
                Console.WriteLine("{0}/{1}={2}", a, b, result);
            }
            catch (DivideByZeroException dze)
            {
                Helper.WriteLog(dze.Message);
                Console.Write(Helper.ReadLog());
            }
            catch (Exception ex)
            {
                Helper.WriteLog(ex.Message);
                Console.Write("Something went wrong, please again later.");
            }
            finally
            {
                Console.WriteLine("Go to finally");
            }
            #endregion

            #region TextArray
            FileStream fsArrayWriter = new FileStream("D:/code-gym/Module2/FileIO/TextArray.txt", FileMode.Create);
            using (StreamWriter arrayWriter = new StreamWriter(fsArrayWriter))
            {
                Console.Write("intput size of array: ");
                var n = int.Parse(Console.ReadLine());
                arrayWriter.WriteLine(n);

                for (int i = 0; i < n; i++)
                {
                    Console.Write("Input A[{0}]: ", i);
                    var v = Console.ReadLine();
                    arrayWriter.Write(v.ToString() + " ");
                }
                arrayWriter.WriteLine();
            }

            FileStream fsArrayReader = new FileStream("D:/code-gym/Module2/FileIO/TextArray.txt", FileMode.Open);
            using (StreamReader arrayReader = new StreamReader(fsArrayReader))
            {
                string line1 = arrayReader.ReadLine();
                Console.WriteLine(line1);
                string line2 = arrayReader.ReadLine();
                Console.WriteLine(line2);
                string[] arr = line2.Split(' ');
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.WriteLine(arr[i]);
                }
            }
            #endregion

            #region TextBinary
            FileStream fsBinaryWriter = new FileStream("D:/code-gym/Module2/FileIO/TextBinary.txt", FileMode.Create);
            using (BinaryWriter binaryWriter = new BinaryWriter(fsBinaryWriter))
            {
                for (int i = 0; i < 20; i++)
                {
                    binaryWriter.Write((byte)i++);
                }
            }

            FileStream fsBinaryReader = new FileStream("D:/code-gym/Module2/FileIO/TextBinary.txt", FileMode.Open);
            using (BinaryReader binaryReader = new BinaryReader(fsBinaryReader))
            {
                var line = binaryReader.ReadBytes(10);
                Console.WriteLine("----------");
                Console.WriteLine(string.Join(", ", line));
            }
            #endregion
        }
    }
}