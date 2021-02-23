using System;
using System.Collections.Generic;


namespace learning
{
    class Program
    {
        public static class Global
        {
            public static List<string> winning_plays = new List<string> { "rock", "paper", "scissors" };
        }
        static string oneGame()
        {
            Random rnd = new Random();
            string win = "";

            //List<string> plays = new List<string> { "rock", "paper", "scissors" };
            int choice = rnd.Next(0, Global.winning_plays.Count);
            //string c_play = plays[rnd.Next(0, 2)];
            string c_play = Global.winning_plays[choice];

            Console.Write("\n\nChoose rock, paper, or scissors: ");
            string u_play = Console.ReadLine();

            if (u_play.ToLower().StartsWith("r"))
            {
                if (c_play == "rock") { win = "tie"; } else if (c_play == "paper") { win = "computer"; } else if (c_play == "scissors") { win = "player"; }
            }
            else if (u_play.ToLower().StartsWith("p"))
            {
                if (c_play == "paper") { win = "tie"; } else if (c_play == "scissors") { win = "computer"; } else if (c_play == "rock") { win = "player"; }
            }
            else if (u_play.ToLower().StartsWith("s"))
            {
                if (c_play == "scissors") { win = "tie"; } else if (c_play == "rock") { win = "computer"; } else if (c_play == "paper") { win = "player"; }
            }

            Console.WriteLine("Computer chose " + c_play);
            if (win == "computer") { Global.winning_plays.Add(c_play); }
            if (win != "tie") { Console.WriteLine("Win goes to " + win); } else { Console.WriteLine("Game is a tie"); }

            return win;
        }
        static void Main(string[] args)
        {
            int comp_score = 0;
            int player_score = 0;
            bool again = false;
            string again_string = "";

            string gamen = oneGame();
            if (gamen == "player")
            {
                player_score += 1;
            }
            else if (gamen == "computer")
            {
                comp_score += 1;
            }
            Console.Write("Computer score: " + comp_score + " Player score: " + player_score);

            Console.Write("\nPlay again? Yes or no: ");
            again_string = Console.ReadLine();
            if (again_string.ToLower().StartsWith("y"))
            {
                again = true;
            }
            else
            {
                again = false;
            }
            if (again == true)
            {
                while (again == true)
                {
                    gamen = oneGame();
                    if (gamen == "player")
                    {
                        player_score += 1;
                    }
                    else if (gamen == "computer")
                    {
                        comp_score += 1;
                    }
                    Console.Write("Computer score: " + comp_score + " Player score: " + player_score);
                    Console.Write("\nPlay again? Yes or no: ");
                    again_string = Console.ReadLine();
                    if (again_string.ToLower().StartsWith("y"))
                    {
                        again = true;
                    }
                    else
                    {
                        again = false;
                    }
                }
            }

        }
    }
}
