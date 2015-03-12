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

            var CoordinatesString = str.Substring(1);
            DraughtCoordinates = new Square(CoordinatesString);

        }

       public bool AreDraughtCoordinatesCorrect()
        {
            return
                (DraughtCoordinates.FirstCoordinate % 2 == DraughtCoordinates.SecondCoordinate % 2);
        }
    }
}
