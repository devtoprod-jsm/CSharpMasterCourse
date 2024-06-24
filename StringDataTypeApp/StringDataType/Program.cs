namespace StringDataType;

class Program
{
    static void Main(string[] args)
    {
        string firstName = string.Empty;
        string lastName = string.Empty;

        Console.Write("Please enter your firstname: ");
        firstName = Console.ReadLine();
        Console.Write("Pleae enter your last name: ");
        lastName = Console.ReadLine();

        Console.WriteLine(@$"The home folder for the user is C:\Users\{firstName}");
        Console.ReadLine();
    }
}

