namespace DoAndWhileLoops;

class Program
{
    static void Main(string[] args)
    {
        bool isValidAge;
        int age;

        do
        {
            Console.Write("Please enter your age: ");
            string? ageText = Console.ReadLine();
            isValidAge = int.TryParse(ageText, out age);

            if (isValidAge == false)
            {
                Console.WriteLine("Sorry please enter age in digits");
            }
        } while (isValidAge == false);

        Console.WriteLine($"Hi you are {age}");

        int myNumber = 0;
        do
        {
            Console.WriteLine($"It's {myNumber}");
            myNumber += 3;
        } while (myNumber < 100);
        Console.ReadLine();
    }
}

