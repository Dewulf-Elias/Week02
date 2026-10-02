namespace Oefening2.Models;

public class Person
{
    public string Name { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public List<Address> Addresses { get; set; }
    public List<string> EmailAddresses { get; set; }
    public List<string> PhoneNumbers { get; set; }
    public string Id { get; private set; }

    public Person(string name, string lastName, int age)
    {
        Name = name;
        LastName = lastName;
        Age = age;
        Addresses = new List<Address>();        // lege lijsten, zodat Add(...) meteen werkt
        EmailAddresses = new List<string>();
        PhoneNumbers = new List<string>();
        Id = Guid.NewGuid().ToString();
    }

    public void PrintInfo()
    {
        Console.WriteLine("Person Information:");
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Last Name: {LastName}");
        Console.WriteLine($"Age: {Age}");

        Console.WriteLine("Addresses:");
        foreach (Address address in Addresses)
        {
            Console.WriteLine(address);
        }

        Console.WriteLine("Email Addresses:");
        foreach (string email in EmailAddresses)
        {
            Console.WriteLine(email);
        }

        Console.WriteLine("Phone Numbers:");
        foreach (string phone in PhoneNumbers)
        {
            Console.WriteLine(phone);
        }

        Console.WriteLine($"Id: {Id}");
        Console.WriteLine();
    }
}
