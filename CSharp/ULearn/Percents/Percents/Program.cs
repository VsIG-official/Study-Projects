using System;

namespace Percents
{
    internal class Program
	{
		static void Main()
		{
            Console.WriteLine("Enter Money to put, percents and months:");
            string enterValues = Console.ReadLine();
            Console.WriteLine(Calculate(enterValues)); 
		}

        public static double Calculate(string userInput)
        {
            string[] subs = userInput.Split(' ');
            double money = double.Parse(subs[0]);
            double percent = double.Parse(subs[1]);
            double months = double.Parse(subs[2]);

            return money * Math.Pow(1 + (percent / (12 * 100)), months);
        }
    }
}
