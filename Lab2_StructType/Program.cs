using System;
using Lab2_BankAccount;

namespace Lab2_StructType
{
    internal class Program
    {
        public struct BankAccount
        {
            public long accNo;
            public decimal accBal;
            public AccountType accType;
        }
        static void Main(string[] args)
        {
            BankAccount goldAccount;
            goldAccount.accNo = 1;
            goldAccount.accBal = 100;
            goldAccount.accType = AccountType.Deposit;
            Console.WriteLine(goldAccount.accNo);
            Console.WriteLine(goldAccount.accBal);
            Console.WriteLine(goldAccount.accType);
        }
    }
}