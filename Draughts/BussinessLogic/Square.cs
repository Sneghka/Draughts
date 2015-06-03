using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLogic
{

    public class Square
    {
        private const string NamesOfFirstCoordinates = "abcdefgh";

        private const int BOARD_SIZE = 8;
        public int FirstCoordinate { get; private set; }

        public int SecondCoordinate { get; private set; }

        public Square(string line)
        {
            var firstCoordinateChar = line[0];

            FirstCoordinate = NamesOfFirstCoordinates.IndexOf(firstCoordinateChar) + 1;
            
            SecondCoordinate = Convert.ToInt32(line.Substring(1));
        }

        public Square(int x, int y)
        {
            FirstCoordinate = x;
            SecondCoordinate = y;
        }

        public char NameVertical(int i)
        {
            var nameFirstCoordinate = NamesOfFirstCoordinates[i - 1];
            return nameFirstCoordinate;
        }

        public bool IsSquareTrue()
        {
            return
              (SecondCoordinate > 0 && SecondCoordinate <= BOARD_SIZE) && (FirstCoordinate > 0 && FirstCoordinate <= BOARD_SIZE) && FirstCoordinate % 2 == SecondCoordinate % 2;
        }

        public bool AreSquaresEqual(Square square)
        {
            return
                FirstCoordinate == square.FirstCoordinate &&
                SecondCoordinate == square.SecondCoordinate;
        }
    }
}
