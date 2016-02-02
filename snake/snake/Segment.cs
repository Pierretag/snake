using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace snake
{
    class Segment : PictureBox 
    {
        private enum typeSel { Wall, None, Fruit, Snake };
        private int type;
        private Coords Coord ;

        public Segment(int x , Coords Coord) : base() {
            
            this.Coord = Coord;
            type = x;
            this.Location = new System.Drawing.Point(Coord.x,Coord.y);
            this.Size = new System.Drawing.Size(10, 10);
            this.Name = "Grid_" + Coord.x+ "x" + Coord.y;
            
    }


    }
}
