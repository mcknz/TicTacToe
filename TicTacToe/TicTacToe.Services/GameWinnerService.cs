using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe.Services
{
    public class GameWinnerService: IGameWinnerService
    {
        private const char SymbolForNoWinner = ' ';

        public char Validate(char[,] gameBoard)
        {
            var winningSymbol = CheckForThreeInARowInHorizontalRow(gameBoard);
            if (winningSymbol == SymbolForNoWinner)
            {
                winningSymbol = CheckForThreeInARowInVerticalRow(gameBoard);
            }
            if (winningSymbol == SymbolForNoWinner)
            {
                winningSymbol = CheckForThreeInARowDiagonally(gameBoard);
            }
            return winningSymbol;
        }

        private static char CheckForThreeInARowInHorizontalRow(char[,] gameBoard)
        {
            var row1 = gameBoard[0, 0];
            var row2 = gameBoard[1, 0];
            var row3 = gameBoard[2, 0];
            if (row1 == row2 && row2 == row3)
            {
                return row1;
            }

            return SymbolForNoWinner;
        }

        private static char CheckForThreeInARowInVerticalRow(char[,] gameBoard)
        {
            var col1 = gameBoard[0, 0];
            var col2 = gameBoard[0, 1];
            var col3 = gameBoard[0, 2];
            if (col1 == col2 && col2 == col3)
            {
                return col1;
            }

            return SymbolForNoWinner;
        }

        private static char CheckForThreeInARowDiagonally(char[,] gameBoard)
        {
            var cell1 = gameBoard[0, 0];
            var cell2 = gameBoard[1, 1];
            var cell3 = gameBoard[2, 2];
            if (cell1 == cell2 && cell2 == cell3)
            {
                return cell1;
            }

            return SymbolForNoWinner;
        }
    }
}
