using System;

namespace Exercise4
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Enter altitude at first location: ");

			//this code creates new variable with a value of number of the user
			//its reads line and convert string number into int number
			int firstAltitude = int.Parse(Console.ReadLine());


			Console.Write("Enter altitude at second location: ");
			int secondAltitude = int.Parse(Console.ReadLine());

			//attitude change
			int altitudeChange = secondAltitude - firstAltitude;
			Console.Write("Attitude Change is " + altitudeChange);
		}
	}
}
