using System;
using System.Collections.Generic;

namespace Peace
{
    public class Deck
    {
        public List<Card> cards;
        public Deck()
        {
            Reset();
        }
        public void Shuffle()
        {
            Random rand = new Random();
            for (int i = cards.Count -1; i > 0; i--)
            {
                int idx = rand.Next(0, i);
                Card temp = cards[i];
                cards[i] = cards[idx];
                cards[idx] = temp;
            }
        }

        public Card Deal()
        {
            Card temp = cards[0];
            cards.RemoveAt(0);
            return temp;
        }
        public override string ToString()
        {
            string str = "List of Cards:\n============\n";
            foreach(Card card in cards)
            {
                str += card.StringValue + " of " + card.suit + "\n";
            }
            return str;
        }

        public void Reset()
        {
            cards = new List<Card>();
            string[] suits = new string[4] {"Hearts", "Diamonds", "Clubs", "Spades"};
            foreach (string suit in suits)
            {
                for(int i = 1; i < 14; i++)
                {
                    cards.Add(new Card(i, suit));
                }
            }
        }
    }
}