using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using UnityEngine;

namespace ProgrammingAssignment3
{
    /// <summary>
    /// Programming Assignment 3 
    /// </summary>
    class Program
    {
        // test case to run
        static int testCaseNumber;

        // debug log messages
        static List<string> logMessages = new List<string>();

        /// <summary>
        /// Tests the Programming Assignment 3 classes
        /// </summary>
        /// <param name="args">command-line args</param>
        static void Main(string[] args)
        {
            // listen for Unity debug log events
            UnityEngine.Debug.LogEvent.AddListener(HandleLogEvent);

            // create Invoker and Listener
            Invoker invoker = new Invoker();
            Listener listener = new Listener();

            // Awake is always called before Start
            invoker.Awake();

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
                        // invoker added to event manager first for no argument event
                        InitializeTestCase(invoker, listener);
                        EventManager.NoArgumentInvoker.InvokeNoArgumentEvent();
                        if (logMessages[0] == "MessageEvent" &&
                            logMessages.Count == 1)
                        {
                            Console.WriteLine("Passed");
                        }
                        else
                        {
                            Console.WriteLine("FAILED");
                        }
                        break;
                    case 2:
                        logMessages.Clear();
                        EventManager.ClearInvokersAndListeners();

                        // listener added to event manager first for no argument event
                        listener.Start();
                        invoker.Start();
                        EventManager.NoArgumentInvoker.InvokeNoArgumentEvent();
                        if (logMessages[0] == "MessageEvent" &&
                            logMessages.Count == 1)
                        {
                            Console.WriteLine("Passed");
                        }
                        else
                        {
                            Console.WriteLine("FAILED");
                        }
                        break;
                    case 3:
                        // invoker added to event manager first for one argument event
                        InitializeTestCase(invoker, listener);
                        EventManager.IntArgumentInvoker.InvokeOneArgumentEvent(-1);
                        if (logMessages[0] == "CountMessageEvent: -1" &&
                            logMessages.Count == 1)
                        {
                            Console.WriteLine("Passed");
                        }
                        else
                        {
                            Console.WriteLine("FAILED");
                        }
                        break;
                    case 4:
                        logMessages.Clear();
                        EventManager.ClearInvokersAndListeners();

                        // listener added to event manager first for one argument event
                        listener.Start();
                        invoker.Start();
                        EventManager.IntArgumentInvoker.InvokeOneArgumentEvent(-1);
                        if (logMessages[0] == "CountMessageEvent: -1" &&
                            logMessages.Count == 1)
                        {
                            Console.WriteLine("Passed");
                        }
                        else
                        {
                            Console.WriteLine("FAILED");
                        }
                        break;
                    case 5:
                        InitializeTestCase(invoker, listener);

                        // invoke no argument event directly through invoker
                        invoker.InvokeNoArgumentEvent();
                        if (logMessages[0] == "MessageEvent" &&
                            logMessages.Count == 1)
                        {
                            Console.WriteLine("Passed");
                        }
                        else
                        {
                            Console.WriteLine("FAILED");
                        }
                        break;
                    case 6:
                        InitializeTestCase(invoker, listener);

                        // invoke one argument event directly through invoker
                        invoker.InvokeOneArgumentEvent(-1);
                        if (logMessages[0] == "CountMessageEvent: -1" &&
                            logMessages.Count == 1)

                        {
                            Console.WriteLine("Passed");
                        }
                        else
                        {
                            Console.WriteLine("FAILED");
                        }
                        break;
                    case 7:
                        InitializeTestCase(invoker, listener);

                        // invoke multiple no argument events directly through invoker
                        invoker.InvokeNoArgumentEvent();
                        invoker.InvokeNoArgumentEvent();
                        invoker.InvokeNoArgumentEvent();
                        if (logMessages[0] == "MessageEvent" &&
                            logMessages[1] == "MessageEvent" &&
                            logMessages[2] == "MessageEvent" &&
                            logMessages.Count == 3)
                        {
                            Console.WriteLine("Passed");
                        }
                        else
                        {
                            Console.WriteLine("FAILED");
                        }
                        break;
                    case 8:
                        InitializeTestCase(invoker, listener);

                        // invoke multiple one argument events directly through invoker
                        invoker.InvokeOneArgumentEvent(1);
                        invoker.InvokeOneArgumentEvent(2);
                        invoker.InvokeOneArgumentEvent(3);
                        if (logMessages[0] == "CountMessageEvent: 1" &&
                            logMessages[1] == "CountMessageEvent: 2" &&
                            logMessages[2] == "CountMessageEvent: 3" &&
                            logMessages.Count == 3)
                        {
                            Console.WriteLine("Passed");
                        }
                        else
                        {
                            Console.WriteLine("FAILED");
                        }
                        break;
                    case 9:
                        InitializeTestCase(invoker, listener);

                        // invoke combination of events directly through invoker
                        invoker.InvokeOneArgumentEvent(1);
                        invoker.InvokeNoArgumentEvent();
                        invoker.InvokeOneArgumentEvent(3);
                        if (logMessages[0] == "CountMessageEvent: 1" &&
                            logMessages[1] == "MessageEvent" &&
                            logMessages[2] == "CountMessageEvent: 3" &&
                            logMessages.Count == 3)
                        {
                            Console.WriteLine("Passed");
                        }
                        else
                        {
                            Console.WriteLine("FAILED");
                        }
                        break;
                    case 10:
                        InitializeTestCase(invoker, listener);

                        // invoke multiple one argument events directly through invoker
                        invoker.InvokeNoArgumentEvent();
                        invoker.InvokeOneArgumentEvent(2);
                        invoker.InvokeNoArgumentEvent();
                        if (logMessages[0] == "MessageEvent" &&
                            logMessages[1] == "CountMessageEvent: 2" &&
                            logMessages[2] == "MessageEvent" &&
                            logMessages.Count == 3)
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
        /// Handles the log event from the Debug mock
        /// </summary>
        /// <param name="message">message to log</param>
        static void HandleLogEvent(string message)
        {
            logMessages.Add(message);
        }

        /// <summary>
        /// Initializes test case
        /// </summary>
        static void InitializeTestCase(Invoker invoker, Listener listener)
        {
            logMessages.Clear();
            EventManager.ClearInvokersAndListeners();
            invoker.Start();
            listener.Start();
        }
    }
}
