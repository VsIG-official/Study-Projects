using System;

namespace Exceptions
{
    /// <summary>
    /// Exceptions lectures code
    /// </summary>
    class Program
    {
        /// <summary>
        /// Demonstrates exceptions and exception handling
        /// </summary>
        static void Main()
        {
	        try
	        {
		        // prompt for and get a short
		        Console.Write("Enter a whole number (-32,768 to 32,767): ");
		        short input = short.Parse(Console.ReadLine());
	        }
	        catch (FormatException fe)
	        {
		        Console.WriteLine("Not a whole number");
		        throw;
	        }
	        catch (OverflowException oe)
	        {
		        Console.WriteLine("that number is out of range");
		        throw;
	        }
	        finally
	        {
				Console.WriteLine("All done");
	        }

	        Console.WriteLine();
        }
    }
}
