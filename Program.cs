using Futureproof.BankProject;

// Create a Person
Person pete = new Person("Pete", "Ohare");
Person lucy = new Person("Lucy", "Norman");
// Create an Account 
Account a1 = new Account("A1", 100M, pete);
Account a2 = new Account("A2", lucy);
// Add the Account to the Bank
// Bank TomWest = new Bank();
// TomWest.AddBankAccount(a1);
Bank.AddBankAccount(a1);
Bank.AddBankAccount(a2);
Console.WriteLine(a1.Balance);
a1.AddFunds(34M);
Console.WriteLine(a1.Balance);


Console.WriteLine(pete.ToString());

