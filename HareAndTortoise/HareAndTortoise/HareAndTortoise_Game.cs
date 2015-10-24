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

        public static bool isOver = false;
        public static string[] PlayerNames = new string[] { "One", "Two", "Three", "Four", "Five", "Six" };
        public static Brush[] PlayerColours = new Brush[] { Brushes.Black, Brushes.Red, Brushes.Gold, Brushes.GreenYellow,                                                                        Brushes.Fuchsia, Brushes.BlueViolet };
        public const int numberOfPlayers = 6;
        private static BindingList<Player> players = new BindingList<Player>();
        public static BindingList<Player> Players {
            get {
                return players;
            }
        }

        /// <summary>
        /// Adds the required number of players to the gameboard
        /// </summary>
        /// <param name="numberplayers">The number of players selected in the combo box</param>
        public static void initialisePlayers(int numberplayers = numberOfPlayers)
        {
            for (int i = 0; i < numberplayers; i++){
                Player new_player = new Player(PlayerNames[i], Board.StartSquare(), 100);
                new_player.SetPlayerTokenColour(PlayerColours[i]);
                Players.Add(new_player);
            }
        }
        
        /// <summary>
        /// Determines which of the players has won.
        /// </summary>
        /// <param name="number_of_players">The number of players selected from the combo box</param>
        public static void EndGame(int number_of_players)
        {
            bool[] cur_highest = new bool[6] { false, false, false, false, false, false };
            int most_money = 0;
            for (int i = 0; i < number_of_players; i++) //Loops through each of the players
            {
                if (players[i].Money > most_money)
                {
                    most_money = players[i].Money; //Determines what the highest amount of money is
                }

            }

            for (int i = 0; i < number_of_players; i++) //Loops through each of the players
            {
                if (players[i].Money == most_money)
                {
                    cur_highest[i] = true; //Sets to true if the player has the highest amount of money
                }
            }
            if (cur_highest.Where(c => c).Count() == 1)
            {
                for (int i = 0; i < number_of_players; i++)
                {
                    if (cur_highest[i])
                    {
                        players[i].HasWon = true; //If one player has the highest amount, declare them the winner
                    }
                }
            }

            else
            {
                int greatest_distance = 0;
                for (int i = 0; i < number_of_players; i++)
                {
                    if (players[i].Location.GetNumber() > greatest_distance && cur_highest[i])
                    {
                        greatest_distance = players[i].Location.GetNumber(); //Determines the greatest distance moved between players with equal highest money
                    }
                }

                for (int i = 0; i < number_of_players; i++)
                {
                    if (players[i].Location.GetNumber() == greatest_distance)
                    {
                        players[i].HasWon = true; //If a player has the most money and has moved the furthest, declare them the winner.
                    }
                }
            }
        }

        /// <summary>
        /// Generates dice, rolls for each player, moves, and checks for end of game
        /// </summary>
        /// <param name="number_players">Number of players from combo box</param>
        public static void MovePlayers(int number_players = numberOfPlayers)
        {
            int count = 0;
            for (int i = 0; i < number_players; i++)
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
                EndGame(number_players);
                isOver = true;

            }

        }

        public static void SetUpGame()
        {

            Board.SetUpBoard();
            initialisePlayers();
            
 
            //more code to be added later
        }// end SetUpGame

        /// <summary>
        /// Resets the players to have inital location and money
        /// </summary>
        /// <param name="number">Number of players to reset, selected in combo box</param>
        public static void ResetPlayers(int number)
        {
            players.Clear();
            initialisePlayers(number);
            isOver = false;

        }
    }
}
