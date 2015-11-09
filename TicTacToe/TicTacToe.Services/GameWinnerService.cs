using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe.Services
{
    public class GameWinnerService: IGameWinnerService
    {
        public char Validate(char[,] gameBoard)
        {
            var col1 = gameBoard[0, 0];
            var col2 = gameBoard[0, 1];
            var col3 = gameBoard[0, 2];
            if (col1 == col2 && col2 == col3)
            {
                return col1;
            }
            return ' ';
        }
    }
}
