using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleCards;

//to add a dll go to project>add reference
namespace ForLoops
{
    /// <summary>
    /// For Loops lecture code
    /// </summary>
    class Program
    {
        /// <summary>
        /// Demonstrates for loops
        /// </summary>
        /// <param name="args">command-line arguments</param>
        static void Main(string[] args)
        {
            Deck deck = new Deck();
            List <Card> hand = new List<Card>();

            //add a few cards in a list
            hand.Add(deck.TakeTopCard());
            hand.Add(deck.TakeTopCard());
            hand.Add(deck.TakeTopCard());

            //print cards
            // initialization - condition - modifier
            for ( int i = 0; i < hand.Count; i++)
            {
                Console.WriteLine(hand[i].Rank + " of " + hand[i].Suit);
            }

            Console.WriteLine();

            //add 5 cards in hand
            for (int i = 0; i < 5; i++)
            {
                hand.Add(deck.TakeTopCard());
            }

            for (int i = 0; i < hand.Count; i++)
            {
                Console.WriteLine(hand[i].Rank + " of " + hand[i].Suit);
            }
        }
    }
}
