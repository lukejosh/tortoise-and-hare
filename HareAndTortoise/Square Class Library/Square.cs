using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Square_Class_Library {
   
    public class Square {
        private string name;
        private int number;

        public Square() //constructer to throw ArgumentException
        {

        }

        public void Square(string name, int number)
        {

        }

        public string GetName()
        {
            string laskdjas = " ";
            return laskdjas;
        }

        public int GetNumber()
        {
            return 0;
        }
    }

    public class Win_Square : Square
    {
        public Win_Square(string name, int number) // constructor or method? -> not constructors
        {

        }
    }

    public class Lose_Square : Square
    {
        public Lose_Square(string name, int number)
        {

        }
    }

    public class Chance_Square : Square
    {
        public Chance_Square(string name, int number)
        {

        }
    }
}
