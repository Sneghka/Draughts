using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLogic
{

    public class Draught
    {

        public Colour DraughtColour { get; private set; }

        public Square DraughtCoordinates { get; private set; }


        public Draught(string str)
        {
            var draughtColourChar = str[0];
            DraughtColour = Helper.DraughtColour(draughtColourChar);

            var coordinatesString = str.Substring(1);
            DraughtCoordinates = new Square(coordinatesString);
        }

        public override string ToString()
        {
            var color = DraughtColour == Colour.white ? "w" : "b";
            return color + DraughtCoordinates.NameVertical(DraughtCoordinates.FirstCoordinate) +
                       DraughtCoordinates.SecondCoordinate;
        }


        public bool DraughtsColourAreEqual(Draught draught)
        {
            return DraughtColour == draught.DraughtColour;
        }
    }
}

