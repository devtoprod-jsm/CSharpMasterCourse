using System;
namespace Methods
{
	public static class Math
	{
		public static void Add(double x, double y)
		{
			Console.WriteLine($"The sum of {x} and {y} is {x+y}");
		}

		public static void AddAll(double[] numbers)
		{
			double total = 0;

			foreach (double number in numbers)
			{
				total += number;
			}
			Console.WriteLine($"The total is {total}");
		}
	}
}

