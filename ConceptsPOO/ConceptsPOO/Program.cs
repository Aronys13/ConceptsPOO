// See https://aka.ms/new-console-template for more information
using ConceptsPOO;

Console.WriteLine("Concepts POO");
Console.WriteLine("------------");

Employee employee1 = new SalaryEmployee()
{
    Id = 1,
    FirstName = "Aronys",
    LastName = "Antonio",
 
    IsActive = true,
    Salary = 1500
};

Console.WriteLine(employee1);

Employee employee2 = new CommissionEmployee()
{
    Id = 2,
    FirstName = "Santa",
    LastName = "Antonio",

    IsActive = true,
    Sales = 15000M,
    CommissionPercentaje = 0.05F

};

Console.WriteLine(employee2);