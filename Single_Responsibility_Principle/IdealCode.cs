using Single_Responsibility_Principle;
using System.Collections.Generic;

namespace Single_Responsibility_Principle_IdealCode;
public class Database
{
    public void Connect()
    {
        //...
        Console.WriteLine("Veritabanı bağlantısı sağlanmıştır.");
    }
    public void Disconnect()
    {
        //...
        Console.WriteLine("Veritabanı bağlantısı kesilmiştir.");
    }
    public string State { get; set; }
}

public class PersonService
{
    public List<Person> GetPersons()
    {
        List <Person> personList =  new() {
            new(){ Name = "Hilmi", Surname = "Celayir" },
            new(){ Name = "Mustafa", Surname = "Yıldız" },
            new(){ Name = "Cafer", Surname = "Muiddinoğlu" }
        };
        foreach (var person in personList)
        {
            Console.WriteLine($"Name: {person.Name}, Surname: {person.Surname}");
        }
        return personList;
    }
}