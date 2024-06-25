namespace BasicIf;

class Program
{
    static void Main(string[] args)
    {
        bool isComplete = false;

        if (isComplete)
        {
            Console.WriteLine("It is true");
        }
        else
        {
            Console.WriteLine("It is false");
        }

        Console.Write("Please enter your firstname: ");
        string? firstName = " ";
        firstName = Console.ReadLine();

        string? lastName;

        if (firstName.ToLower() == "jai")
        {
            Console.WriteLine("Hello Jaisrith");
            lastName = "Tella";
        }

        else
        {
            Console.WriteLine($"Hello {firstName}");
            lastName = "Sorry";
        }

        Console.WriteLine(lastName);
        Console.ReadLine();
    }
}

