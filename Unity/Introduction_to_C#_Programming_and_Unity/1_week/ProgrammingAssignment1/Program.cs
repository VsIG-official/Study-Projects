using System;

namespace ProgrammingAssignment1
{
	/// <summary>
	/// Main class for this program
	/// </summary>
	class Program
	{
		/// <summary>
		/// calculates distance between two points
		/// </summary>
		/// <param name="args"></param>
		static void Main(string[] args)
		{
			
			Console.WriteLine("Welcome, My dear friend! this application will calculate the " +
				"distance between two points and the angle between those points.");

			Console.WriteLine("Now, I want " +
				"You to enter coordinates for first point. So, what will it be on X coordinate?");
			float firstPointX = float.Parse(Console.ReadLine());

			Console.WriteLine("And on Y?");
			float firstPointY = float.Parse(Console.ReadLine());

			Console.WriteLine("OK,now We need second point. what will it be on X coordinate?");
			float secondPointX = float.Parse(Console.ReadLine());

			Console.WriteLine("And on Y?");
			float secondPointY = float.Parse(Console.ReadLine());

			float deltaX = secondPointX - firstPointX;
			float deltaY = secondPointY - firstPointY;

			Console.WriteLine("Hey, have a look at deltas: delta on X = " + deltaX + " and delta on Y = " + deltaY);

			double distance = Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
			Console.WriteLine("Hey! I found it! The distance between two points is " + distance);
			//or we can try something like this with less numbers after dot
			float distanceAnotherWay = (float)Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
			Console.WriteLine("Hey! I know another way to do it! Another distance between two points is " + distanceAnotherWay);

			double angle = Math.Atan2(deltaY, deltaX) * (180 / Math.PI);
			Console.WriteLine("And finally... The Angle is " + angle);

			Console.WriteLine("Congratulation! Thanks for reviewing My work) Have a good day!");
		}
	}
}