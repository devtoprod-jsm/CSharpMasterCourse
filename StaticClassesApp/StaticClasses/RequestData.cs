using System;
namespace StaticClasses
{
	public static class RequestData
	{
		public static double GetDouble(string message)
		{
			Console.Write(message);
			string doubleText = Console.ReadLine();
			double output;

			bool isDouble = double.TryParse(doubleText, out output);

			while( isDouble == false)
			{
				Console.WriteLine("Sorry that's not a valid number");
                Console.Write(message);
                doubleText = Console.ReadLine();
				isDouble = double.TryParse(doubleText, out output);
			}

			return output;
		}

		public static string GetAString(string message)
		{
			Console.Write(message);
			string output = Console.ReadLine();
			return output;
		}
	}
}

