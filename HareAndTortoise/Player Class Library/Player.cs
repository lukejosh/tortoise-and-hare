using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using Square_Class_Library;

namespace Player_Class_Library {
    public class Player {
        private string name;
        private Square location;
        private Image playerTokenImage;
        private Brush playerTokenColour;

        public Player()
        {
            throw new ArgumentException();
        }

        public Player(string a_name, Square square)
        {
            name = a_name;
            location = square;
        }

        public void SetName(string a_name)
        {
            name = a_name;
        }

        public string GetName()
        {
            return name;
        }

        public void SetLocation(Square a_square)
        {
            location = a_square;
        }

        public Square GetLocation()
        {
            return location
        }

        public Image GetPlayerTokenImage()
        {
            return playerTokenImage;
        }

        public Brush GetPlayerTokenColour()
        {
            return playerTokenColour;
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
