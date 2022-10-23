// See https://aka.ms/new-console-template for more information
using ConceptsPOO;

Console.WriteLine("Concepts POO");
Console.WriteLine("------------");

try
{
	Console.WriteLine(new Date(2022, 10, 23));
	Console.WriteLine(new Date(2021, 9, 5));
	Console.WriteLine(new Date(1996, 11, 45));
}
catch (Exception error)
{

	Console.WriteLine(error.Message);
}