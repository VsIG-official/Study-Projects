using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhyWeStartAtZero
{
    /// <summary>
    /// Why We Start Indexing at Zero code
    /// </summary>
    class Program
    {
        /// <summary>
        /// Demonstrates why we start indexing at zero
        /// </summary>
        /// <param name="args">command-line arguments</param>
        static void Main(string[] args)
        {
            int[] scores = { 100, 95, 90, 85, 80 };

            // output array information
            // ugly unsafe access to address of array element
            // note use of unsafe block and compiled with unsafe code allowed
            unsafe
            {
				//every address is bigger than another on 4 bytes
				//we get first position of an datatype and further we can just add some specific number to first position to know address of an 
				//object
				//if we want 3-d element of an array 3(address)*4(bytes of an int)=12=>{position of 0 object}+12={position of 3 object}
                fixed (int* elementAddress = &scores[0])
                {
                    Console.WriteLine("scores[{0}] Address: {1} Contents: {2}\n", 0, (int)elementAddress, scores[0]);
                }
                fixed (int* elementAddress = &scores[1])
                {
                    Console.WriteLine("scores[{0}] Address: {1} Contents: {2}\n", 1, (int)elementAddress, scores[1]);
                }
                fixed (int* elementAddress = &scores[2])
                {
                    Console.WriteLine("scores[{0}] Address: {1} Contents: {2}\n", 2, (int)elementAddress, scores[2]);
                }
                fixed (int* elementAddress = &scores[3])
                {
                    Console.WriteLine("scores[{0}] Address: {1} Contents: {2}\n", 3, (int)elementAddress, scores[3]);
                }
                fixed (int* elementAddress = &scores[4])
                {
                    Console.WriteLine("scores[{0}] Address: {1} Contents: {2}\n", 4, (int)elementAddress, scores[4]);
                }
            }
        }
    }
}
