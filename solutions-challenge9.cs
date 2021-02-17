using System;
using System.Collections.Generic;


namespace learning
{
    class Program
    {
        public static class Global
        {
            public static List<string> cards_in_play = new List<string>();
        }
        static void Main(string[] args)
        {
            Console.WriteLine();
            List<string> player_hand = DealHand(5, BuildDeck());
            foreach (string card in player_hand)
            {
                Console.WriteLine(card);
            }


        }
        static string[] BuildDeck()
        {
            string[] deck = new string[52];
            string[] suits = { "Clubs", "Hearts", "Diamonds", "Spades" };
            string[] vals = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King", "Ace" };
            int card = -1;
            foreach (string suit in suits)
            {
                foreach (string val in vals)
                {
                    card += 1;
                    deck[card] = val + " of " + suit;

                }
            }
            return deck;
        }
        static List<string> DealHand(int num, string[] deck)
        {
            List<string> hand = new List<string>();
            Random rnd = new Random();

            for (int x = 0; x < num; x++)
            {
                int card = rnd.Next(deck.Length);
                if (Global.cards_in_play.Contains(deck[card]))
                {
                    while (Global.cards_in_play.Contains(deck[card]))
                    {
                        card = rnd.Next(deck.Length);
                        
                    }
                    hand.Add(deck[card]);
                }
                else
                {
                    Global.cards_in_play.Add(deck[card]);
                    hand.Add(deck[card]);
                }


            }
            return hand;

        }



    }


}

