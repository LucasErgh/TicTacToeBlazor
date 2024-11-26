namespace TicTacToeBlazor.Components.Pages
{
    public class TicTacToeBoard
    {
        string[,] board;
        public TicTacToeBoard()
        {
            board = new string[3,3];
            Enumerable.Repeat(' ', 9).ToArray();
        }
        public string getCell(int row, int col){
            return board[row,col];
        }
        public void setCell(int row, int col){
            board[row,col] = "X";
        }
    }
}

