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
            var bar = "+" + new string('-', text.Length + 2) + "+";
            Console.WriteLine(bar);
            Console.WriteLine("| {0} |", text);
            Console.WriteLine(bar);
        }
    }
}
