
using System;

class CreateAccount
{
    static void Main()
    {
        BankAccount acc1 = new BankAccount();
        BankAccount acc2 = new BankAccount(AccountType.Deposit);
        BankAccount acc3 = new BankAccount(100);
        BankAccount acc4 = new BankAccount(AccountType.Deposit, 500);

        acc1.Deposit(10);
	    acc1.Withdraw(5);

	    acc2.Deposit(10);
	    acc2.Withdraw(5);

	    acc3.Deposit(10);
	    acc3.Withdraw(5);

	    acc4.Deposit(10);
	    acc4.Withdraw(5);

	    Write(acc1);
	    Write(acc2);
	    Write(acc3);
	    Write(acc4);
    }

    public static void TestDeposit(BankAccount acc) {
	    Console.Write("Enter amount to deposit: ");
	    decimal amount = decimal.Parse(Console.ReadLine());
	    acc.Deposit(amount);
    }

    public static void TestWithdraw(BankAccount acc) {
	    Console.Write("Enter amount to withdraw: ");
	    decimal amount = decimal.Parse(Console.ReadLine());
	    acc.Withdraw(amount);
    }
    
    static void Write(BankAccount toWrite)
    {
        Console.WriteLine("Account number is {0}",  toWrite.Number());
        Console.WriteLine("Account balance is {0}", toWrite.Balance());
        Console.WriteLine("Account type is {0}", toWrite.Type());
	foreach (BankTransaction t in toWrite.Transactions()) {
		Console.WriteLine("{0} {1}", t.Amount(), t.When());
	}
    }
}
