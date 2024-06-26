namespace SwitchDemo;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your age? ");
        string? ageText = Console.ReadLine();

        bool validValue = int.TryParse(ageText, out int age);
        if (validValue)
        {
            switch (age)
            {
                case > 0 and < 18:
                    Console.WriteLine("You are young");
                    break;
                case >= 18 and <= 66:
                    Console.WriteLine("You are a working age person");
                    break;
                case > 66:
                    Console.WriteLine("You should be retired");
                    break;
                default:
                    Console.WriteLine("Sorry wrong entry");
                    break;
            }
        }
        else
        {
            Console.WriteLine("Sorry please enter digits");
        }
            Console.ReadLine();
    }

}

