using System;

namespace Exercise14
{
	class Program
	{
		static void Main()
		{
			Console.WriteLine("Enter Your birth month: ");
			string birthMonth = Console.ReadLine();

			Console.WriteLine("Enter Your birth day (int): ");
			int birthDay = int.Parse(Console.ReadLine());

			// print birthday
			Console.WriteLine();
			Console.WriteLine("Your birthday is " + birthMonth + " " + birthDay);

			// print reminder message
			Console.WriteLine("You'll receive a reminder on " + birthMonth + " " + (birthDay - 1));

			Console.Read();
		}
	}
}
