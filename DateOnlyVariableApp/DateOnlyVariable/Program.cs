namespace DateOnlyVariable;

class Program
{
    static void Main(string[] args)
    {
        DateTime today = DateTime.Now;
        DateOnly birthday = DateOnly.Parse("09/20/2018");

        Console.WriteLine($"date in datetime : {today.Date}");
        Console.WriteLine($"date in dateonly : {birthday}");
        Console.WriteLine($"dateonly formatting : {birthday.ToString("MMMM dd, yyyy")}");
        Console.ReadLine();
    }
}

