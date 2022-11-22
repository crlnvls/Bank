namespace Futureproof.BankProject;

public class Account
{
    //One method
    // public string BankNumber {get; private set;}
    // public decimal Balance {get; private set;}
    // public Person Owner {get; private set;}

    // Second method
    private readonly string _BankNumber;
    public decimal Balance;
    private readonly Person _Owner;

    public string BankNumber => _BankNumber;
    public Person Owner => _Owner;

    // Third method
    // private string BankNumber {get;}

    public Account(string BankNumber, decimal Balance, Person Owner)
    {
        _BankNumber = BankNumber;
        this.Balance = Balance;
        _Owner = Owner;

    }

    public Account(string BankNumber, Person Owner)
    {
        _BankNumber = BankNumber;
        _Owner = Owner;
        this.Balance = 0M;
    }

    public void AddFunds(decimal fundsToAdd)
    {
        this.Balance += fundsToAdd;
    }
}
