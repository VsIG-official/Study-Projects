using System;

namespace FirstApp
{
	class Program
	{
		static void Main(string[] args)
		{
			// s = ut + 0.5att
			var u = double.Parse(Console.ReadLine());
			var aNew = double.Parse(Console.ReadLine());
			var t = double.Parse(Console.ReadLine());

			var s = u * t + 0.5 * aNew * Math.Pow(t, 2);

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
