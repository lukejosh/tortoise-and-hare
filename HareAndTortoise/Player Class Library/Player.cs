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


        public Player()
        {
            throw new ArgumentException();
        }

        public Player(string a_name, Square square)
        {
            name = a_name;
            location = square;
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

        public int RollTwoDice()
        {
            Die a_dice = new Die(6);
            int a_roll = a_dice.Roll();
            a_roll += a_dice.Roll();
            return a_roll;
        }

        public void SetPlayerTokenColour(Brush value){
            playerTokenColour = value;
            playerTokenImage = new Bitmap(1, 1);
            using(Graphics g = Graphics.FromImage(playerTokenImage))
            {
                g.FillRectangle(playerTokenColour, 0, 0, 1, 1);
            }
        }

    
    }
}
