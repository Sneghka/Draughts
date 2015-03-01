using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BussinessLogic;
using NUnit.Framework;

namespace UnitTests
{
    [TestFixture]
    public class UnitTestsSquare
    {
        [Test]
        public void NumberOfVerticalA()
        {
            var input = "a3";
            var vertical = new Square(input);
            Assert.AreEqual(1,vertical.Horizontal);
        }
        [Test]
        public void NumberOfVerticalG()
        {
            var input = "g5";
            var vertical = new Square(input);
            Assert.AreEqual(7, vertical.Horizontal);
        }

        [Test]
        public void NumberOfHorizontal8()
        {
            var input = "g8";
            var horizontal = new Square(input);
            Assert.AreEqual(8, horizontal.Vertical);
        }

        [Test]
        public void NumberOfHorizontal1()
        {
            var input = "a1";
            var horizontal = new Square(input);
            Assert.AreEqual(1, horizontal.Vertical);
        }

        [Test]
        public void TestNameVertical()
        {
            var input = "b2";
            var vertical = new Square(input);
            Assert.AreEqual('b', vertical.NameVertical(vertical.Horizontal));
        }

        [Test]

        public void TestIsSquareTrueOne()
        {
            var input = "wh4";
            var draught = new Draught(input);
            var board = new Board();
            var moves = board.PossibleMoves(draught);
            var firstmove = moves[0];
            var secondmove = moves[1];
            Assert.AreEqual(null, moves[0]);
            Assert.AreEqual(true, secondmove.IsSquareTrue());
        }

        [Test]
        public void TestIsSquareTrueTwo()
        {
            var input = "wh8";
            var draught = new Draught(input);
            var board = new Board();
            var moves = board.PossibleMoves(draught);
            var firstmove = moves[0];
            var secondmove = moves[1];
            Assert.AreEqual(null, moves[0]);
            Assert.AreEqual(null, moves[1]);
        }

        [Test]
        public void TestIsSquareTrueThree()
        {
            var input = "bd6";
            var draught = new Draught(input);
            var board = new Board();
            var moves = board.PossibleMoves(draught);
            var firstmove = moves[0];
            var secondmove = moves[1];
            Assert.AreEqual(true, firstmove.IsSquareTrue());
            Assert.AreEqual(true, secondmove.IsSquareTrue());
        }
    }
}
