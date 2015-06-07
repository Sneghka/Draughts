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
    public class UnitTestsDraught
    {
       

        [Test]
        public void DraughtBlack()
        {
            var input = "bd8";
            var draught = new Draught(input);
            Assert.AreEqual(Colour.black, draught.DraughtColour);
            Assert.AreEqual(4, draught.DraughtCoordinates.FirstCoordinate);
            Assert.AreEqual(8, draught.DraughtCoordinates.SecondCoordinate);
        }

        [Test]
        public void DraughtWhite()
        {
            var input = "wg3";
            var draught = new Draught(input);
            Assert.AreEqual(Colour.white, draught.DraughtColour);
            Assert.AreEqual(7, draught.DraughtCoordinates.FirstCoordinate);
            Assert.AreEqual(3, draught.DraughtCoordinates.SecondCoordinate);
        }

        [Test]
        public void TestDraughtCoodinatesCorrect()
        {
            var input = "wc3";
            var draught = new Draught(input);
            Assert.AreEqual(true, draught.DraughtCoordinates.IsSquareTrue());
        }

        [Test]
        public void TestDraughtCoodinatesIncorrect()
        {
            var input = "wc2";
            var draught = new Draught(input);
            Assert.AreEqual(false, draught.DraughtCoordinates.IsSquareTrue());
        }

        [Test]
        public void DraughtsColourAreEqual()
        {
            var input1 = "wc2";
            var input2 = "wb4";
            var draught = new Draught(input1);
            var draught1 = new Draught(input2);
            Assert.AreEqual(true, draught.DraughtsColourAreEqual(draught1));
        }

        [Test]
        public void DraughtsColourAreNotEqual()
        {
            var input1 = "wc2";
            var input2 = "bb4";
            var draught = new Draught(input1);
            var draught1 = new Draught(input2);
            Assert.AreEqual(false, draught.DraughtsColourAreEqual(draught1));
        }
    }
}
