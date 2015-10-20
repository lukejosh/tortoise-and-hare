using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Board_Class_Library;
using Player_Class_Library;
using Square_Class_Library;

namespace HareAndTortoise {
    public partial class HareAndTortoise_Form : Form {

        const int NUM_OF_ROWS = 8;
        const int NUM_OF_COLUMNS = 7;

        public HareAndTortoise_Form() {
            InitializeComponent();
            HareAndTortoise_Game.SetUpGame();
            ResizeGameBoard();
            SetUpGuiGameBoard();
        }


        private void SetUpGuiGameBoard() {
            for (int i = Board.START_SQUARE; i <= Board.FINISH_SQUARE; i++)
            {
                Square current_square = Board.GetGameBoardSquare(i);
                SquareControl current_squarecontrol = new SquareControl(current_square, HareAndTortoise_Game.Players);
                if (current_square.GetName() == "Finish" || current_square.GetName() == "Start")
                {
                    current_squarecontrol.BackColor = Color.BurlyWood;
                }

            }
        }

        private static void MapSquareToTable(int number, out int row, out int column)
        {
            if(number == 0)
            {
                row = 7;
                column = 0;
            }
            else{
                double rowcalc = (double)number / 6.0;
                row = 7 - (int)Math.Floor(rowcalc);
                column = 
                }
        }
        
        // for each square that is on the game board 
        //      obtain the Square object associated with the square
		//      create a SquareControl object (ie call Constructor)
        //      if the square is either Start square or Finish square
		//         set the BackColor of the SquareControl to BurlyWood
		//      otherwise do not set the BackColor
		//      Determine the correct position (cell) in the TablelayoutPanel of the square
		//      Add the SquareControl object to that position of the TableLayoutPanel
        
        }//end SetUpGuiGameBoard()



        private void ResizeGameBoard() {
            const int SQUARE_SIZE = SquareControl.SQUARE_SIZE;
            int currentHeight = gameBoardPanel.Size.Height;
            int currentWidth = gameBoardPanel.Size.Width;
            int desiredHeight = SQUARE_SIZE * NUM_OF_ROWS;
            int desiredWidth = SQUARE_SIZE * NUM_OF_COLUMNS;
            int increaseInHeight = desiredHeight - currentHeight;
            int increaseInWidth = desiredWidth - currentWidth;
            this.Size += new Size(increaseInWidth, increaseInHeight);
            gameBoardPanel.Size = new Size(desiredWidth, desiredHeight);
        } //end ResizeGameBoard
 


    }//end class 
} //end namespace
