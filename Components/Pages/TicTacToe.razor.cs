﻿using System.Reflection.Metadata.Ecma335;

namespace TicTacToeBlazor.Components.Pages
{
    public class TicTacToeBoard
    {
        public bool gameOver { get; set; } = false;
        char[,] board;
        public TicTacToeBoard()
        {
            board = new char[3,3];
            clear();
        }
        public void clear(){
            // Enumerable.Repeat("O", 9).ToArray();
            for(int i = 0; i < 3; ++i){
                for(int j = 0; j < 3; ++j){
                    board[i,j]=' '; // setting it to space for empty cell
                }
            }
        }
        public char getCell(int row, int col){
            return board[row,col];
        }
        public void setCell(int row, int col, char val){
            board[row,col] = val;
        }
        public void AIMove(){

        }
        public int checkForWin(){
            bool tie = true;
            gameOver = true;
            // check for win in rows & columns and check for tie
            for(int i = 0; i < 3; ++i){
                // check for rows
                if (board[i, 1] == board[i, 0] && board[i, 2] == board[i, 0]){
                    if (board[i, 0] == 'X') return 1;
                    else if (board[i, 0] == 'O') return 2;
                }   
                // check for columns
                if(board[0, i] == board[1, i] && board[2, i] == board[0, i]){
                    if (board[0, i] == 'X') return 1;
                    else if (board[0, i] == ')') return 2;
                }
                // check if any cells are empty to determine if the game is finished yet
                for (int j = 0; j < 3; ++j){
                    if(board[i,j] == ' ') tie = false; 
                }
            }
            // check for diagnals
            if (board[0, 0] == board[1,1] && board[0,0] == board[2,2] || 
                (board[0,2] == board[1, 1] && board[0,2] == board[2, 0])){
                if (board[1,1] == 'X') return 1;
                else if (board[1,1] == 'O') return 2;
            }
            if (tie){ 
                return 0; 
            } else {
                gameOver = false;
                return -1;
            }
        }
    }
}

