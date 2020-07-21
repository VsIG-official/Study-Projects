using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingAssignment2
{
    // Remove the /* and */ as indicated below to make this
    // work with the automated grader
    // the code is commented out so the project compiles

    /// <summary>
    /// Programming Assignment 2
    /// </summary>
    class Program
    {
        // test case to run
        static int testCaseNumber;

        /// <summary>
        /// Tests the MutualFund and EmployerSponsoredAccount classes
        /// </summary>
        /// <param name="args">command-line args</param>
        static void Main(string[] args)
        {
            InvestmentAccount account; ;

            // loop while there's more input
            string input = Console.ReadLine();
            while (input[0] != 'q')
            {
                // extract test case number from string
                GetInputValueFromString(input);

                // execute selected test case
                switch (testCaseNumber)
                {
                    case 1:
                        account = new MutualFund(100);
                        if (WithinOnePenny(account.Balance, 100))
                        {
                            Console.WriteLine("Passed");
                        }
                        else
                        {
                            Console.WriteLine("FAILED");
                        }
                        break;
                    case 2:
                        account = new MutualFund(100);
                        account.AddMoney(100);
                        if (WithinOnePenny(account.Balance, 199))
                        {
                            Console.WriteLine("Passed");
                        }
                        else
                        {
                            Console.WriteLine("FAILED");
                        }
                        break;
                    case 3:
                        account = new MutualFund(100);
                        account.UpdateBalance();
                        if (WithinOnePenny(account.Balance, 106))
                        {
                            Console.WriteLine("Passed");
                        }
                        else
                        {
                            Console.WriteLine("FAILED");
                        }
                        break;

                    case 4:
                        account = new EmployerSponsoredAccount(100);
                        if (WithinOnePenny(account.Balance, 100))
                        {
                            Console.WriteLine("Passed");
                        }
                        else
                        {
                            Console.WriteLine("FAILED");
                        }
                        break;
                    case 5:
                          account = new EmployerSponsoredAccount(100);
                          account.AddMoney(100);
                          if (WithinOnePenny(account.Balance, 298))
                          {
                              Console.WriteLine("Passed");
                          }
                          else
                          {
                              Console.WriteLine("FAILED");
                          }
                          break;
                      case 6:
                          account = new EmployerSponsoredAccount(100);
                          account.UpdateBalance();
                          if (WithinOnePenny(account.Balance, 106))
                          {
                              Console.WriteLine("Passed");
                          }
                          else
                          {
                              Console.WriteLine("FAILED");
                          }
                          break;
                      case 7:
                          account = new MutualFund(100);
                          account.AddMoney(100);
                          account.UpdateBalance();
                          if (WithinOnePenny(account.Balance, 210.94f))
                          {
                              Console.WriteLine("Passed");
                          }
                          else
                          {
                              Console.WriteLine("FAILED");
                          }
                          break;
                      case 8:
                          account = new MutualFund(100);
                          account.UpdateBalance();
                          account.UpdateBalance();
                          if (WithinOnePenny(account.Balance, 112.36f))
                          {
                              Console.WriteLine("Passed");
                          }
                          else
                          {
                              Console.WriteLine("FAILED");
                          }
                          break;
                      case 9:
                          account = new EmployerSponsoredAccount(100);
                          account.AddMoney(100);
                          account.UpdateBalance();
                          if (WithinOnePenny(account.Balance, 315.88f))
                          {
                              Console.WriteLine("Passed");
                          }
                          else
                          {
                              Console.WriteLine("FAILED");
                          }
                          break;
                      case 10:
                          account = new EmployerSponsoredAccount(100);
                          account.UpdateBalance();
                          account.UpdateBalance();
                          if (WithinOnePenny(account.Balance, 112.36f))
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
        /// Extracts the test case number from the given input string
        /// </summary>
        /// <param name="input">input string</param>
        static void GetInputValueFromString(string input)
        {
            testCaseNumber = int.Parse(input);
        }

        /// <summary>
        /// Tells whether or not the two amounts are within a penny of each other
        /// </summary>
        /// <param name="firstAmount">first amount</param>
        /// <param name="secondAmount">second amount</param>
        /// <returns>true if they are, false if they aren't</returns>
        static bool WithinOnePenny(float firstAmount, float secondAmount)
        {
            return Math.Abs(firstAmount - secondAmount) <= 0.01f;
        }
    }
}
