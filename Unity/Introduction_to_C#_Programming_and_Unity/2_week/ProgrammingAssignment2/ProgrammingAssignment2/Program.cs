using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingAssignment2
{
    /// <summary>
    /// Programming Assignment 2 solution
    /// </summary>
    class Program
    {
        /// <summary>
        /// Deals 2 cards to 3 players and displays cards for players
        /// </summary>
        /// <param name="args">command-line arguments</param>
        static void Main(string[] args)
        {
            // print welcome message
            Console.WriteLine("Hi! My name is <Corrupted files> and now we will play a game 'Blackjack'");
            Console.WriteLine();
            // create and shuffle a deck
            Console.WriteLine("So, heres our deck");

            Console.WriteLine("<Robot hand pulls a deck of cards from under the table>");
            Deck deck = new Deck();

            Console.WriteLine("<Robot hand shuffles the deck>");
            deck.Shuffle();
            // deal 2 cards each to 3 players (deal properly, dealing
            // the first card to each player before dealing the
            // second card to each player)
            Console.WriteLine();
            Console.WriteLine("Your cards, gentlemen");
            Console.WriteLine("<Robot hand gives cards>");

            Card firstPlayerFirstCard = deck.TakeTopCard();
            Card secondPlayerFirstCard = deck.TakeTopCard();
            Card thirdPlayerFirstCard = deck.TakeTopCard();

            Card firstPlayerSecondCard = deck.TakeTopCard();
            Card secondPlayerSecondCard = deck.TakeTopCard();
            Card thirdPlayerSecondCard = deck.TakeTopCard();
            // flip all the cards over
            firstPlayerFirstCard.FlipOver();
            secondPlayerFirstCard.FlipOver();
            thirdPlayerFirstCard.FlipOver();

            firstPlayerSecondCard.FlipOver();
            secondPlayerSecondCard.FlipOver();
            thirdPlayerSecondCard.FlipOver();

            Console.WriteLine("<Robot hand flips over the cards>");
            Console.WriteLine();
            // print the cards for player 1
            Console.WriteLine("<Your cards are : >");

            Console.WriteLine(firstPlayerFirstCard.Rank + " of " + firstPlayerFirstCard.Suit);
            Console.WriteLine(firstPlayerSecondCard.Rank + " of " + firstPlayerSecondCard.Suit);

            Console.WriteLine();
            // print the cards for player 2
            Console.WriteLine("<Second player cards are : >");

            Console.WriteLine(secondPlayerFirstCard.Rank + " of " + secondPlayerFirstCard.Suit);
            Console.WriteLine(secondPlayerSecondCard.Rank + " of " + secondPlayerSecondCard.Suit);

            Console.WriteLine();
            // print the cards for player 3
            Console.WriteLine("<Third player cards are : >");

            Console.WriteLine(thirdPlayerFirstCard.Rank + " of " + thirdPlayerFirstCard.Suit);
            Console.WriteLine(thirdPlayerSecondCard.Rank + " of " + thirdPlayerSecondCard.Suit);

            Console.WriteLine();
        }
    }
}
