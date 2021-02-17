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
            Console.WriteLine("\n===Player 1's hand===");
            string[] deck = BuildDeck();
            List<string> player_hand = DealHand(5, deck);
            foreach (string card in player_hand)
            {
                Console.WriteLine(card);
            }
            Console.WriteLine("\n===Player 2's hand===");
            player_hand = DealHand(5, deck);
            foreach (string card in player_hand)
            {
                Console.WriteLine(card);
            }
            Console.WriteLine("\n===Player 3's hand===");
            player_hand = DealHand(5, deck);
            foreach (string card in player_hand)
            {
                Console.WriteLine(card);
            }
            List<string> cards_still_in_deck = new List<string>();
            foreach (string card in deck)
            {
                if (Global.cards_in_play.Contains(card) == false)
                {
                    cards_still_in_deck.Add(card);
                }
            }
            double face_cards = 0.0;
            double number_cards = 0.0;
            double aces = 0.0;
            foreach (string card in cards_still_in_deck)
            {
                if (card.IndexOf("King") != -1 || card.IndexOf("Queen") != -1 || card.IndexOf("Jack") != -1)
                {
                    face_cards += 1;
                }
                else if (card.IndexOf("Ace") != -1)
                {
                    aces += 1;
                }
                else
                {
                    number_cards += 1;
                }
            }

            Console.WriteLine("\nChance of next card being a face card: " + Math.Round((face_cards / cards_still_in_deck.Count) * 100, 1) + "%");
            Console.WriteLine("Chance of next card being an ace: " + Math.Round((aces / cards_still_in_deck.Count) * 100, 1) + "%");
            Console.WriteLine("Chance of next card being a number card: " + Math.Round((number_cards / cards_still_in_deck.Count) * 100, 1) + "%");


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

