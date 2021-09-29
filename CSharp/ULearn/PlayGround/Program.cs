using System;
using System.Collections.Generic;
using System.Text;

namespace PlayGround
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] array = new double[3];
            
        }
        private static string DecodeMessage(string[] lines)
        {
            List<string> decodedMessage = new List<string>();

            for (var i = 0; i < lines.Length; i++)
            {
                var currentLine = lines[i].ToString();

                for (var j = 0; j < lines.Length; j++)
                {
                    decodedMessage.Add(currentLine.Split(' ')[j]);
                }
            }
            //decodedMessage = lines.Split(' ');

            return "no";
        }
    }
}
