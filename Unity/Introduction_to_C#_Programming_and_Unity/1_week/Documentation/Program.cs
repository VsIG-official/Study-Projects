using System;

namespace Documentation
{
	class Program
	{
		static void Main(string[] args)
		{
			//should use f in the end,because its value=double and we cant put double into float,because its smaller
			//if something is STATIC,than we will use"SOMETHING.SOMETHING ELSE" because its returns something
			//use math.pi/180 because our value is in radian
			float cosine = (float)Math.Cos(45 * Math.PI / 180);
			Console.WriteLine("Cosine of 45 degrees is " + cosine);
			Console.WriteLine();
		}
	}
}
