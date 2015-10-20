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
        private Image PlayerTokenImage;
        private Brush PlayerTokenColour;

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
            return location;
        }

        public Image GetPlayerTokenImage()
        {
            return PlayerTokenImage;
        }

        public Brush GetPlayerTokenColour()
        {
            return PlayerTokenColour;
        }

        public void SetPlayerTokenColour(Brush value){
            PlayerTokenColour = value;
            PlayerTokenImage = new Bitmap(1, 1);
            using(Graphics g = Graphics.FromImage(PlayerTokenImage))
            {
                g.FillRectangle(PlayerTokenColour, 0, 0, 1, 1);
            }
        }

    
    }
}
