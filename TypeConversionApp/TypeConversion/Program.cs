namespace TypeConversion;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please enter your age: ");
        string? ageText = Console.ReadLine();

        //int age = int.Parse(ageText);

        bool isValidInt = int.TryParse(ageText, out int age);
        Console.WriteLine($"The value entered is valid int convertible? : {isValidInt} --- and it's value is {ageText} ");
        Console.ReadLine();
    }
}

