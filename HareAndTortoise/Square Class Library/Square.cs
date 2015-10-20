using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Square_Class_Library
{

    public class Square
    {
        private string name;
        private int number;

        public Square()
        {
            throw new ArgumentException();
        }

        public Square(string name_in, int number_in) //Exception
        {
            name = name_in;
            number = number_in;
        }

        public string GetName()
        {
            return name;
        }

        public int GetNumber()
        {
            return number;
        }
    }

    public class Win_Square : Square
    {
        public Win_Square(string name, int number):
            base(name, number)// constructor or method? -> not constructors
        {

        }
    }

    public class Lose_Square : Square
    {
        public Lose_Square(string name, int number):
            base(name, number)
        {

        }
    }

    public class Chance_Square : Square
    {
        public Chance_Square(string name, int number):
            base(name, number)
        {

        }
    }
}
