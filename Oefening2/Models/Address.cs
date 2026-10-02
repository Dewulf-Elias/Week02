namespace Oefening2.Models;

public class Address
{
    public string Street { get; set; }
    public string Number { get; set; }
    public string PostalCode { get; set; }
    public string City { get; set; }

    public Address(string street, string number, string postalCode, string city)
    {
        Street = street;
        Number = number;
        PostalCode = postalCode;
        City = city;
    }

    public override string ToString()
    {
        return $"{Street} {Number}, {PostalCode} {City}";
    }
}
