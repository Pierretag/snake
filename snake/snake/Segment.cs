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
        public enum typeSel { Wall = 1, None, Fruit, Snake };
        private int type;
        public enum direction { DL = 1, DR, H, HD, HL, HR, HU, QD, QL, QR, QU, UL, UR, V };
        

        public enum CurrentDir { Up = 1, Right, Down, Left };
        
        public Coords Coord;
        

        public Segment() : base() { this.Coord = new Coords(); }

        public Segment(int x, int dir, Coords Coord)
            : base()
        {

            this.Coord = Coord;
            type = x;
            this.Location = new System.Drawing.Point(Coord.x, Coord.y);
            this.Size = new System.Drawing.Size(10, 10);
            this.Name = "Grid_" + Coord.x + "x" + Coord.y;
            // Console.WriteLine(this.Name +"  " + x.ToString() + "   " + dir.ToString() );
            //this.TabIndex = 0;
            // this.Controls.Add(this);
            ChangeDirection(dir);


        }

        public Segment(int x, Coords Coord )
            : base()
        {

            this.Coord = Coord;
            type = x;
            this.Location = new System.Drawing.Point(Coord.x, Coord.y);
            this.Size = new System.Drawing.Size(10, 10);
            this.Name = "Grid_" + Coord.x + "x" + Coord.y;

        }
        public void ChangeDirection(int dir)
        {
            if (type == (int)typeSel.Snake)
            {
                switch (dir)
                {
                    case (int)direction.DL: this.Image = global::snake.Properties.Resources.SnakeImage_DL;
                        break;
                    case (int)direction.DR: this.Image = global::snake.Properties.Resources.SnakeImage_DR;
                        break;
                    case (int)direction.H: this.Image = global::snake.Properties.Resources.SnakeImage_H;
                        break;
                    case (int)direction.HD: this.Image = global::snake.Properties.Resources.SnakeImage_HD;
                        break;
                    case (int)direction.HL: this.Image = global::snake.Properties.Resources.SnakeImage_HL;
                        break;
                    case (int)direction.HR: this.Image = global::snake.Properties.Resources.SnakeImage_HR;
                        break;
                    case (int)direction.HU: this.Image = global::snake.Properties.Resources.SnakeImage_HU;
                        break;
                    case (int)direction.QD: this.Image = global::snake.Properties.Resources.SnakeImage_QD;
                        break;
                    case (int)direction.QL: this.Image = global::snake.Properties.Resources.SnakeImage_QL;
                        break;
                    case (int)direction.QR: this.Image = global::snake.Properties.Resources.SnakeImage_QR;
                        break;
                    case (int)direction.QU: this.Image = global::snake.Properties.Resources.SnakeImage_QU;
                        break;
                    case (int)direction.UR: this.Image = global::snake.Properties.Resources.SnakeImage_UR;
                        break;
                    case (int)direction.UL: this.Image = global::snake.Properties.Resources.SnakeImage_UL;
                        break;
                    case (int)direction.V: this.Image = global::snake.Properties.Resources.SnakeImage_V;
                        break;

                }
            }


        }

        public void move(int Currentdir){
            switch (Currentdir)
            {
                case (int)CurrentDir.Up: this.Coord.y-=10;
                    this.ChangeDirection((int)direction.HD);
                    
                    break;
                case (int)CurrentDir.Left: this.Coord.x-=10;
                    this.ChangeDirection((int)direction.HR);
                    break;
                case (int)CurrentDir.Down: this.Coord.y+=10;
                    this.ChangeDirection((int)direction.HU);
                    break;
                case (int)CurrentDir.Right: this.Coord.x+=10;
                    this.ChangeDirection((int)direction.HL);
                    break;
            }

        }

        

        public void CoordApply()
        {
            this.Location = new System.Drawing.Point(Coord.x, Coord.y);
           // Console.WriteLine(Name+"   : "  + Coord.x.ToString() + "    " + Coord.y.ToString());
        }

        

    }
}
