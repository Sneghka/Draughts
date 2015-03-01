using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLogic
{
    public class Board
    {
       private const int BOARD_SIZE = 8;

        public Square [] PossibleMoves(Draught draught)
        {
            var squares = new Square [2];
            var firstCoordHorizontal = draught.DraughtCoordinates.Horizontal + 1;
            var secondCoordHorizontal = draught.DraughtCoordinates.Horizontal - 1;
            int coordVertical;

            if (draught.DraughtColour == Colour.black)
            {
                coordVertical = draught.DraughtCoordinates.Vertical - 1;
                var firstMove = new Square(firstCoordHorizontal, coordVertical);
                if (firstMove.IsSquareTrue()) squares[0] = firstMove;
                var secondMove = new Square(secondCoordHorizontal, coordVertical);
                if (secondMove.IsSquareTrue()) squares[1] = secondMove;
            }

            if (draught.DraughtColour == Colour.white)
            {
                coordVertical = draught.DraughtCoordinates.Vertical + 1;
                var firstMove = new Square(firstCoordHorizontal, coordVertical);
                if (firstMove.IsSquareTrue()) squares[0] = firstMove;
                var secondMove = new Square(secondCoordHorizontal, coordVertical);
                if (secondMove.IsSquareTrue()) squares[1] = secondMove;
            }
            return squares;
        }
    }
}
