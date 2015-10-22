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
                Player new_player = new Player(PlayerNames[i], Board.StartSquare());
                new_player.SetPlayerTokenColour(PlayerColours[i]);
                Players.Add(new_player);
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
