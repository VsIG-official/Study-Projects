using System;

namespace FirstApp
{
	class Program
	{
		static void Main(string[] args)
		{
			// s = ut + 0.5att
			var u = 50;
			var aNew = -9.81;
			var t = 2;

			var s = u * t + 0.5 * aNew * t * t;

			Console.WriteLine(s);

			int a = 1;
			int b = 2;
			string c = "1 + 2 = " + (a + b);

			Console.WriteLine(c);

			Console.WriteLine();

			double dbl = 5.3333;
			bool isenabled = true;
			var unknown = 5;

			Console.WriteLine("Hello, World!");
			Console.WriteLine("What's Your name?");
			var Text = Console.ReadLine();
			Console.WriteLine("Hello, " + Text);
			Console.ReadLine();
		}
	}
}
