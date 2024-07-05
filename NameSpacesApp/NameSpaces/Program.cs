namespace NameSpaces;
using NameSpaces.Calculator;

class Program
{
    static void Main(string[] args)
    {
        Calculations.Add(4.7, 66.5);

        NameSpaces.Models.PersonModel person = new NameSpaces.Models.PersonModel();

        Console.ReadLine();
    }
}

