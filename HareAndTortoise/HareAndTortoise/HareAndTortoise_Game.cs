using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using Board_Class_Library;
using Player_Class_Library;
using Square_Class_Library;
using Die_Class_Library;


namespace HareAndTortoise {
    public static class HareAndTortoise_Game {

        public static string[] PlayerNames = new string[] { "One", "Two", "Three", "Four", "Five", "Six" };
        public static Brush[] PlayerColours = new Brush[] { Brushes.Black, Brushes.Red, Brushes.Gold, Brushes.GreenYellow,                                                                        Brushes.Fuchsia, Brushes.BlueViolet };
        public static int numberOfPlayers = 6;
        private static BindingList<Player> players = new BindingList<Player>();
        public static BindingList<Player> Players {
            get {
                return players;
            }
        }

        public static void initialisePlayers()
        {
            for (int i = 0; i < numberOfPlayers; i++){
                Player new_player = new Player(PlayerNames[i], Board.StartSquare(), 100);
                new_player.SetPlayerTokenColour(PlayerColours[i]);
                Players.Add(new_player);
            }
        }

        public static void EndGame()
        {
            bool[] cur_highest = new bool[6] { false, false, false, false, false, false };
            int most_money = 0;
            for (int i = 0; i < numberOfPlayers; i++)
            {
                if (players[i].Money > most_money)
                {
                    most_money = players[i].Money;
                }

            }

            for (int i = 0; i < numberOfPlayers; i++)
            {
                if (players[i].Money == most_money)
                {
                    cur_highest[i] = true;
                }
            }
            if (cur_highest.Where(c => c).Count() == 1)
            {

            }
        }

        public static void MovePlayers()
        {
            int count = 0;
            for (int i = 0; i < numberOfPlayers; i++)
            {
                Die die1 = new Die(6);
                Die die2 = new Die(6);

                players[i].RollTwoDice(die1, die2, players[i]);
                if (players[i].Location.GetNumber() == Board.FINISH_SQUARE)
                {
                    count++;
                }
            }
            if (count != 0)
            {
                EndGame();
            }

        }

        public static void SetUpGame()
        {

            Board.SetUpBoard();
            initialisePlayers();

 
            //more code to be added later
        }// end SetUpGame


        // MORE METHODS TO BE ADDED HERE LATER
        
    }//end class
}//end namespace
