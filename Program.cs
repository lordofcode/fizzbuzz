using System;

namespace FizzBuzz
{
	class Program
	{
		static void Main(string[] args)
		{
			for (int k=1; k <= 100; k++)
			{
				Console.WriteLine(k.ToString());
				if (k % 3 == 0)
				{
					Console.Write("Fizz{0}", (k % 5 != 0 ? "\r\n" : ""));
				}
				if (k % 5 == 0)
				{
					Console.WriteLine("Buzz");
				}
			}
			Console.ReadKey();
		}
	}
}
