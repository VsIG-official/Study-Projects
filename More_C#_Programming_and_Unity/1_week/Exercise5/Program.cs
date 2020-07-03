using System;

namespace Exercise5
{
	class Program
	{

		static void Main(string[] args)
		{
			int choice = 0;
			while (choice != 4)
			{
				Console.WriteLine("***********");
				Console.WriteLine("Menu:");
				Console.WriteLine("1 - NewGame");
				Console.WriteLine("2 - LoadGame");
				Console.WriteLine("3 - Options");
				Console.WriteLine("4 - Quit");
				Console.WriteLine("***********");
				Console.WriteLine();
				Console.Write("Enter your choice (1, 2, 3 or 4): ");
				choice = int.Parse(Console.ReadLine());

				/*while (choice < 1 || choice > 4)
				{
					Console.WriteLine("Choice must be 1, 2, 3, or 4!");
					Console.Write("Enter your choice (1, 2, 3 or 4): ");
					choice = int.Parse(Console.ReadLine());
					Console.WriteLine();
				}

				if (choice == 1)
				{
					Console.WriteLine("Creating new game ...");
				}
				else if (choice == 2)
				{
					Console.WriteLine("Loading game ...");
				}
				else if (choice == 3)
				{
					Console.WriteLine("Setting options ...");
				}
				Console.WriteLine();
				*/

				if (choice == 1)
				{
					Console.WriteLine("Creating new game ...");
				}
				else if (choice == 2)
				{
					Console.WriteLine("Loading game ...");
				}
				else if (choice == 3)
				{
					Console.WriteLine("Setting options ...");
				}
				else if (choice < 1 ||
					choice > 4)
				{
					Console.WriteLine("Choice must be 1, 2, 3, or 4!");
				}
				Console.WriteLine();
			}
		}
	}
}
