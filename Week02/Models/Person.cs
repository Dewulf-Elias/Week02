namespace Week02.Models;

public class Person
{
    public string Name { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public string Address { get; set; }   // straat, huisnummer, postcode, stad, land
    public string Email { get; set; }
    public string Phone { get; set; }
    public string Id { get; private set; }


    public Person(string name, string lastName, int age, string address, string email, string phone)
    {
        Name = name;
        LastName = lastName;
        Age = age;
        Address = address;
        Email = email;
        Phone = phone;
        Id = Guid.NewGuid().ToString();

    }

    public void PrintInfo()
    {
        Console.WriteLine("Person Information:");
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Last Name: {LastName}");
        Console.WriteLine($"Age: {Age}");
        Console.WriteLine($"Address: {Address}");
        Console.WriteLine($"Email: {Email}");
        Console.WriteLine($"Phone: {Phone}");
        Console.WriteLine($"Id: {Id}");
        Console.WriteLine();
    }
}
