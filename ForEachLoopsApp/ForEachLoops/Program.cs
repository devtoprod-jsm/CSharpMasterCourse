namespace ForEachLoops;

class Program
{
    static void Main(string[] args)
    {
        string data = "Jaisrith,Yuktha,Nikitha,Vivek";

        List<string> firstNames = data.Split(',').ToList();

        foreach (string firstName in firstNames)
        {
            Console.WriteLine(firstName);
        }
        Console.ReadLine();
    }
}

