using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using Square_Class_Library;
using Die_Class_Library;

namespace Player_Class_Library {
    public class Player {
        private Image playerTokenImage;
        private Brush playerTokenColour;
        private string name;
        private int money;
        private bool hasWon;
        private Square location;

        public int MAX_PLAYERS = 6;
        public int WIN_SQUARE = 55;


        public Player()
        {
            throw new ArgumentException();
        }

        public Player(string a_name, Square square, int cashmoney)
        {
            name = a_name;
            location = square;
            money = cashmoney;
        }

        public int Money
        {
            set
            {
                money = value;
            }
            get
            {
                return money;
            }
        }

        public bool HasWon
        {
            set
            {
                hasWon = value;
            }
            get
            {
                return hasWon;
            }
        }

        public string Name
        {
            set
            {
                name = value;
            }
            get
            {
                return name;
            }
        }

        public Square Location
        {
            set
            {
                location = value;
            }
            get
            {
                return location;
            }
        }

        public Image PlayerTokenImage
        {
            set
            {
                playerTokenImage = value;
            }
            get
            {
                return playerTokenImage;
            }
        }

        public Brush PlayerTokenColour
        {
            set
            {
                playerTokenColour = value;
            }
            get
            {
                return playerTokenColour;
            }
        }

        public void RollTwoDice(Die die1, Die die2, Player who)
        {
            int move = die1.Roll() + die2.Roll();
            if (who.location.GetNumber() + move > WIN_SQUARE)
            {
                who.location = Board_Class_Library.Board.GetGameBoardSquare(WIN_SQUARE);
            }
            else
            {
                who.location = Board_Class_Library.Board.GetGameBoardSquare(who.Location.GetNumber() + move);
            }
            who.Location.EffectOnPlayer(who);
        }

        public void SetPlayerTokenColour(Brush value){
            playerTokenColour = value;
            playerTokenImage = new Bitmap(1, 1);
            using(Graphics g = Graphics.FromImage(playerTokenImage))
            {
                g.FillRectangle(playerTokenColour, 0, 0, 1, 1);
            }
        }

        public void Add(int amount)
        {
            money += amount;
        }

        public void Deduct(int amount)
        {
            if (money <= amount)
            {
                money = 0;
            }
            else
            {
                money -= amount;
            }
        }

    
    }
}
