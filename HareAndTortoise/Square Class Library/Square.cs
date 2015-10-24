using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Player_Class_Library;
using Die_Class_Library;

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

        /// <summary>
        /// Applies the effect on the player based on what type of square it has landed in
        /// </summary>
        /// <param name="who">The player the effect is to be applied to</param>
        public virtual void EffectOnPlayer(Player who)
        {

        }
    }

    /// <summary>
    /// A particular "win" game square
    /// </summary>
    public class Win_Square : Square
    {
        public Win_Square(string name, int number):
            base(name, number)// constructor or method? -> not constructors
        {

        }

        /// <summary>
        /// Adds 15 money and rerolls the player
        /// </summary>
        /// <param name="who">The player</param>
        public override void EffectOnPlayer(Player who)
        {
            who.Add(15);
            who.Reroll(who);
        }
    }

    /// <summary>
    /// A particular "lose" game square
    /// </summary>
    public class Lose_Square : Square
    {
        public Lose_Square(string name, int number):
            base(name, number)
        {

        }

        /// <summary>
        /// Deducts 25 money and moves 3 spaces back
        /// </summary>
        /// <param name="who">The player</param>
        public override void EffectOnPlayer(Player who)
        {
            who.Deduct(25);
            who.Move(who, -3);
        }
    }

    /// <summary>
    /// A particular "chance" game square
    /// </summary>
    public class Chance_Square : Square
    {
        public Chance_Square(string name, int number):
            base(name, number)
        {

        }

        /// <summary>
        /// Moves forward 5 and adds 50, or moves back 5 and deducts 50
        /// </summary>
        /// <param name="who">The player</param>
        public override void EffectOnPlayer(Player who)
        {
            Die a_dice = new Die(2);
            int result = a_dice.Roll();

            if (result == 1)
            {
                who.Add(50);
                who.Move(who, 5);
            }
            else
            {
                who.Deduct(50);
                who.Move(who, -5);
            }

        }
    }
}
