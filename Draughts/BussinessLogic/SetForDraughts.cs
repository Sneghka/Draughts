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
                if (!draught.AreDraughtCoordinatesCorrect())
                {
                    return false;
                }
            }
            return true;
        }

        public List<Square> GetCoordinatesSetOfDraught()
        {
            var coordinates = new List<Square>();
            foreach (var draught in draughts) coordinates.Add(draught.DraughtCoordinates);
            return coordinates;
        }

        public List<Square> MovesForSetOfDraughts(Colour colour) 
        {
            var moves = new List<Square>();
            foreach (var draught in draughts)
            {
                var board = new Board();
                if (draught.DraughtColour == colour)
                    moves.AddRange(board.PossibleMoves(draught));
            }
            return moves;
        }

        public List<Square> PossibleMovesForSetOfDraughts(Colour colour) 
        {
            var possibleMovesForSetOfDraughts = new List<Square>();
            foreach (var move in MovesForSetOfDraughts(colour))
            {
                if (!Helper.IsListContainSquare(move, GetCoordinatesSetOfDraught()))
                    possibleMovesForSetOfDraughts.Add(move);
            }
            return possibleMovesForSetOfDraughts;
        }
    }
}
