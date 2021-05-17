using System;

namespace StringBasics
{
	/// <summary>
	/// String Basics lecture code
	/// </summary>
	class Program
    {
        /// <summary>
        /// Desmonstrates string basics
        /// </summary>
        static void Main()
        {
            // prompt for and read in gamertag
            Console.WriteLine("Enter gamertag: ");
            string gamertag = Console.ReadLine();

            // prompt for and read in high score
            Console.WriteLine("Enter high score as a whole number: ");
            int highScore = int.Parse(Console.ReadLine());

            // extract the first character of the gamertag
            char firsGamertagCharacter = gamertag[0];

            Console.WriteLine();
            // print out values
            Console.WriteLine("Gamertag: " + gamertag);
            Console.WriteLine("high score: " + highScore);
            Console.WriteLine("firs Gamertag Character: " +
                              firsGamertagCharacter);

            Console.WriteLine();
        }
    }
}

