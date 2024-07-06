using DemoLibrary.Models;
using DemoLibrary;
namespace ConsoleUI;

class Program
{
    static void Main(string[] args)
    {
        PersonModel person = new PersonModel();
        person.FirstName = "Jaisrith";
        person.LastName = "Tella";

        Console.WriteLine($"{person.FirstName} {person.LastName}");

        Console.WriteLine(Calculations.Add(9,2349));
        Console.ReadLine();
    }
}

