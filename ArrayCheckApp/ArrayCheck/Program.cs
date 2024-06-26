namespace ArrayCheck;

class Program
{
    static void Main(string[] args)
    {
        int choice;
        bool isValid;
        string[] firstNames = new string[] { "Jaisrith", "Yuktha", "Nikitha", "Vivek" };
        do
        {
            Console.Write("Choose a number from 1 to 4: ");

            string? choiceText = Console.ReadLine();
            isValid = int.TryParse(choiceText, out choice);

            if (isValid == false || choice < 1 || choice > 4)
            {
                Console.WriteLine("Sorry input should be a valid number between 1 and 4 in digits");
            }
        } while (isValid == false ||  choice < 1 || choice > 4);


        Console.WriteLine($"Hi {firstNames[choice-1]}");
        Console.ReadLine();


    }
}

