namespace MiniProjectGuestBook;

class Program
{
    static void Main(string[] args)
    {
        string? guestLastName = GetGuestLastName();
        List<string> guestList = GetGuestList();
        ReadGuestList(guestList, guestLastName,guestList.Count);
        GreetUser(guestLastName);
        

        Console.ReadLine();
    }

    private static string? GetGuestLastName()
    {
        Console.WriteLine("Welcome to hotel Jai");
        Console.Write("May I know your last name: ");
        string? lastName = Console.ReadLine();
        return lastName;
    }

    private static List<string> GetGuestList()
    {
        

        string anyMoreGuests = "no";
        List<string> guestList = new List<string>();

        do
        {
            Console.Write("Are there anymore guests? ");
            anyMoreGuests = Console.ReadLine();
            if (anyMoreGuests.ToLower() == "yes")
            {
                Console.WriteLine("Could you please provide the guest names");
                guestList.Add(Console.ReadLine());
            }



        } while (anyMoreGuests.ToLower() == "yes");

        return guestList;
    }

    private static void GreetUser(string guestLastName)
    {
        Console.WriteLine($"Hi {guestLastName} and family. Welcome to hotel Jai");
        Console.WriteLine("Wish you a pleasant stay!");
    }

    private static void ReadGuestList(List<string> guestList, string guestLastName, int guestCount)
    {

        Console.WriteLine($"There are {guestCount + 1} guests including the host");
        Console.WriteLine($"Hi {guestLastName}. These are the members accompanying you");
       
        foreach (string guest in guestList)
        {
            Console.WriteLine(guest);
        }
    }


}

