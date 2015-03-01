using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLogic
{

    public class Square
    {
        private string NamesOfHorizontals = "abcdefgh";
        public int Horizontal { get; private set; }

        public int Vertical { get; private set; }

        public Square(string line)
        {
            var horizontalChar = line[0];

            Horizontal = NamesOfHorizontals.IndexOf(horizontalChar) + 1;
            
            Vertical = Convert.ToInt32(line.Substring(1));
        }

        public Square(int x, int y)
        {
            Horizontal = x;
            Vertical = y;
        }

        public char NameVertical(int i)
        {
            var nameVertical = NamesOfHorizontals[i - 1];
            return nameVertical;
        }

        public bool IsSquareTrue()
        {
            return
              (Vertical > 0 && Vertical < 9) && (Horizontal > 0 && Horizontal < 9);
        }
    }
}
