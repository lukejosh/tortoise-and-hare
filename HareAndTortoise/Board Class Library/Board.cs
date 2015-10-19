using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Square_Class_Library;

namespace Board_Class_Library {

    public static class Board {
        const int NUMBER_OF_SQUARES = 56;
        const int START_SQUARE = 0;
        const int FINISH_SQUARE = 55;
        const int PLAYING_SQUARES = 54;

        private static Square[] gameBoard = new Square[NUMBER_OF_SQUARES];

        public static void SetUPBoard() {
            for (int i = 1; i <= PLAYING_SQUARES; i++)
            {
                if (i % 10 == 0)
                {
                    //Lose
                }
                else if (i % 5 == 0)
                {
                    //Win
                }
            }
        }

        public static Square GetGameBoardSquare(int number)
        {
            return 0;
        }

    }
}
