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
    public class UnitTestsHelper
    {
        [Test]
        public void DraughtColourWhite()
        {
            var input = "wb2";
            var draught = new Draught(input);
            Assert.AreEqual(Colour.white, Helper.DraughtColour(input[0]));
            Assert.AreEqual(Colour.white, draught.DraughtColour);
        }

        [Test]
        public void DraughtColourBlack()
        {
            var input = "bc3";
            var draught = new Draught(input);
            Assert.AreEqual(Colour.black, Helper.DraughtColour(input[0]));
            Assert.AreEqual(Colour.black, draught.DraughtColour);
        }

        [Test]
        public void DraughtColourLetterCorrect()
        {
            var input1 = 'w';
            var input2 = 'b';
            Assert.AreEqual(true, Helper.IsColourLetterCorrect(input1) );
            Assert.AreEqual(true, Helper.IsColourLetterCorrect(input2));
        }

        [Test]
        public void DraughtColourLetterIncorrect()
        {
            var input = 'z';
            Assert.AreEqual(false, Helper.IsColourLetterCorrect(input));
        }
    }
}
