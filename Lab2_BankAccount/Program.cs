﻿using System;

namespace Lab2_BankAccount
{
    public enum AccountType
    {
        Checking,
        Deposit
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            AccountType goldAccount;
            AccountType platinumAccount;
            goldAccount = AccountType.Checking;
            platinumAccount = AccountType.Deposit;
            Console.WriteLine(goldAccount);
            Console.WriteLine(platinumAccount);
        }
    }
}