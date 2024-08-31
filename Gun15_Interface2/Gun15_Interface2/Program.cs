// See https://aka.ms/new-console-template for more information
using Gun15_Interface2;

Console.WriteLine("Hello, World!");

Employee e = new Employee()
{
    Name = "Ahmet",
    Branch = "Lara",
    PersonalNumber = "1112",
    PersonId = 1,
    Surname = "Demir"
};

SalaryOperation operation = new SalaryOperation();
operation.CalculateSalary(e);
