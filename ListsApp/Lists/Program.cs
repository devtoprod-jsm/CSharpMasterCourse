namespace Lists;

class Program
{
    static void Main(string[] args)
    {
        List<string> firstNames = new List<string>();

        firstNames.Add("Jaisrith");
        firstNames.Add("Yuktha");
        firstNames.Add("Nikitha");
        firstNames.Add("Vivek");

        Console.WriteLine(firstNames[firstNames.Count -1]);

        string data = "Tella,Guttikonda,Jagarlamudi";
        List<string> lastNames = data.Split(',').ToList();
        Console.WriteLine(lastNames[lastNames.Count -1]);
        Console.ReadLine();
    }
}

