using System;
using System.Collections.Generic;
using Card;
using Deck;

namespace Peace
{
    public class Player
    {
        public string name { get; private set; }
        List<Card> hand = new List<Card>();
        public Player(string n)
        {
            name = n;
        }

        public Card Draw()
        {
            Card card = hand[0];
            hand.RemoveAt(hand[0]);
            return card;
        }
    }
}