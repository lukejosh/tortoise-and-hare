﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Square_Class_Library;

namespace Board_Class_Library {

    public static class Board {
        public const int NUMBER_OF_SQUARES = 56;
        public const int START_SQUARE = 0;
        public const int FINISH_SQUARE = 55;
        public const int PLAYING_SQUARES = 54;

        private static Square[] gameBoard = new Square[NUMBER_OF_SQUARES];

        public static void SetUpBoard() {
            for (int i = 1; i <= PLAYING_SQUARES; i++)
            {
                if (i % 10 == 0)
                {
                    gameBoard[i] = new Lose_Square(i.ToString(), i);
                }
                else if (i % 5 == 0)
                {
                    gameBoard[i] = new Win_Square(i.ToString(), i);
                }

                else if (i % 6 == 0)
                {
                    gameBoard[i] = new Chance_Square(i.ToString(), i);
                }

                else
                {
                    gameBoard[i] = new Square(i.ToString(), i);
                }
            }

            gameBoard[START_SQUARE] = new Square("Start", START_SQUARE);
            gameBoard[FINISH_SQUARE] = new Square("Finish", FINISH_SQUARE);
        }

        public static Square GetGameBoardSquare(int number)
        {
            if (number > FINISH_SQUARE || number < START_SQUARE)
            {
                throw new System.IndexOutOfRangeException();
            }
            return gameBoard[number];
        }

        public static Square StartSquare()
        {
            return gameBoard[START_SQUARE];
        }

        public static Square NextSquare(int number)
        {
            if (number > FINISH_SQUARE || number < START_SQUARE)
            {
                throw new System.IndexOutOfRangeException();
            }

            return gameBoard[number];

        }


    }
}
