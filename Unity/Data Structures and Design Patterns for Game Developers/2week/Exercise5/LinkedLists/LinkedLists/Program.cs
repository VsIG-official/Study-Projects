using System;

namespace LinkedLists
{
    /// <summary>
    /// Tests the linked lists
    /// </summary>
    class MainClass
    {
        /// <summary>
        /// Tests the linked lists
        /// </summary>
        public static void Main()
        {
            TestUnsortedLinkedList.RunTestCases();
            TestSortedLinkedList.RunTestCases();

            Console.ReadLine();
        }
    }
}
