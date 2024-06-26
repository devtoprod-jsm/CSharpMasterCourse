namespace MiniProjectStudentCheck;

class Program
{
    static void Main(string[] args)
    {
        // Ask user for their name
        Console.Write("What is your first name? ");
        string? firstName = Console.ReadLine();
        //Ask user for their age
        Console.Write("What is your age? ");
        string? ageText = Console.ReadLine();
        bool validAge = int.TryParse(ageText, out int age);

        //Greet based on their name
        if (firstName.ToLower() == "tim" || firstName.ToLower() == "bob")
        {
            Console.WriteLine("Hello Professor");
        }
        else
        {
            Console.WriteLine($"Hello {firstName}");
            if (validAge)
            {
                if (age < 21)
                {
                    Console.WriteLine($"Please wait for {21 - age} year(s)");
                }
                else
                {
                    Console.WriteLine("Welcome to the class of 2024");
                }
            }
            else
            {
                Console.WriteLine("Please enter a valid age in digits");
            }

        }
        //If age less than 21 ask them to wait until they are 21

        Console.ReadLine();
    }
}

