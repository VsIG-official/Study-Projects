using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingAssignment1
{
    // Don't change ANY of the code in this file; if you
    // do, you'll break the automated grader!

    /// <summary>
    /// Programming Assignment 1
    /// </summary>
    class Program
    {
        // test case to run with given file name
        static int testCaseNumber;
        static string fileName;

        /// <summary>
        /// Tests the PersonalData class
        /// </summary>
        /// <param name="args">command-line args</param>
        static void Main(string[] args)
        {
            PersonalData personalData;

            // loop while there's more input
            string input = Console.ReadLine();
            while (input[0] != 'q')
            {
                // extract test case number and file name from string
                GetInputValuesFromString(input);

                // create PersonalData object
                personalData = new PersonalData(fileName);

                // execute selected test case
                switch (testCaseNumber)
                {
                    case 1:
                        if (string.IsNullOrEmpty(personalData.FirstName) &&
                            string.IsNullOrEmpty(personalData.MiddleName) &&
                            string.IsNullOrEmpty(personalData.LastName) &&
                            string.IsNullOrEmpty(personalData.StreetAddress) &&
                            string.IsNullOrEmpty(personalData.City) &&
                            string.IsNullOrEmpty(personalData.State) &&
                            string.IsNullOrEmpty(personalData.PostalCode) &&
                            string.IsNullOrEmpty(personalData.Country) &&
                            string.IsNullOrEmpty(personalData.PhoneNumber))
                        {
                            Console.WriteLine("Passed");
                        }
                        else
                        {
                            Console.WriteLine("FAILED");
                        }
                        break;
                    case 2:
                        if (personalData.FirstName == "John")
                        {
                            Console.WriteLine("Passed");
                        }
                        else
                        {
                            Console.WriteLine("FAILED");
                        }
                        break;
                    case 3:
                        if (personalData.MiddleName == "Quincy")
                        {
                            Console.WriteLine("Passed");
                        }
                        else
                        {
                            Console.WriteLine("FAILED");
                        }
                        break;
                    case 4:
                        if (personalData.LastName == "Public")
                        {
                            Console.WriteLine("Passed");
                        }
                        else
                        {
                            Console.WriteLine("FAILED");
                        }
                        break;
                    case 5:
                        if (personalData.StreetAddress == "123 Main Street")
                        {
                            Console.WriteLine("Passed");
                        }
                        else
                        {
                            Console.WriteLine("FAILED");
                        }
                        break;
                    case 6:
                        if (personalData.City == "Anytown")
                        {
                            Console.WriteLine("Passed");
                        }
                        else
                        {
                            Console.WriteLine("FAILED");
                        }
                        break;
                    case 7:
                        if (personalData.State== "Bliss")
                        {
                            Console.WriteLine("Passed");
                        }
                        else
                        {
                            Console.WriteLine("FAILED");
                        }
                        break;
                    case 8:
                        if (personalData.PostalCode == "54545")
                        {
                            Console.WriteLine("Passed");
                        }
                        else
                        {
                            Console.WriteLine("FAILED");
                        }
                        break;
                    case 9:
                        if (personalData.Country == "United States")
                        {
                            Console.WriteLine("Passed");
                        }
                        else
                        {
                            Console.WriteLine("FAILED");
                        }
                        break;
                    case 10:
                        if (personalData.PhoneNumber == "6175554321")
                        {
                            Console.WriteLine("Passed");
                        }
                        else
                        {
                            Console.WriteLine("FAILED");
                        }
                        break;
                }

                input = Console.ReadLine();
            }
        }

        /// <summary>
        /// Extracts the test case number and file name from the given input string
        /// </summary>
        /// <param name="input">input string</param>
        static void GetInputValuesFromString(string input)
        {
            int commaLocation = input.IndexOf(',');
            testCaseNumber = int.Parse(input.Substring(0, commaLocation));
            fileName = input.Substring(commaLocation + 1);
        }
    }
}
