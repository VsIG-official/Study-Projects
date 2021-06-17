using System;

namespace FirstApp
{
	class Program
	{
		static void Main(string[] args)
		{
			//DateTime dt = DateTime.Parse("2021 june 17");

			//var dayofweek = dt.DayOfWeek;

			//Console.WriteLine(dayofweek);

			//var timeinfuture = dt.AddDays(6);

			//Console.WriteLine(timeinfuture);

			//var dt1 = DateTime.Parse("2021 june 17");

			//Console.WriteLine(AddDays(dt1, 3));
			//Console.WriteLine(AddDays(dt1, 8));

			//var dt1 = DateTime.Parse("2021 june 17");
			//DateTime dtf1, dtf2;

			//NewAddDays(dt1, out dtf1, out dtf2);
			//Console.WriteLine(dtf1);
			//Console.WriteLine(dtf2);

			var dt1 = DateTime.Parse(args[0]);

			var fds = AddDays(dt1);
			Console.WriteLine(fds.oneWeek);
			Console.WriteLine(fds.twoWeeks);

			/*
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
			*/

			Console.ReadLine();
		}

		public struct FutureDates
		{
			public DateTime oneWeek;
			public DateTime twoWeeks;
		}

		static private DateTime AddDays(DateTime dateTime, int numOfDays)
		{
			var timeinfuture = dateTime.AddDays(numOfDays);

			return timeinfuture;
		}

		static private void AddDays(DateTime dateTime, out DateTime oneWeek, out DateTime twoWeeks)
		{
			oneWeek = dateTime.AddDays(7);
			twoWeeks = dateTime.AddDays(14);
		}

		static private FutureDates AddDays(DateTime dateTime)
		{
			FutureDates fd;
			fd.oneWeek = dateTime.AddDays(7);
			fd.twoWeeks = dateTime.AddDays(14);

			return fd;
		}
	}
}
