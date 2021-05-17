using System;

namespace Exercise6
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Enter your angle: ");
			int angle = int.Parse(Console.ReadLine());
			float cosine = (float)Math.Cos(angle * Math.PI / 180);
			Console.WriteLine("Cosine of your angle: "+cosine);
			float sin = (float)Math.Sin(angle * Math.PI / 180);
			Console.WriteLine("Sin of your angle: " + sin);

			///////////////better code

			// prompt for and get angle
			Console.Write("Enter angle in degrees: ");
			float angleNew = float.Parse(Console.ReadLine());

			// calculate and print cosine and sine
			// the line of code below is shorthand for
			// angle = angle * Math.PI / 180;
			angleNew *= (float)Math.PI / 180;
			Console.WriteLine("Cosine: " + Math.Cos(angleNew));
			Console.WriteLine("Sine:   " + Math.Sin(angleNew));

			Console.WriteLine();
		}
	}
}
