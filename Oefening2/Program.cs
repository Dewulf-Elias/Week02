using Oefening2.Models;

Person jane = new Person("Jane", "Smith", 25);
jane.Addresses.Add(new Address("Elm St", "456", "54321", "Sampletown"));
jane.Addresses.Add(new Address("Oak St", "789", "65432", "Anothercity"));
jane.EmailAddresses.Add("jane.smith@example.com");
jane.EmailAddresses.Add("j.smith@emailprovider.net");
jane.PhoneNumbers.Add("(987) 654-3210");
jane.PhoneNumbers.Add("(123) 456-7890");

Person lotte = new Person("Lotte", "Peeters", 22);
lotte.Addresses.Add(new Address("Kortrijksesteenweg", "15", "9000", "Gent"));
lotte.Addresses.Add(new Address("Stationsstraat", "3B", "8500", "Kortrijk"));
lotte.EmailAddresses.Add("lotte.peeters@example.be");
lotte.PhoneNumbers.Add("0471 23 45 67");
lotte.PhoneNumbers.Add("09 123 45 67");

jane.PrintInfo();
lotte.PrintInfo();
