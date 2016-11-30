using System;

namespace Peace
{
    public class Program
    {
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
            Console.WriteLine("Player 1, please enter your name: ");
            string name1 = Console.ReadLine();
            Player player1 = new Player(name1);
            Console.Clear();
            Console.WriteLine("Player 2, please enter your name: ");
            string name2 = Console.ReadLine();
            Player player2 = new Player(name2);
            Deck deck = new Deck();
            deck.shuffle();
            deck.Deal(player1, player2);
            Console.Clear();
            Console.WriteLine($"{player1.name} and {player2.name}, get ready to play!");
            Console.WriteLine("\nPress the any key to continue...");
            while (player1.hand > 0 || player2.hand > 0)
            {

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
                    Console.Clear();
                    Console.WriteLine($"Awesome, you chose your samurai {samurai.name}!");
                    Console.WriteLine("\n***********************************************************************\n");
                    Console.WriteLine("What move would you like to use?\n1. Death Blow\n2. Meditate");
                    ConsoleKeyInfo input2 = Console.ReadKey();
                    int inp2 = int.Parse(input2.KeyChar.ToString());
                    switch (inp2)
                    {
                        case 1:
                            samurai.DeathBlow(zombie1);
                            samurai.DeathBlow(zombie2);
                            samurai.DeathBlow(spider);
                            Console.Clear();
                            Console.WriteLine($"Nice!!  Zombie1's health is {zombie1.health}, zombie2's health is {zombie2.health}, and the spider's health is {spider.health}!");
                            Console.WriteLine("\nPress the <enter> key to continue...");
                            Console.ReadKey();
                            break;
                        case 2:
                            samurai.Meditate();
                            Console.Clear();
                            Console.WriteLine($"Your samurai healed himself and his health is now {samurai.health}.");
                            Console.WriteLine("\nPress the <enter> key to continue...");
                            Console.ReadKey();
                            break;
                    }
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
