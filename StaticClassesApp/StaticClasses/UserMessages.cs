using System;
namespace StaticClasses
{
	public static class UserMessages
	{
		public static void ApplicationStartMessage(string firstName)
		{
			Console.Clear();
			Console.WriteLine("Welcome to the static classes app");

			int hourOfDay = DateTime.Now.Hour;

			if (hourOfDay < 12)
			{
				Console.WriteLine($"Good Morning {firstName} !");
			}

			else if (hourOfDay < 19)
			{
				Console.WriteLine($"Good afternoon {firstName} !");
			}

			else
			{
				Console.WriteLine($"Good evening {firstName} !");
			}
		}

		public static void PrintResultMessage(string message)
		{
			Console.WriteLine(message);
			Console.WriteLine();
			Console.WriteLine("Thank you for using the static classes app!!");
		}
	}
}

