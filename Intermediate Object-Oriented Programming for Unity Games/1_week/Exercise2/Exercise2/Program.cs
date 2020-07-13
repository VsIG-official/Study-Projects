using System;
using System.Collections.Generic;
using System.IO;
using System.Linq.Expressions;

namespace Exercise2
{
    /// <summary>
    /// Exercise 2
    /// </summary>
    class Program
    {
        /// <summary>
        /// Main
        /// </summary>
        static void Main()
        {
            /*
			 My bad implementation
			because We need to close file every time,so list with all lines is better
			//reading
	        StreamReader input = null;
	        try
	        {
		        input = File.OpenText("SomeFile.txt");
		        string line = input.ReadLine();
		        while (line != null)
		        {
			        Console.WriteLine(line);
			        line = input.ReadLine();
		        }
	        }
	        catch (Exception e)
	        {
		        Console.WriteLine(e);
		        throw;
	        }
	        finally
	        {
		        input.Close();
			}

	        //creating new file
			StreamWriter output = null;
			try
			{
				output = File.CreateText("SomeOutputFile.txt");
				string line = input.ReadLine();
				int count = 0;
				while (line !=  null)
				{
					count++;
					Console.WriteLine("some");
					if (IsOdd(count))
					{
						Console.WriteLine(IsOdd(count));
						output.WriteLine(line);
						line = input.ReadLine();
					}
				}
			}
			catch (Exception e)
			{
				Console.WriteLine(e);
				throw;
			}
			finally
			{
				if (output != null)
				{
					output.Close();
				}
			}
			*/

            List<string> inputLines = new List<string>();

            // read from and echo the file
            StreamReader input = null;
            try
            {
	            input = File.OpenText("SomeFile.txt");

	            // read and echo lines until end of file
	            string line = input.ReadLine();
	            while (line != null)
	            {
		            inputLines.Add(line);
		            Console.WriteLine(line);
		            line = input.ReadLine();
	            }
            }
            catch (Exception e)
            {
	            Console.WriteLine(e.Message);
            }
            finally
            {
	            // always close input file
	            if (input != null)
	            {
		            input.Close();
	            }
            }

            // output even-numbered lines to output file
            StreamWriter output = null;
            try
            {
	            // create stream writer object
	            output = File.CreateText("evenNumbered.txt");

	            // write even-numbered lines to output file
	            for (int i = 1; i < inputLines.Count; i = i + 2)
	            {
		            output.WriteLine(inputLines[i]);
	            }
            }
            catch (Exception e)
            {
	            Console.WriteLine(e.Message);
            }
            finally
            {
	            // always close output file
	            if (output != null)
	            {
		            output.Close();
	            }
            }

            Console.ReadLine();
			Console.WriteLine();
        }

        public static bool IsOdd(int value)
        {
	        return value % 2 != 0;
        }
	}
}

