using System;

namespace PlayGround
{
	class Program
	{
		static void Main(string[] args)
		{
            Console.WriteLine(MiddleOf(5, 0, 100)); // => 5
            Console.WriteLine(MiddleOf(12, 12, 11)); // => 12
            Console.WriteLine(MiddleOf(1, 1, 1)); // => 1
            Console.WriteLine(MiddleOf(2, 3, 2));
            Console.WriteLine(MiddleOf(8, 8, 8));
            Console.WriteLine(MiddleOf(5, 0, 1));

            //TestMove("a1", "d4");
            //TestMove("f4", "e7");
            //TestMove("a1", "a4");
        }

        public static int MiddleOf(int a, int b, int c)
        {
            int[] numbers = { a, b, c };
            Array.Sort(numbers);
            return numbers[1];
        }

        //public static void TestMove(string from, string to)
        //{
        //    Console.WriteLine("{0}-{1} {2}", from, to, IsCorrectMove(from, to));
        //}

        //public static bool IsCorrectMove(string from, string to)
        //{
        //    int dx = Math.Abs(to[0] - from[0]); //смещение фигуры по горизонтали
        //    int dy = Math.Abs(to[1] - from[1]); //смещение фигуры по вертикали

        //    return (dx == dy && dy > 0 && dx > 0) || (dx == 0 && dy > 0) || (dy == 0 && dx > 0);
        //}
    }
}
