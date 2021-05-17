using System;

namespace UsingDeckClass
{
	/// <summary>
	/// Classes and Objects Lecture code
	/// </summary>
	class Program
	{
		/// <summary>
		///	Demonstrates using a Deck class
		/// </summary>
		/// <param name="args"></param>
		static void Main(string[] args)
		{
			//create and print a deck of cards
			//Deck=class
			Deck deck = new Deck();
			//deck.Print();

			//access and print empty value
			//1

			//bool deckEmpty = deck.Empty;
			//Console.WriteLine("Deck is empty " + deckEmpty);
			//2

			Console.WriteLine("Deck is empty " + deck.Empty);

			//shuffle the deck
			//these are METHODS
			//when we calling method-argument
			//when pass into method-paremetr
			//deck.Shuffle();
			deck.Print();

			Console.WriteLine();

			deck.Cut(26);
			deck.Print();

			Console.WriteLine();
			//take top card
			//this method returns card(it`s not void)
			deck.TakeTopCard();
			Card card = deck.TakeTopCard();
			Console.WriteLine(card.Rank + " of " + card.Suit);

			Console.WriteLine();
			//void returns nothing
		}
	}
}
