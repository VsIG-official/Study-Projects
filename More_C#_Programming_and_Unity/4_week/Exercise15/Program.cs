using System;

namespace Exercise15
{
	class Program
	{
		static void Main()
		{
			Console.WriteLine("enter <pyramid slot number>,<block letter>," +
			                  "<whether or not the block should be lit>");
			//15,M,true
			string input = Console.ReadLine();
			int comma = input.IndexOf(',');
			int number = int.Parse(input.Substring(0,comma));

			// extract and print block letter
			char blockLetter = input[comma + 1];
			Console.WriteLine("Block Letter: " + blockLetter);

			// extract and print whether or not the block should be lit
			string temp = input.Substring(comma + 1);
			comma = temp.IndexOf(',');
			bool lit = bool.Parse(temp.Substring(comma + 1));
			Console.WriteLine("Block should be lit: " + lit);

			Console.WriteLine(number + " " + blockLetter + " " + lit);

			Console.Read();
		}
	}
}
