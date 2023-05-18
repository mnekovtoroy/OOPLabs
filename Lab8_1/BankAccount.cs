class BankAccount 
{
    private static long nextAccNo = 123;
    private long accNo;
    private decimal accBal;
    private AccountType accType;

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
	    return accBal;
    }

    public bool Withdraw(decimal amount) {
	    if (amount <= accBal) {
	    	accBal -= amount;
		return true;
	    } else {
		return false;
	    }
    }

    public long Number() { return accNo; }
    public decimal Balance() { return accBal; }
    public string Type() { return accType.ToString(); }
}
