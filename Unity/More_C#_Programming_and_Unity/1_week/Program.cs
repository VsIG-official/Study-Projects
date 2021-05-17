using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleCards;

namespace Exercise4
{
    /// <summary>
    /// Exercise 4 solution
    /// </summary>
    class Program
    {
        /// <summary>
        /// Practice with for and foreach loops
        /// </summary>
        /// <param name="args">command-line arguments</param>
        static void Main(string[] args)
        {
            // get upper and lower bounds
            Console.Write("Enter lower bound: ");
            int lowerBound = int.Parse(Console.ReadLine());
            Console.Write("Enter upper bound: ");
            int upperBound = int.Parse(Console.ReadLine());

            // print numbers in range
            for (int i = lowerBound; i <= upperBound; i++)
            {
                Console.WriteLine(i);
            }

            // game objects
            Deck deck = new Deck();
            List<Card> hand = new List<Card>();

            // shuffle the deck and deal 5 cards into the hand
            deck.Shuffle();
            for (int i = 0; i < 5; i++)
            {
                hand.Add(deck.TakeTopCard());
            }

            // flip all the cards over
            for (int i = 0; i < hand.Count; i++)
            {
                hand[i].FlipOver();
            }

            // print the hand
            foreach (Card card in hand)
            {
                card.Print();
            }

            Console.WriteLine();
        }
    }
}
