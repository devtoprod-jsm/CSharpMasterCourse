using GuestBookLibrary.Models;

namespace ConsoleUI;

class Program
{
    private static List<GuestModel> guests = new List<GuestModel>();

    static void Main(string[] args)
    {
        GetGuestInformation();
        PrintGuestInformation();

        Console.ReadLine();
    }

    public static void GetGuestInformation()
    {
        string anyMoreGuests = "";
        //GuestModel guest = new GuestModel();

        do
        {
            GuestModel guest = new GuestModel();
            guest.FirstName = GetInfoFromConsole("What is your firstname? ");
            guest.LastName = GetInfoFromConsole("What is your lastname? ");
            guest.MessageToHost = GetInfoFromConsole("Could you please provide a message to the host. ");
            anyMoreGuests = GetInfoFromConsole("Are there any more guests coming (yes/no)? ");

            guests.Add(guest);
            Console.Clear();

        } while (anyMoreGuests.ToLower() == "yes");
    }

    public static void PrintGuestInformation()
    {
        foreach (GuestModel guest in guests)
        {
            Console.WriteLine(guest.GuestInfo);
        }
    }

    public static string GetInfoFromConsole(string message)
    {
        string output = "";
        Console.Write(message);
        output = Console.ReadLine();
        return output;
    }
}

