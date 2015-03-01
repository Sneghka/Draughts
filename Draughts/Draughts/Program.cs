using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BussinessLogic;

namespace Draughts
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a position of draught");
            string line = Console.ReadLine();
            var draught = new Draught(line);
            if (!draught.AreDraughtCoordinatesCorrect())
            {
                Console.WriteLine("Incorrect coordinates of draught");
                Console.ReadKey();
                return;
            }
            var board = new Board();
            var turns = board.PossibleMoves(draught);
            foreach (var turn in turns)
            {
                if(turn != null)
                Console.WriteLine("{0} = > {1}{2}",line, turn.NameVertical(turn.Horizontal),turn.Vertical);
            }

            Console.ReadLine();
        }
    }
}
