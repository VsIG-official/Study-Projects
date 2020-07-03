using System;
using System.Collections.Generic;
using ConsoleCards;

namespace Exercise4
{
	class Program
	{
		static void Main(string[] args)
		{
			int top = 5;
			int bottom = 0;
			for (int i = bottom; i <= top; i++)
			{
				Console.WriteLine(i);
			}

			//problem 2
			Deck deck = new Deck();
			List<Card> hand = new List<Card>();
			deck.Shuffle();

			//problem 3
			for (int i = 0; i <= top; i++)
			{
				hand.Add(deck.TakeTopCard());
			}

			for (int i = 0; i < top; i++)
			{
				hand[i].FlipOver();
			}

			foreach (Card card in hand)
			{
				Console.WriteLine(card);
			}
		}
	}
}
