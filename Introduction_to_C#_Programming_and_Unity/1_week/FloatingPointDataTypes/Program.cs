using System;

namespace FloatingPointDataTypes
{
	class Program
	{
		static void Main(string[] args)
		{
			//float-x
			//double-2flooat
			int score = 1360;
			int totalSecondsPlayed = 10000;

			//in this situation / will do integer division
			//we can change one of a int to float,but thats not a good solution
			//we can make one of them treated as a float and for this we use typecast "(float)"
			//and its automatically change another to a float and now it will do float division
			//we should not do something like this (float)(score / totalSecondsPlayed)
			//because firstly it will divide and then convert to a float
			float pointsPerSecond = (float)score / totalSecondsPlayed;
			Console.WriteLine("Points per seconds: " + pointsPerSecond);

			Console.WriteLine();
		}
	}
}
