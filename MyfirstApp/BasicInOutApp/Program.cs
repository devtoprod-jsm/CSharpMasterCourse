namespace BasicInOutApp;

class Program
{
    static void Main(string[] args)
    {
        // Welcome user to app

        Console.WriteLine("Welcome to my first application");

        // Ask user for first name

        Console.Write("What is your firstname? ");
        string firstName = Console.ReadLine();

        // Greet user by firstname

        Console.WriteLine($"Hello {firstName} , thanks for visiting my app!!");
        Console.ReadLine();
    }
}

