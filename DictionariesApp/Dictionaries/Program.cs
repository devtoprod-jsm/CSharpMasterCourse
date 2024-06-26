namespace Dictionaries;

class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, string> lookup = new Dictionary<string, string>();

        lookup["fish"] = "Not human that swims";
        lookup["human"] = "Us";
        lookup["bird"] = "Not human that flies";

        Console.WriteLine($"The meaning of bird is {lookup["bird"]}");
        Console.ReadLine();
    }
}

