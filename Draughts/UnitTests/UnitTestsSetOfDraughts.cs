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
        public void TestGetCoordinatesSetOfDraught()
        {
            var input = "wc3 bb6 bc7";
            var setOfDraught = new SetOfDraughts(input);
            var coordinates = setOfDraught.GetCoordinatesSetOfDraught();
            var square1 = new Square("c3");
            var square2 = new Square("b6");
            var square3 = new Square("c7");
            Assert.AreEqual(square1.FirstCoordinate, coordinates[0].FirstCoordinate);
            Assert.AreEqual(square1.SecondCoordinate, coordinates[0].SecondCoordinate);
            Assert.AreEqual(square2.FirstCoordinate, coordinates[1].FirstCoordinate);
            Assert.AreEqual(square2.SecondCoordinate, coordinates[1].SecondCoordinate);
            Assert.AreEqual(square3.FirstCoordinate, coordinates[2].FirstCoordinate);
            Assert.AreEqual(square3.SecondCoordinate, coordinates[2].SecondCoordinate);
        }

        [Test]
        public void TestMovesForSetOfDraughts()
        {
            var input = "wc3 bd4";
            var setOfDraught = new SetOfDraughts(input);
            Colour colour = Colour.black;
            var movesForSet = setOfDraught.MovesForSetOfDraughts(colour);
            Assert.AreEqual(5, movesForSet[0].FirstCoordinate);
            Assert.AreEqual(3, movesForSet[0].SecondCoordinate);
            Assert.AreEqual(3, movesForSet[1].FirstCoordinate);
            Assert.AreEqual(3, movesForSet[1].SecondCoordinate);
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
            Assert.AreEqual(4, possibleMoves[0].FirstCoordinate);
            Assert.AreEqual(4, possibleMoves[0].SecondCoordinate);
        }
    }
}
