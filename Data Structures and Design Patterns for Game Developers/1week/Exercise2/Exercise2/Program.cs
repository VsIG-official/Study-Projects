using System;

namespace Exercise2
{
	/// <summary>
	/// Exercise 2 solution
	/// </summary>
	class Program
	{
		/// <summary>
		/// Uses ordered generic dynamic array
		/// </summary>
		static void Main()
		{
			Rectangle first = new Rectangle(1,1);
			Rectangle second = new Rectangle(2,1);
			Rectangle third = new Rectangle(3,1);
			Rectangle fourth = new Rectangle(4,1);

			OrderedDynamicArray<Rectangle> testArray =
				new OrderedDynamicArray<Rectangle>();

			testArray.Add(fourth);
			testArray.Add(first);
			testArray.Add(second);
			testArray.Add(third);

			testArray.Print();

			Console.ReadLine();
		}
	}
}
