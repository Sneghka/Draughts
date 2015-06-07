using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLogic
{
    public class SetOfDraughts
    {
        private List<Draught> draughts = new List<Draught>();

        public SetOfDraughts(string line)
        {
            var lines = line.Split(' ');
            foreach (var str in lines)
            {
                var draught = new Draught(str);
                draughts.Add(draught);
            }
        }

        public bool AreAllDraughtsCoordinatesCorrect()
        {
            foreach (var draught in draughts)
            {
                if (!draught.DraughtCoordinates.IsSquareTrue())
                {
                    return false;
                }
            }
            return true;
        }

        public bool ContainSquare(Square square)
        {
            foreach (var draught in draughts)
            {
                if (draught.DraughtCoordinates.AreSquaresEqual(square))
                    return true;
            }
            return false;
        }

        public List<Move> MovesForSetOfDraughts(Colour colour)
        {
            var moves = new List<Move>();
            foreach (var draught in draughts)
            {
                var board = new Board();
                if (draught.DraughtColour == colour)
                    moves.AddRange(board.PossibleMoves(draught));
            }
            return moves;
        }

        public Draught GetDraughtFromSquare(Square sq)
        {
            foreach (var draught in draughts)
            {
                if (draught.DraughtCoordinates.AreSquaresEqual(sq)) return draught;
            }
            return null;
        }

        public List<Move> PossibleMovesForSetOfDraughts(Colour colour)
        {
            var possibleMovesForSetOfDraughts = new List<Move>();
            var moves = MovesForSetOfDraughts(colour);
            foreach (var move in moves)
                if (!ContainSquare(move.Square)) 
                    possibleMovesForSetOfDraughts.Add(move);
                else
                {
                    if ((!move.Draught.DraughtsColourAreEqual(GetDraughtFromSquare(move.Square))) && (!ContainSquare(move.Capturing().Square)))
                        possibleMovesForSetOfDraughts.Add(move.Capturing());
                }
            return possibleMovesForSetOfDraughts;
        }
    }
}

