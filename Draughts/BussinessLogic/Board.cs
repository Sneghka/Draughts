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

        public List<Square> PossibleMoves(Draught draught)
        {
            var possibleMoves = new List<Square>();
            var firstCoordinate_1 = draught.DraughtCoordinates.FirstCoordinate + 1;
            var firstCoordinate_2 = draught.DraughtCoordinates.FirstCoordinate - 1;
            int secondCoordinate;

            if (draught.DraughtColour == Colour.black)
            {
                secondCoordinate = draught.DraughtCoordinates.SecondCoordinate - 1;
                return Moves(firstCoordinate_1, firstCoordinate_2, secondCoordinate);
            }
            secondCoordinate = draught.DraughtCoordinates.SecondCoordinate + 1;
            return Moves(firstCoordinate_1, firstCoordinate_2, secondCoordinate);
        }

        public List<Square> Moves(int firstCoord_1, int firstCoord_2, int secondCoord)
        {
            var moves = new List<Square>();
            var firstMove = new Square(firstCoord_1, secondCoord);
            if (firstMove.IsSquareTrue()) moves.Add(firstMove);
            var secondMove = new Square(firstCoord_2, secondCoord);
            if (secondMove.IsSquareTrue()) moves.Add(secondMove);
            return moves;
        }
    }
}
