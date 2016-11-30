using System;

namespace Peace
{
    public class Card
    {
        public int val { get; set; }

        public string suit { get; set; }

        public string StringValue {
            get{
                switch (val)
                {
                    case 1:
                        return "Ace";
                    case 11:
                        return "Jack";
                    case 12:
                        return "Queen";
                    case 13:
                        return "King";
                    default:
                        return val.ToString();
                }
            }
        }
        public Card(int _val, string _suit)
        {
            val = _val;
            suit = _suit;
        }
    }
}