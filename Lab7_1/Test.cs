using System;

public class Test
{
	public static void Main()
	{
		BankAccount b1 = new BankAccount();
		BankAccount b2 = new BankAccount();
		b1.Populate(100);
		b2.Populate(100);
		b1.TransferFrom(b2, 10);
        Console.WriteLine("Account number is {0}",  b1.Number());
        Console.WriteLine("Account balance is {0}", b1.Balance());
        Console.WriteLine("Account type is {0}", b1.Type());
        Console.WriteLine("Account number is {0}",  b2.Number());
        Console.WriteLine("Account balance is {0}", b2.Balance());
        Console.WriteLine("Account type is {0}", b2.Type());
	}
}
