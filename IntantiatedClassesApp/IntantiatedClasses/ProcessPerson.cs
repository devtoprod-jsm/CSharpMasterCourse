using System;
namespace IntantiatedClasses
{
	public class ProcessPerson
	{
		public static void GreetPerson(PersonModel person)
		{
			Console.WriteLine($"Hi {person.FirstName}");
			person.IsGreeted = true;
		}
	}
}

