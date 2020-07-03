using System;

namespace IntegerDataTypes
{
	/// <summary>
	/// Integer data types lecture code
	/// </summary>
	class Program
	{
		/// <summary>
		/// demonstrates integer data types
		/// </summary>
		/// <param name="args"></param>
		static void Main(string[] args)
		{
			//byte is for 8 bits
			//short-16 bit
			//int-32bit
			//long-64bit
			int totalSecondsPlayed = 100;
			const int SecondsPerMinute = 60;

			// calculate minutes and seconds play
			int minutesPlayed = totalSecondsPlayed / SecondsPerMinute;
			int secondsPlayed = totalSecondsPlayed % SecondsPerMinute;

			//print results
			Console.WriteLine("Minutes played: " + minutesPlayed);
			Console.WriteLine("Seconds played: " + secondsPlayed);

			Console.WriteLine();
		}
	}
}
