using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_3
{
	class Program
	{
		static void Main(string[] args)
		{
			List<int> numbers = new List<int>();
			//problem 1
			for (int i = 1; i <= 10; i++)
			{
				numbers.Add(i);
			}

			for (int i = 0; i <= numbers.Count; i++)
			{
				Console.WriteLine(numbers[i]);
			}

			//problem 2
			for (int i = numbers.Count-1; i >= 0; i--)
			{
				if (numbers[i] % 2 == 0)
				{
					numbers.RemoveAt(i);
				}
			}
			// print list
			for (int i = 0; i < numbers.Count; i++)
			{
				Console.WriteLine(numbers[i]);
			}
			Console.WriteLine();
			//problem 3
			//List<int> newList = new List<int>();

			// bad removal
			numbers.Clear();
			for (int i = 1; i <= 5; i++)
			{
				numbers.Add(i);
			}
			for (int i = 0; i < numbers.Count; i++)
			{
				if (numbers[i] == 1 ||
					numbers[i] == 2 ||
					numbers[i] == 3)
				{
					numbers.RemoveAt(i);
				}
			}

			for (int i = 0; i < numbers.Count; i++)
			{
				Console.WriteLine(numbers[i]);
			}
		}
	}
}
