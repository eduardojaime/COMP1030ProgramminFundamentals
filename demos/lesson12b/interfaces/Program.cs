﻿namespace interfaces;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, Interfaces!");
        // Contact Management System
        // We have different types of contacts which will be defined in their own classes
        // Classes typically map to database entities
        // First step in design is defining interfaces
        // Interfaces map to requirements
        // Req 1 > all contacts must show their information
        // Req 2 > contacts with email addresses must be able to receive emails from system
        Person myPerson = new Person();
        myPerson.FirstName = "Edward";
        myPerson.LastName = "James";
        myPerson.PhoneNumber = "(647) 123 4455";
        myPerson.EmailAddress = "ed@georgian.ca";
        Console.WriteLine(myPerson.ShowContactInfo());
        // New Req 3 > now we need to handle companies which have different attributes
        Company myCompany = new Company();
        myCompany.CompanyName = "Programmers Inc";
        myCompany.DirectorEmailAddress = "ceo@programmers.com";
        myCompany.DirectorName = "James Edwards";
        myCompany.PhoneNumber = "(647) 123 4455";
        Console.WriteLine(myCompany.ShowContactInfo());
        // calling a method that takes an object that implements the interface as parameter
        SendExternalEmail(myPerson);
        SendExternalEmail(myCompany); // both classes implement IEmailable so these are accepted
    }
    public static void SendExternalEmail(IEmailable contact) // (Person person, Company company)
    {
        // in first approach you'd have todetermine which one is not null and send email with that
        // simpler approach with interfaces:
        contact.SendEmail();
    }
}
