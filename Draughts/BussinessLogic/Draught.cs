using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLogic
{
    public enum Colour { white, black };

    public class Draught
    {

        public Colour DraughtColour { get; private set; }

        public Square DraughtCoordinates { get; private set; }


        public Draught(string str)
        {
            var draughtColourChar = str[0];
            switch (draughtColourChar)
            {
                case 'w':
                    DraughtColour = Colour.white;
                    break;
                case 'b':
                    DraughtColour = Colour.black;
                    break;
            }

            var CoordinatesString = str.Substring(1);
            DraughtCoordinates = new Square(CoordinatesString);

        }

        public bool AreDraughtCoordinatesCorrect()
        {
            return
                (DraughtCoordinates.Horizontal % 2 != 0 && DraughtCoordinates.Vertical % 2 != 0) ||
                  (DraughtCoordinates.Horizontal % 2 == 0 && DraughtCoordinates.Vertical % 2 == 0);
        }
    }
}
