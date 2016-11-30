using System;
using System.Collections.Generic;

namespace Peace
{
    public class Program
    {
        public static void PeaceNegotiation(Player player1, Player player2, Card card1, Card card2)
        {
            Console.Clear();
            List<Card> p1negot = new List<Card> {player1.Draw(),player1.Draw(),player1.Draw()};
            List<Card> p2negot = new List<Card> {player2.Draw(),player2.Draw(),player2.Draw()};
            Console.Write($"{player1.name}, pick a card from {player2.name}'s hand (enter 1-3): ");
            ConsoleKeyInfo p1 =  Console.ReadKey();
            int p1pick = int.Parse(p1.KeyChar.ToString());
            Console.Clear();
            Console.Write($"{player2.name}, pick a card from {player1.name}'s hand (enter 1-3): ");
            ConsoleKeyInfo p2 =  Console.ReadKey();
            int p2pick = int.Parse(p1.KeyChar.ToString());
            Card p1cardpick = p2negot[p2pick];
            Card p2cardpick = p1negot[p1pick];
            int winner = Check(p2cardpick, p1cardpick);
            Console.Clear();
            switch (winner)
            {
                case 1:
                    Console.WriteLine($"{player1.name}'s card is a {p2cardpick.StringValue} of {p2cardpick.suit}, {player2.name}'s card is a {p1cardpick.StringValue} of {p1cardpick.suit}.  {player1.name} wins!");
                    foreach (Card card in p1negot)
                    {
                        player1.hand.Add(card);
                    }
                    foreach (Card card in p2negot)
                    {
                        player1.hand.Add(card);
                    }
                    Console.WriteLine("\nPress the any key to continue...");
                    Console.ReadKey();
                    break;
                case 2:
                    Console.WriteLine($"{player1.name}'s card is a {p2cardpick.StringValue} of {p2cardpick.suit}, {player2.name}'s card is a {p1cardpick.StringValue} of {p1cardpick.suit}.  {player2.name} wins!");
                    foreach (Card card in p1negot)
                    {
                        player2.hand.Add(card);
                    }
                    foreach (Card card in p2negot)
                    {
                        player2.hand.Add(card);
                    }
                    Console.WriteLine("\nPress the any key to continue...");
                    Console.ReadKey();
                    break;
                case 3:
                    Console.WriteLine($"{player1.name}'s card is a {p2cardpick.StringValue} of {p2cardpick.suit}, {player2.name}'s card is a {p1cardpick.StringValue} of {p1cardpick.suit}.  A second negotiation ensues and you two decide that it's best to just call it a truce....for the time being.");
                    Console.WriteLine("\nPress the any key to continue...");
                    Console.ReadKey();
                    break;
            }
                
        }
        public static int Check(Card card1, Card card2)
        {
            if (card1.val < card2.val)
            {
                return 1;
            }
            else if (card1.val > card2.val)
            {
                return 2;
            }
            else
            {
                return 3;
            }
        }
        public static void GamePlay()
        {
            Console.Clear();
            Console.Write("Player 1, please enter your name: ");
            string name1 = Console.ReadLine();
            Player player1 = new Player(name1);
            Console.Clear();
            Console.Write("Player 2, please enter your name: ");
            string name2 = Console.ReadLine();
            Player player2 = new Player(name2);
            Deck deck = new Deck();
            deck.Shuffle();
            deck.Deal(player1, player2);
            Console.Clear();
            Console.WriteLine("Ready Player 1?");
            Console.WriteLine("\nPress the any key to continue...");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Ready Player 2?");
            Console.WriteLine("\nPress the any key to continue...");
            Console.ReadKey();
            while (player1.hand.Count > 0 || player2.hand.Count > 0)
            {
                Console.Clear();
                Card card1 = player1.Draw();
                Card card2 = player2.Draw();
                int winner = Check(card1, card2);
                switch (winner)
                {
                    case 1:
                        Console.WriteLine($"{player1.name} drew a {card1.StringValue} of {card1.suit}, {player2.name} drew a {card2.StringValue} of {card2.suit}.  {player2.name} wins!");
                        player2.hand.Add(card1);
                        player2.hand.Add(card2);
                        Console.WriteLine("\nPress the any key to continue...");
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.WriteLine($"{player1.name} drew a {card1.StringValue} of {card1.suit}, {player2.name} drew a {card2.StringValue} of {card2.suit}.  {player1.name} wins!");
                        player1.hand.Add(card1);
                        player1.hand.Add(card2);
                        Console.WriteLine("\nPress the any key to continue...");
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.WriteLine($"{player1.name} drew a {card1.StringValue} of {card1.suit}, {player2.name} drew a {card2.StringValue} of {card2.suit}.  It's a tie! Time for Peace Negotiation...");
                        Console.WriteLine("\nPress the any key to continue...");
                        Console.ReadKey();
                        PeaceNegotiation(player1,player2,card1,card2);
                        break;
                }
                
            }
            
            Console.Clear();

        }
        public static void Init()
        {
            Console.Clear();
            Console.WriteLine("Welcome to the game of Peace!  Please choose a number from the following menu:\n");
            Console.WriteLine("\n********************************************************************\n");
            Console.WriteLine("1.Start a new game\n2.Read the rules\n3.Exit");
            ConsoleKeyInfo kinfo =  Console.ReadKey();
            int charInt = int.Parse(kinfo.KeyChar.ToString());
            switch (charInt)
            {
                case 1:
                    GamePlay();
                    break;
                case 2:
                    break;
                case 3:
                    break;
            }
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
