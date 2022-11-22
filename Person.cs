namespace Futureproof.BankProject;

public class Person
{
    public string FirstName {get; set;}

    public string SecondName {get; set;}

    public Person(string FirstName, string SecondName)
    {
        this.FirstName = FirstName;
        this.SecondName = SecondName;
    }

    public string ToString()
    {
        return this.FirstName + " " + this.SecondName;
    }

}
