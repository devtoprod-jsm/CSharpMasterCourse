using System;
namespace Methods
{
	public static class ConsoleMessages
	{
		public static void SayHi(string? firstName)
		{
			Console.WriteLine($"Hello {firstName}");
		}

		public static void SayGoodBye()
		{
			Console.WriteLine("Good bye user!");
			Console.WriteLine("Thanks for visiting.");
			Console.WriteLine("See you soon.");
		}

		public static string GetName()
		{
            Console.Write("Please enter your name: ");
            string? name = Console.ReadLine();
			return name;
        }

		public static (string firstName, string lastName) GetFullName()
		{
            Console.Write("Please enter your name: ");
            string? firstName = Console.ReadLine();
            Console.Write("Please enter your name: ");
            string? lastName = Console.ReadLine();

			return (firstName, lastName);
        }
	}
}

