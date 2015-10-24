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
        public static int current_selected_number = 6;

        public HareAndTortoise_Form() {
            InitializeComponent();
            HareAndTortoise_Game.SetUpGame();
            ResizeGameBoard();
            SetUpGuiGameBoard();
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.DataSource = HareAndTortoise_Game.Players;
            updateSquare();
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

                int row, column;
                MapSquareToTable(i, out row, out column);
                gameBoardPanel.Controls.Add(current_squarecontrol, column, row);

                NumberOfPlayers.SelectedIndex = 4;
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
                row = 7 - (int)Math.Floor((double)number / 7.0);

                if (row % 2 == 0)
                {
                    column = 6 - number % 7;
                }
                else
                {
                    column = number % 7;
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

        private void updateSquare(bool update = true, int number_of_players = HareAndTortoise_Game.numberOfPlayers)
        {
            for (int i = 0; i < number_of_players; i++)
            {
                int current_location = HareAndTortoise_Game.Players[i].Location.GetNumber();
                int row, column;
                MapSquareToTable(current_location, out row, out column);
                SquareControl square = (SquareControl)gameBoardPanel.GetControlFromPosition(column, row);
                square.ContainsPlayers[i] = update;
            }
            gameBoardPanel.Invalidate(true);

        }

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
        }

        private void UpdateDataGridView()
        {
            HareAndTortoise_Game.Players.ResetBindings();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void RollDice_Click(object sender, EventArgs e)
        {
            Reset.Enabled = false;
            RollDice.Enabled = false;
            NumberOfPlayers.Enabled = false;
            updateSquare(false, current_selected_number);
            HareAndTortoise_Game.MovePlayers(current_selected_number);
            if (HareAndTortoise_Game.isOver)
            {
                NumberOfPlayers.Enabled = true;
            }
            else
            {
                RollDice.Enabled = true;
            }
            updateSquare(true, current_selected_number);
            UpdateDataGridView();
            Reset.Enabled = true;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            DialogResult response = MessageBox.Show("Do you really want to exit?", "Are you sure?", MessageBoxButtons.YesNo);
            if (response == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            NumberOfPlayers.Enabled = true;
            RollDice.Enabled = true;
            updateSquare(false, current_selected_number);
            current_selected_number = NumberOfPlayers.SelectedIndex + 2;
            HareAndTortoise_Game.ResetPlayers(current_selected_number);
            updateSquare(true, current_selected_number);
            UpdateDataGridView();
        }

        private void NumberOfPlayers_SelectedIndexChanged(object sender, EventArgs e)
        {
            //int index = NumberOfPlayers.SelectedIndex;
        } //end ResizeGameBoard
 


    }//end class 
} //end namespace
