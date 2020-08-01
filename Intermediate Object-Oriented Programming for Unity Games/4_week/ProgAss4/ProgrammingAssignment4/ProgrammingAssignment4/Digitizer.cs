using System.Collections.Generic;

namespace ProgrammingAssignment4
{
	/// <summary>
	/// Converts words to digits
	/// </summary>
	public class Digitizer
	{
		#region Fields

		// declare your Dictionary field and create the Dictionary object for it here
		private Dictionary<string, int> list;

		#endregion

		#region Constructor

		/// <summary>
		/// Constructor
		/// </summary>
		public Digitizer()
		{
			// populate your dictionary field here
			list = new Dictionary<string, int>();
			list.Add("zero", 0);
			list.Add("one", 1);
			list.Add("two", 2);
			list.Add("three", 3);
			list.Add("four", 4);
			list.Add("five", 5);
			list.Add("six", 6);
			list.Add("seven", 7);
			list.Add("eight", 8);
			list.Add("nine", 9);
		}

		#endregion

		#region Public methods

		/// <summary>
		/// Converts the given word to the corresponding digit.
		/// If the word isn't a valid digit name, returns -1
		/// </summary>
		/// <param name="word">word to convert</param>
		/// <returns>corresponding digit or -1</returns>
		public int ConvertWordToDigit(string word)
		{
			// delete the code below and add your code
			string newWord = word.ToLower();
			if (list.ContainsKey(newWord))
			{
				return list[newWord];
			}
			else
			{
				return -1;
			}
		}

		#endregion
	}
}
