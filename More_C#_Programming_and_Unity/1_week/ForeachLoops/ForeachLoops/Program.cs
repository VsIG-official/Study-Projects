using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleCards;

namespace ForeachLoops
{
    /// <summary>
    /// Foreach Loops lecture code
    /// </summary>
    class Program
    {
        /// <summary>
        /// Demonstrates foreach loops
        /// </summary>
        /// <param name="args">command-line arguments</param>
        static void Main(string[] args)
        {
            Deck deck = new Deck();
            List<Card> hand = new List<Card>();

            // add a few cards to the list
            hand.Add(deck.TakeTopCard());
            hand.Add(deck.TakeTopCard());
            hand.Add(deck.TakeTopCard());

            // print cards in the hand
            //stars with hand zero and puts that value into card
            //and in the loop we`re dealing with a zero`s element of a hand
            //its based on a count of an objects in an array/list(in our example "hand")
            foreach (Card card in hand)
            {
                Console.WriteLine(card.Rank + " of " +
                    card.Suit);
            }

            // add 5 cards to hand
            //we don`t iterating over an array/list
            for (int i = 0; i < 5; i++)
            {
                hand.Add(deck.TakeTopCard());
            }

            // print cards in the hand
            Console.WriteLine();
            foreach (Card card in hand)
            {
                Console.WriteLine(card.Rank + " of " +
                    card.Suit);
                //now we are modifying collection and we don`t allowed to
                //should use for loop
                //hand.Remove(card);
            }

            Console.WriteLine();
        }
    }
}
