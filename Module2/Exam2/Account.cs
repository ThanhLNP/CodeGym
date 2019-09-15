using System;

namespace Exam2
{
    class Account : IAccount
    {
        ulong accountId;
        long balance;
        string firstName;
        byte gender;
        string lastName;

        public ulong AccountId { get => accountId; set => accountId = value; }
        public long Balance { get => balance; }
        public string FirstName { get => firstName; set => firstName = value; }
        public byte Gender { get => gender; set => gender = value; }
        public string LastName { get => lastName; set => lastName = value; }

        public Account()
        {

        }

        public Account(ulong accountId, long balance, string firstName, string lastName, byte gender)
        {
            AccountId = accountId;
            this.balance = balance;
            FirstName = firstName;
            LastName = lastName;
            Gender = gender;
        }

        public void PayInto(int amount)
        {
            balance += amount;
        }

        public void ShowInfo()
        {
            string genderStr = "";
            if (gender == 1)
            {
                genderStr = "Male";
            }
            if (gender == 0)
            {
                genderStr = "Female";
            }
            Console.WriteLine("Account ID: {0}, Balance: {1}, First name: {2}, Last name: {3}, Gender: {4}", accountId, balance, firstName, lastName, genderStr);
        }
    }
}
