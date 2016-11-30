using System;
using System.Collections.Generic;

namespace Peace
{
    public class Player
    {
        public string name { get; private set; }
        public List<Card> hand = new List<Card>();
        public Player(string n)
        {
            name = n;
        }

        public Card Draw()
        {
            Card card = hand[0];
            hand.RemoveAt(0);
            return card;
        }
    }
}