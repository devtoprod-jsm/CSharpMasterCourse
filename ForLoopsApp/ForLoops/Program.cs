namespace ForLoops;

class Program
{
    static void Main(string[] args)
    {
        List<string> firstNames = new();

        firstNames.Add("Jaisrith");
        firstNames.Add("Yuktha");
        firstNames.Add("Nikitha");
        firstNames.Add("Vivek");
        for (int i = 0; i < firstNames.Count; i++)
        {
            Console.WriteLine(firstNames[i]);
        }
       
        Console.ReadLine();
    }
}

