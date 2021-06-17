using System;

namespace FirstApp
{
	class Program
	{
		static void Main(string[] args)
		{
			var a = 1;
			var b = 2;
			var c = a + b;

			Console.WriteLine("1 + 2 = " + a + b);
			Console.WriteLine(c);

			Console.WriteLine();

			Console.WriteLine("Hello, World!");
			Console.WriteLine("What's Your name?");
			var Text = Console.ReadLine();
			Console.WriteLine("Hello, " + Text);
			Console.ReadLine();
		}
	}
}
