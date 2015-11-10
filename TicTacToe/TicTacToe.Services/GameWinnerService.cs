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
            var winningSymbol = CheckForThreeInARowInHorizontalRow(gameBoard);
            if (winningSymbol == ' ')
            {
                winningSymbol = CheckForThreeInARowInVerticalRow(gameBoard);
            }
            return winningSymbol;
        }

        private static char CheckForThreeInARowInHorizontalRow(char[,] gameBoard)
        {
            var winningSymbol = ' ';

            var row1 = gameBoard[0, 0];
            var row2 = gameBoard[1, 0];
            var row3 = gameBoard[2, 0];
            if (row1 == row2 && row2 == row3)
            {
                winningSymbol = row1;
            }

            return winningSymbol;
        }

        private static char CheckForThreeInARowInVerticalRow(char[,] gameBoard)
        {
            var winningSymbol = ' ';

            var col1 = gameBoard[0, 0];
            var col2 = gameBoard[0, 1];
            var col3 = gameBoard[0, 2];
            if (col1 == col2 && col2 == col3)
            {
                return col1;
            }

            return winningSymbol;
        }
    }
}
