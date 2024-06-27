using Methods;

namespace Methods;

class Program
{
    static void Main(string[] args)
    {
        //DRY - Don't Repeat Yourself
        //SOLID Principles
        //SRP - Single Responsibility Principle

        string? name = ConsoleMessages.GetName();       
      
        ConsoleMessages.SayHi(name);
        ConsoleMessages.SayGoodBye();
        Math.Add(3, 5);

        double[] myNumbers = new double[] { 37, 6, 32 };

        Math.AddAll(myNumbers);

        // (string, string) fullName = ConsoleMessages.GetFullName();
        // (string firstName, _) = ConsoleMessages.GetFullName();
        // var (firstName, lastName) = ConsoleMessages.GetFullName();
        // (string firstName, string lastName) fullName = ConsoleMessages.GetFullName();
        //Discard character (_)
        (string firstName, string lastName) = ConsoleMessages.GetFullName();

        Console.WriteLine($"Hello {firstName} {lastName}");

        Console.ReadLine();
    }
}

