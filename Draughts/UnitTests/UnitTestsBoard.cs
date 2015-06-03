using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;
using BussinessLogic;
using NUnit.Framework;

namespace UnitTests
{
    [TestFixture]
    public class UnitTestsBoard
    {
        [Test]
        public void TestPossibleTurns()
        {
            var input = "wg7";
            var draught = new Draught(input);
            var board = new Board();
            var moves = board.PossibleMoves(draught);
            var firstMove = moves[0].Square;
            var secondMove = moves[1].Square;
            Assert.AreEqual(8, moves[0].Square.SecondCoordinate);
            Assert.AreEqual(8, moves[0].Square.FirstCoordinate);
            Assert.AreEqual(8, moves[1].Square.SecondCoordinate);
            Assert.AreEqual(6, moves[1].Square.FirstCoordinate);
        }
    }
}
