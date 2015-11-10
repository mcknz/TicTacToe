using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using TicTacToe.Services;

namespace TicTacToe.UnitTests
{
    [TestFixture]
    public class GameWinnerServiceTests
    {
        private IGameWinnerService _gameWinnerService;
        private char[,] _gameBoard;

        [SetUp]
        public void SetupTests()
        {
            _gameWinnerService = new GameWinnerService();
            _gameBoard = new char[3, 3] {
                {' ',' ',' '},
                {' ',' ',' '},
                {' ',' ',' '}
            };
        }

        [Test]
        public void NeitherPlayerHasThreeInARow()
        {
            const char expected = ' ';            
            var actual = _gameWinnerService.Validate(_gameBoard);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void PlayerWithAllSpacesInTopRowIsWinner()
        {
            const char expected = 'X';
            for (var col = 0; col < 3; col++)
            {
                _gameBoard[0, col] = expected;
            }
            var actual = _gameWinnerService.Validate(_gameBoard);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void PlayerWithAllSpacesInFirstColIsWinner()
        {
            const char expected = 'X';
            for (var row = 0; row < 3; row++)
            {
                _gameBoard[row, 0] = expected;
            }
            var actual = _gameWinnerService.Validate(_gameBoard);
            Assert.AreEqual(expected, actual);
        }
    }
}
