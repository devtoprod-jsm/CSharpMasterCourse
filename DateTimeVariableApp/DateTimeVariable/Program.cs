using System.Globalization;

namespace DateTimeVariable;

class Program
{
    static void Main(string[] args)
    {
        DateTime today = DateTime.Now;
        Console.WriteLine($"today: {today}");
        DateTime todayUtc = DateTime.UtcNow;
        Console.WriteLine($"todayUtc: {todayUtc}");
        DateTime birthday = DateTime.Parse("9/20/2018");
        Console.WriteLine($"birthday: {birthday}");
        DateTime birthdayExact = DateTime.ParseExact("20/9/2018", "d/M/yyyy", CultureInfo.InvariantCulture);
        Console.WriteLine($"birthdayExact: {birthdayExact.ToString("MMMM dd, yyyy tt zzz")}");
        Console.ReadLine();

    }
}

