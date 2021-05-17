using System;

namespace IfStatements
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Pick up shiny thing?(1 for yes,2 for no)");
			int answer = int.Parse(Console.ReadLine());

			switch (answer)
			{
				case 1:
					Console.WriteLine("Oh no,it`s razor!<-2 hp>");
					break;

				case 2: Console.WriteLine("Oh ,that was a razor!");
					break;

				default:
					Console.WriteLine("No,there's no easter egg");
					break;
			}


			//if (answer==1)
			//{
			//	Console.WriteLine("Oh no,it`s razor!<-2 hp>");
			//}
			//else if(answer == 2)
			//{
			//	Console.WriteLine("Oh ,that was a razor!");
			//}
			//else
			//{
			//	Console.WriteLine("No,there's no easter egg");
			//}


		}
	}
}
