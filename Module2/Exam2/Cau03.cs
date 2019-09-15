using System;
using System.Collections.Generic;
using System.Text;

namespace Exam2
{
    class Cau03
    {
        static AccountList accounts = new AccountList();
        public static void Main()
        {
            InitMenu();
        }

        public static void InitMenu()
        {
            int option = 0;

            do
            {
                Console.WriteLine("Management Account");
                Console.WriteLine("1. Create Account");
                Console.WriteLine("2. Pay Into");
                Console.WriteLine("3. Show Data");
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
                    Create();
                    break;
                case 2:
                    PayInto();
                    break;
                case 3:
                    accounts.ShowData();
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

        public static void Create()
        {
            long balance = -1;
            do
            {
                Console.Write("Balance: ");
                if (long.TryParse(Console.ReadLine(), out var number))
                {
                    balance = number;
                }
            }
            while (balance < 0);


            Console.Write("Fist name: ");
            string firstName = Console.ReadLine();

            Console.Write("Last name: ");
            string lastName = Console.ReadLine();

            byte gender = 2;
            do
            {
                Console.Write("Gender (0. Female, 1. Male): ");
                if (byte.TryParse(Console.ReadLine(), out var number))
                {
                    gender = number;
                }
            }
            while (gender != 0 && gender != 1);

            accounts.CreateAccount(balance, firstName, lastName, gender);
        }

        public static void PayInto()
        {
            ulong accountId;
            do
            {
                Console.Write("Input Account ID: ");
                if (ulong.TryParse(Console.ReadLine(), out var number))
                {
                    accountId = number;
                    break;
                }
            }
            while (true);


            int amount = -1;
            do
            {
                Console.Write("Pay Into: ");
                if (int.TryParse(Console.ReadLine(), out var number))
                {
                    amount = number;
                }
            }
            while (amount < 0);

            accounts.PayInto(accountId, amount);
        }
    }
}
