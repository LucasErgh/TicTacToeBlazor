namespace TicTacToeBlazor.Components.Pages
{
    public class TicTacToeBoard
    {
        string[,] board;
        public TicTacToeBoard()
        {
            board = new string[3,3];
            clear();
        }
        public void clear(){
            // Enumerable.Repeat("O", 9).ToArray();
            for(int i = 0; i < 3; ++i){
                for(int j = 0; j < 3; ++j){
                    board[i,j]="T"; // setting it to T for test
                }
            }
        }
        public string getCell(int row, int col){
            return board[row,col];
        }
        public void setCell(int row, int col){
            board[row,col] = "X";
        }
    }
}

