namespace AdvancedIf;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please enter your first name: ");
        string? firstName = null;
firstName = Console.ReadLine();
        Console.Write("Please enter your last name: ");
        string? lastName = "";
        lastName = Console.ReadLine();

        if ( (firstName.ToLower() == "jai" || firstName.ToLower() == "jaisrith" ) &&
            (lastName.ToLower() == "t" || lastName.ToLower() == "Tella") )
         {
            Console.WriteLine("Hi son of Mohan");
        }

        else if( firstName.ToLower() == "mohan" && lastName.ToLower() == "tella")
        {
            Console.WriteLine("Hi Jaisrith's father");
        }

        else
        {
            Console.WriteLine("Hi there!");
        }
        Console.ReadLine();
    }
}

