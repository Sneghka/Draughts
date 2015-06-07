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
    public class UnitTestsSetOfDraughts
    {
        [Test]
        public void TestAllDraughtsCoordinatesCorrect()
        {
            var input = "wc3 bb6 bc7";
            var setOfDraughts = new SetOfDraughts(input);
            Assert.AreEqual(true, setOfDraughts.AreAllDraughtsCoordinatesCorrect());
        }

        [Test]
        public void TestDraughtsCoordinatesIncorrect()
        {
            var input = "wc0 bb6 bc7";
            var setOfDraughts = new SetOfDraughts(input);
            Assert.AreEqual(false, setOfDraughts.AreAllDraughtsCoordinatesCorrect());
        }

        [Test]
        public void TestMovesForSetOfDraughts()
        {
            var input = "wc3 bd4";
            var setOfDraught = new SetOfDraughts(input);
            Colour colour = Colour.black;
            var movesForSet = setOfDraught.MovesForSetOfDraughts(colour);
            Assert.AreEqual(5, movesForSet[0].Square.FirstCoordinate);
            Assert.AreEqual(3, movesForSet[0].Square.SecondCoordinate);
            Assert.AreEqual(3, movesForSet[1].Square.FirstCoordinate);
            Assert.AreEqual(3, movesForSet[1].Square.SecondCoordinate);
            Assert.AreEqual(2, movesForSet.Count);
        }

        [Test]

        public void TestPossibleMovesForSetOfDraughts()
        {
            var input = "wc3 wa3 bb4";
            var setOfDraught = new SetOfDraughts(input);
            Colour colour = Colour.white;
            var possibleMoves = setOfDraught.PossibleMovesForSetOfDraughts(colour);
            Assert.AreEqual(1, possibleMoves.Count);
            Assert.AreEqual(4, possibleMoves[0].Square.FirstCoordinate);
            Assert.AreEqual(4, possibleMoves[0].Square.SecondCoordinate);
        }

        [Test]

        public void TestListContainsSquare()
        {
            var input = "wc3 wa3 bb4";
            var setOfDraught = new SetOfDraughts(input);
            var square = new Square("b4");
            Assert.AreEqual(true, setOfDraught.ContainSquare(square));

        }

        [Test]

        public void TestListDoesNotContainsSquare()
        {
            var input = "wc3 wa3 bb4";
            var setOfDraught = new SetOfDraughts(input);
            var square = new Square("d4");
            Assert.AreEqual(false, setOfDraught.ContainSquare(square));

        }
        
        [Test]
        public void GetDraughtColourFromSquare()
        {
            var input = "wc3 wa3 bb4";
            var setOfDraught = new SetOfDraughts(input);
            var square = new Square("b4");
           // var draught = setOfDraught.GetDraughtFromSquare(square);
            Assert.AreEqual(Colour.black,setOfDraught.GetDraughtFromSquare(square).DraughtColour);

            //Assert.AreEqual("bb4", setOfDraught.GetDraughtFromSquare(square).ToString());

        }
    }
}
