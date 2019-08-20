using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.News
{
    class NewsMain
    {
        public static void Main()
        {
            InitMenu();
        }

        public static void InitMenu()
        {
            int option = 0;

            do
            {
                Console.WriteLine("Management News");
                Console.WriteLine("1. Insert news");
                Console.WriteLine("2. View list news");
                Console.WriteLine("3. Average rate");
                Console.WriteLine("4. Exit");

                Console.Write("Please select an option from 1 to 4: ");
                if (int.TryParse(Console.ReadLine(), out var number))
                {
                    option = number;
                }

                Console.WriteLine("\n********************");
            }
            while (option < 1 || option > 4);

            Process(option);
        }

        public static void Process(int selected)
        {
            Console.WriteLine("Option: {0}", selected);

            switch (selected)
            {
                case 1:
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    {
                        Console.WriteLine("Exit");
                        Environment.Exit(Environment.ExitCode);
                        break;
                    }

            }

            Console.WriteLine("\n********************");

            InitMenu();
        }
    }
}
