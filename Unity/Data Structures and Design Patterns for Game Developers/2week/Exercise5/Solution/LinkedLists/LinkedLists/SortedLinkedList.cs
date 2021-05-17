using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedLists
{
    /// <summary>
    /// A sorted linked list
    /// </summary>
    class SortedLinkedList<T> : LinkedList<T> where T:IComparable
    {
        #region Constructors

        public SortedLinkedList() : base()
        {
        }

        #endregion

        #region Public methods

        /// <summary>
        /// Adds the given item to the list
        /// </summary>
        /// <param name="item">item to add</param>
        public override void Add(T item)
        {
            // adding to empty list
            if (head == null)
            {
                head = new LinkedListNode<T>(item, null, null);
            }
            else if (head.Value.CompareTo(item) > 0)
            {
                // adding before head
                head = new LinkedListNode<T>(item, head, null);
                head.Next.Previous = head;
            }
            else
            {
                // find place to add new node
                // need previous node for adding to end of list
                LinkedListNode<T> previousNode = head;
                LinkedListNode<T> currentNode = head.Next;
                while (currentNode != null &&
                    currentNode.Value.CompareTo(item) < 0)
                {
                    currentNode = currentNode.Next;
                }

                // check for adding to end of list
                if (currentNode == null)
                {
                    previousNode.Next = new LinkedListNode<T>(item,
                        null, previousNode);
                }
                else
                {
                    // link in new node between previous node and current node
                    currentNode.Previous.Next = new LinkedListNode<T>(
                        item, currentNode, null);
                }
            }
            count++;
        }

        #endregion
    }
}

