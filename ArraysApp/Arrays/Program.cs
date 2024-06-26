namespace Arrays;

class Program
{
    static void Main(string[] args)
    {
        string[] firstNames = new string[4];
        firstNames[0] = "Yuktha";
        firstNames[1] = "Jaisrith";
        firstNames[2] = "Nikitha";
        firstNames[3] = "Vivek";

        string[] lastNames = new string[] { "Tella", "Nangineni", "Guttikonda", "Jagarlamudi" };
        Console.WriteLine(lastNames.Length);

        string stringFirstNames = "Jai,Yuktha,Nikki,Vivek";

        string[] splitNames = stringFirstNames.Split(',');

        Console.WriteLine(splitNames[2]);

        Console.ReadLine();
    }
}

