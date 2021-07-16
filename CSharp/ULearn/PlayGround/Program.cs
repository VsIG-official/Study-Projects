using System;
using System.Text;

namespace PlayGround
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteBoard(8);
            WriteBoard(1);
            WriteBoard(2);
            WriteBoard(3);
            WriteBoard(10);
        }

        private static void WriteBoard(int size)
        {
            string[] symbols = { "#", "." };

            for (var i = 0; i < size; i++)
            {
                for (var j = 0; j < size; j++)
                {
                    int counter = (i + j) % 2;
                    Console.Write(symbols[counter]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
