using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLogic
{
    public enum Colour { white, black };
    public static class Helper
    {
        public static Colour DraughtColour(char colour)
        {
            if (colour == 'w') return Colour.white;
            return Colour.black;
        }

        public static bool IsColourLetterCorrect(char colour)
        {
            return
              colour == 'w' || colour == 'b';
        }
    }
}
