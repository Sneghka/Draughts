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

        public string GetStringNameOfDraught(Draught draught)
        {
            if (draught.DraughtColour == Colour.white)
                return "w" + draught.DraughtCoordinates.NameVertical(draught.DraughtCoordinates.FirstCoordinate) +
                       draught.DraughtCoordinates.SecondCoordinate;
            else
            {
                return "b" + draught.DraughtCoordinates.NameVertical(draught.DraughtCoordinates.FirstCoordinate) +
                         draught.DraughtCoordinates.SecondCoordinate;   
            }
        }
    }
}
