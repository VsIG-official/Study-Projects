using System;

namespace Exercise15
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("**********************");
			Console.WriteLine("Menu:");
			Console.WriteLine("1-NewGame");
			Console.WriteLine("2-LoadGame");
			Console.WriteLine("3-Options");
			Console.WriteLine("4-Quit");
			Console.WriteLine("**********************");
			int answer = int.Parse(Console.ReadLine());

			switch (answer)
			{
				case 1:
					Console.WriteLine("Starting new game...");
					break;
				case 2:
					Console.WriteLine("Loading Your game...");
					break;
				case 3:
					Console.WriteLine("Here's Your option menu...");
					break;
				case 4:
					Console.WriteLine("Quitting the game...");
					break;
				default:
					Console.WriteLine("Wrong button, dude");
					break;
			}
		}
	}
}
