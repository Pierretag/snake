using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    public class Coords
    {
        public int x, y;

        public Coords(){}

        public Coords(int p1, int p2)
        {
            x = p1;
            y = p2;

        }

       static public void CoordsCopy(Coords c1, Coords c2)
        {
            c1.x = c2.x;
            c1.y = c2.y;
        }

       public String ToString()
       {
           return "x = " + x.ToString() + "   y = " + y.ToString();
       }
    }
}
