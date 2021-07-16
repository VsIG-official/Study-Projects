using System;
using System.Text;

namespace PlayGround
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteTextWithBorder("Menu:");
            WriteTextWithBorder("");
            WriteTextWithBorder(" ");
            WriteTextWithBorder("Game Over!");
            WriteTextWithBorder("Select level:");
        }

        private static void WriteTextWithBorder(string text)
        {
            for (var i = 0; i < 3; i++)
            {
                if (i == 1)
                {
                    Console.WriteLine($"| {text} |");
                }
                else
                {
                    StringBuilder frame = new("++");
                    int stringLength = text.Length + 2;
                    for (var j = 0; j < stringLength; j++)
                    {
                        frame.Insert(1, "-");
                    }
                    Console.WriteLine(frame);
                }
            }
        }
    }
}
