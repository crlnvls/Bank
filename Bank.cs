namespace Futureproof.BankProject;

public static class Bank
{
    public static List<Account> accounts = new List<Account>();

    public static void AddBankAccount(Account account)
    {
        accounts.Add(account);
    }
}

