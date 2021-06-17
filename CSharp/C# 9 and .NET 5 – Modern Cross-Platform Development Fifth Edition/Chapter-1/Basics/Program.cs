using System; // a semicolon indicates the end of a statement

// #error version

namespace Chapter_1
{ // an open brace indicates the start of a block
    class Program
    {
        static void Main(string[] args)
        {
            // sales tax must be added to the subtotal
            var totalPrice = subtotal + salesTax;

            /*
            This is a multi-line
            comment.
            */

            Console.WriteLine("Hello World!");  // a statement

            // outputs a carriage-return
            Console.WriteLine();
            // outputs the greeting and a carriage-return
            Console.WriteLine("Hello Ahmed");
            // outputs a formatted number and date and a carriage-return
            Console.WriteLine(
                "Temperature on {0:D} is {1}°C.", DateTime.Today, 23.4);
        }
    }
} // a close brace indicates the end of a block
