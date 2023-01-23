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

//Console.WriteLine(employee1);

Employee employee2 = new CommissionEmployee()
{
    Id = 2,
    FirstName = "Santa",
    LastName = "Antonio",

    IsActive = true,
    Sales = 15000M,
    CommissionPercentaje = 0.05F

};

//Console.WriteLine(employee2);

Employee employee3 = new HourlyEmployee()
{
    Id = 2,
    FirstName = "Natanael",
    LastName = "Peralta",

    IsActive = true,
    HourValue = 7500.55M,
    Hours = 95.05F

};

//Console.WriteLine(employee3);

Employee employee4 = new BaseCommissionEmployee()
{
    Id = 2,
    FirstName = "ARONYS",
    LastName = "REYES",

    IsActive = true,
 
    Base = 1950.5M,
    Sales = 35600m,
    CommissionPercentaje = 0.2F
};

//Console.WriteLine(employee4);

ICollection<Employee> employees = new List<Employee>()
{
    employee1, employee2, employee3, employee4
};

decimal payroll =0;

foreach (Employee employee in employees)
{
    Console.WriteLine(employee);
    payroll += employee.GetValueToPay();
}
 
Console.WriteLine("               ==============");
Console.WriteLine($"TOTAL         {$"{payroll:C2}", 15}");


Invoice invoice1 = new Invoice()
{
    Id = 1,
    Description = "IPHONE 13",
    Price = 30000M,
    Quantity = 2
};

Invoice invoice2 = new Invoice()
{
    Id = 2,
    Description = "PROCESADOR RAYCER 5 5000",
    Price = 9000M,
    Quantity = 2
};

Console.WriteLine(invoice1);
Console.WriteLine(invoice2);