// See https://aka.ms/new-console-template for more information
using Gun15_Interface;

Console.WriteLine("Hello, World!");

Person p = new Person()
{
    PersonId = 1,
    Name = "Ahmet",
    Surname = "Demir"
};

DbOperation db = new DbOperation();
db.AddToDb(p);
