using System;
using System.Collections;

namespace Exam2
{
    class AccountList
    {
        ulong id = 0;
        ArrayList accounts = new ArrayList();

        public void CreateAccount(long balance, string firstName, string lastName, byte gender)
        {
            Account account = new Account(id, balance, firstName, lastName, gender);

            accounts.Add(account);

            id++;
        }

        public void PayInto(ulong accountId, int amount)
        {
            bool isFind = false;
            foreach (Account acc in accounts)
            {
                if (acc.AccountId == accountId)
                {
                    acc.PayInto(amount);
                    isFind = true;
                }
            }

            if (!isFind)
            {
                Console.WriteLine("Account not found!");
            }
        }

        public int Check()
        {

        }

        public void ShowData()
        {
            foreach (Account account in accounts)
            {
                account.ShowInfo();
            }
        }
    }
}
