using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLogic
{
    public class Board
    {

        public List<Move> PossibleMoves(Draught draught)
        {
            var possibleMovesForOneDraught = new List<Move>();
            var firstCoordinate1 = draught.DraughtCoordinates.FirstCoordinate + 1;
            var firstCoordinate2 = draught.DraughtCoordinates.FirstCoordinate - 1;
            int secondCoordinate = draught.DraughtCoordinates.SecondCoordinate + ChooseDraughtColour(draught.DraughtColour);
            foreach (var square in MovesForOneDraught(firstCoordinate1, firstCoordinate2, secondCoordinate))
            {
                var move = new Move(draught, square);
                possibleMovesForOneDraught.Add(move);
            }
            return possibleMovesForOneDraught;
        }


        public int ChooseDraughtColour(Colour colour)
        {
            return colour == Colour.white ? 1 : -1;
        }

        public List<Square> MovesForOneDraught(int firstCoord1, int firstCoord2, int secondCoord)
        {
            var moves = new List<Square>();
            var firstMove = new Square(firstCoord1, secondCoord);
            if (firstMove.IsSquareTrue()) moves.Add(firstMove);
            var secondMove = new Square(firstCoord2, secondCoord);
            if (secondMove.IsSquareTrue()) moves.Add(secondMove);
            return moves;
        }
    }
}
