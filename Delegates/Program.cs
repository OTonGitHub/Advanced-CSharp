// Program.cs not in a namespace
using MainNameSpace;
using CLibrary;

Console.Write("Enter FirstName: ");
var firstName = Console.ReadLine();
Console.Write("Enter LastName: ");
var lastName = Console.ReadLine();

var person = new PersonModel(firstName, lastName, "123 Main St", "Atlanta");
Console.WriteLine($"{person.FirstName} {person.LastName} lives at {person.Address} in {person.City}.");






var anotherPeson = new AnotherPersonModel(firstName, lastName, "123 Main St", "Atlanta");
Console.WriteLine($"{anotherPeson.Name} lives at {anotherPeson.Address} in {anotherPeson.City}.");


Console.ReadKey();