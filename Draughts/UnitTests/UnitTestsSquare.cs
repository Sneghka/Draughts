﻿using System;
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
            Assert.AreEqual(1, vertical.FirstCoordinate);
        }
        [Test]
        public void NumberOfVerticalG()
        {
            var input = "g5";
            var vertical = new Square(input);
            Assert.AreEqual(7, vertical.FirstCoordinate);
        }

        [Test]
        public void NumberOfHorizontal8()
        {
            var input = "g8";
            var horizontal = new Square(input);
            Assert.AreEqual(8, horizontal.SecondCoordinate);
        }

        [Test]
        public void NumberOfHorizontal1()
        {
            var input = "a1";
            var horizontal = new Square(input);
            Assert.AreEqual(1, horizontal.SecondCoordinate);
        }

        [Test]
        public void TestNameVertical()
        {
            var input = "b2";
            var vertical = new Square(input);
            Assert.AreEqual('b', vertical.NameVertical(vertical.FirstCoordinate));
        }

        [Test]

        public void TestSquareIsNotTrue1()
        {
            var square = new Square("h4");
            var move = new Square(square.FirstCoordinate + 1, square.SecondCoordinate + 1);
            Assert.AreEqual(false, move.IsSquareTrue());

        }

        [Test]

        public void TestSquareIsNotTrue2()
        {
            var square = new Square("h3");
            Assert.AreEqual(false, square.IsSquareTrue());

        }

        [Test]
        public void TestSquareIsTrue()
        {
            var square = new Square("d6");
            var move = new Square(square.FirstCoordinate + 1, square.SecondCoordinate + 1);
            Assert.AreEqual(true, move.IsSquareTrue());
        }

        [Test]
        public void TestSquaresAreEqual()
        {
            var square1 = new Square("d6");
            var square2 = new Square("d6");
            Assert.AreEqual(true, square1.AreSquaresEqual(square2));
        }
    }
}
