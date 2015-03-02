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
            var firstMove = moves[0];
            var secondMove = moves[1];
            Assert.AreEqual(8, moves[0].SecondCoordinate);
            Assert.AreEqual(8, moves[0].FirstCoordinate);
            Assert.AreEqual(8, moves[1].SecondCoordinate);
            Assert.AreEqual(6, moves[1].FirstCoordinate);
        }
    }
}
