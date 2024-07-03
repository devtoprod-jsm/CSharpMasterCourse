namespace StaticClasses;

class Program
{
    static void Main(string[] args)
    {
        string firstName = RequestData.GetAString("What is your name? ");

        UserMessages.ApplicationStartMessage(firstName);


        double x = RequestData.GetDouble("Please give the first number: ");
        double y = RequestData.GetDouble("Please give the second number: ");

        double result = CalculateData.Add(x, y);
        UserMessages.PrintResultMessage($"The sum of {x} and {y} is {result}");
        Console.ReadLine();

    }
}

