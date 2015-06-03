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
            Console.WriteLine("Enter positions of draughts");
            string line = Console.ReadLine();
            Console.WriteLine("Enter draught's colour which is going to move now.");
            Console.WriteLine("Two letters are possible 'w'- white or 'b' - black");
            string str = Console.ReadLine();
            if (!Helper.IsColourLetterCorrect(str[0]))
            {
                Console.WriteLine("Incorret colour's letter");
                Console.ReadKey();
                return;
            }
            var setOfDraughts = new SetOfDraughts(line);
            if (!setOfDraughts.AreAllDraughtsCoordinatesCorrect())
            {
                Console.WriteLine("Incorrect coordinates of draught");
                Console.ReadKey();
                return;
            }

            var possibleMovesForSetOfDraughts = setOfDraughts.PossibleMovesForSetOfDraughts(Helper.DraughtColour(str[0]));
            if (possibleMovesForSetOfDraughts.Count == 0)
            {
                Console.WriteLine("Possible moves don't exist");
                Console.ReadKey();
                return;
            }

            
            foreach (var move in possibleMovesForSetOfDraughts)
                    Console.WriteLine("{0} = > {1}{2}",move.Draught.GetStringNameOfDraught(move.Draught), move.Square.NameVertical(move.Square.FirstCoordinate), move.Square.SecondCoordinate);
            

            Console.ReadKey();
        }
    }
}
