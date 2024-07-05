namespace IntantiatedClasses;

class Program
{
    static void Main(string[] args)
    {
        /*List<PersonModel> people = new List<PersonModel>();

        PersonModel person = new PersonModel();

        person.firstName = "Jaisrith";
        people.Add(person);
        Console.WriteLine(person.firstName);
        Console.WriteLine(person);

        person = new PersonModel();
        person.firstName = "Sindhu";
        people.Add(person);
        Console.WriteLine(person.firstName);
        Console.WriteLine(person);

        foreach (PersonModel p in people)
        {
            Console.WriteLine(p);
            Console.WriteLine(p.firstName);
        }*/

        List<PersonModel> people = new List<PersonModel>();

        string firstName = "";

        do
        {
            Console.WriteLine("Please enter your first name or else type exit to stop");
            firstName = Console.ReadLine();
            if (firstName.ToLower() != "exit")
            {
                PersonModel person = new PersonModel();
                person.FirstName = firstName;
                people.Add(person);
            }
        } while (firstName.ToLower() != "exit");

        foreach (PersonModel p in people)
        {
            Console.WriteLine(p.FirstName);
            ProcessPerson.GreetPerson(p);
        }

        foreach (PersonModel p in people)
        {
            Console.WriteLine(p.FirstName);
            Console.WriteLine(p.IsGreeted); ;
        }



        Console.ReadLine();
    }
}

