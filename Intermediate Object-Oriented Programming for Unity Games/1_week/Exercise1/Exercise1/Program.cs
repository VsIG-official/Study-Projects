using System;

namespace Exercise1
{
	class Program
	{
		static void Main()
		{
			Console.WriteLine("Enter some int score");
			int score = int.Parse(Console.ReadLine());

			try
			{

			}
			catch (FormatException fe)
			{
				Console.WriteLine("Non-integer input");
				throw;
			}
			catch (OverflowException oe)
			{
				Console.WriteLine("integer is out of range");
				throw;
			}
			finally
			{
				Console.WriteLine("Oh shit,a rat!");
			}
		}
	}
}
