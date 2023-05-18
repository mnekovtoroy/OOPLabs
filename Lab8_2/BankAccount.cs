using System.Collections;

class BankAccount 
{
    private static long nextAccNo = 123;
    private long accNo;
    private decimal accBal;
    private AccountType accType;
    private Queue tranQueue = new Queue();

    public BankAccount() {
	    accNo = NextNumber();
	    accBal = 0;
	    accType = AccountType.Checking;
    }

    public BankAccount(AccountType aType) {
	    accNo = NextNumber();
	    accBal = 0;
	    accType = aType;
    }

    public BankAccount(decimal aBal) {
	    accNo = NextNumber();
	    accBal = aBal;
	    accType = AccountType.Checking;
    }

    public BankAccount(AccountType aType, decimal aBal) {
	    accNo = NextNumber();
	    accBal = aBal;
	    accType = aType;
    }

    private static long NextNumber() { return nextAccNo++; }

    public decimal Deposit(decimal amount) {
	    accBal += amount;
	    tranQueue.Enqueue(new BankTransaction(amount));
	    return accBal;
    }

    public bool Withdraw(decimal amount) {
	    if (amount <= accBal) {
	    	tranQueue.Enqueue(new BankTransaction(amount));
	    	accBal -= amount;
		return true;
	    } else {
		return false;
	    }
    }

    public Queue Transactions() { return tranQueue; }

    public long Number() { return accNo; }
    public decimal Balance() { return accBal; }
    public string Type() { return accType.ToString(); }
}
