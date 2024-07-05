namespace PropertyTypes;

class Program
{
    static void Main(string[] args)
    {
        PersonModel person = new PersonModel("Tella");

        person.FirstName = "Jaisrith";
        //person.LastName = "Tella";
        person.Age = 6;
        person.SSN = "123-45-6789";

        Console.WriteLine(person.SSN);
        Console.WriteLine(person.FullName);
        Console.ReadLine();
    }
}

