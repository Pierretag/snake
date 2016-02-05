using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class Game
    {
        public int Currentdir = 2;

        public Coords GameLocation ;
        public Coords GameSize;
        public Game() {}

        public Game(Coords Location, Coords Size)
        {
            GameLocation = Location;
            GameSize = Size;
        }

        public void SnakeMoving(List<Segment> Snake){
             
            Segment segBefore = Snake.First();
            Segment segFirst = Snake.ElementAt(0);
            Segment segAfter = new Segment();
            int index = 0 ;
            int LastIndex = Snake.Count();
           // Gestion du deplacement du snake 
            foreach (Segment seg in Snake)
            {
                segAfter = new Segment();
                Coords.CoordsCopy(segAfter.Coord, seg.Coord);
                segAfter.Image = seg.Image;
                Coords.CoordsCopy(seg.Coord, segBefore.Coord);
                DirectionManager(seg, segBefore, index, LastIndex);
                segBefore = segAfter;
                seg.CoordApply();

                Console.WriteLine("   ");
                index++;
            }

            
            segFirst.move(Currentdir);
            //Console.WriteLine(" Fisrt is : " + segFirst.Coord.ToString());
            

            // Gestion des Colisions avec la frame de jeu
            if (segFirst.Coord.x > GameSize.x + GameLocation.x)
            {
                segFirst.Coord.x = GameLocation.x;
            }
            if (segFirst.Coord.x < GameLocation.x)
            {
                segFirst.Coord.x = GameLocation.x + GameSize.x - 10;
            }
            if (segFirst.Coord.y > GameLocation.y + GameSize.y -10)
            {
                segFirst.Coord.y = GameLocation.y;
            }
            if (segFirst.Coord.y < GameLocation.y)
            {
                segFirst.Coord.y = GameLocation.y + GameSize.y -10 ;
            }
            segFirst.CoordApply();
           
        }


        public void AddSnakePart(List<Segment> Snake)
        {
            Segment segBefore = Snake.Last();
            Segment SegNew = new Segment((int)Segment.typeSel.Snake, segBefore.Coord);
            switch (Currentdir)
            {
                case (int)Segment.CurrentDir.Up: SegNew.Coord.y -= 10;
                    break;
                case (int)Segment.CurrentDir.Down: SegNew.Coord.y += 10;
                    break;
                case (int)Segment.CurrentDir.Left: SegNew.Coord.x += 10;
                    break;
                case (int)Segment.CurrentDir.Right: SegNew.Coord.x -= 10;
                    break;
            }

            SegNew.Image = segBefore.Image;
            Snake.Add( SegNew);
            
            
        }

        public void DirectionManager(Segment seg, Segment segBefore, int index, int LastIndex)
        {
            if (index == 1)
            {
                switch (Currentdir)
                {
                    case (int) Segment.CurrentDir.Up:
                    case (int)Segment.CurrentDir.Down:
                        seg.ChangeDirection((int)Segment.direction.V);
                        break;
                    case (int)Segment.CurrentDir.Left:
                    case (int)Segment.CurrentDir.Right:
                        seg.ChangeDirection((int)Segment.direction.H);
                        break;

                }
            }
            else if (index == LastIndex - 1)
            {
                switch (Currentdir)
                {
                    case (int)Segment.CurrentDir.Up:
                        seg.ChangeDirection((int)Segment.direction.QU);
                        break;
                    case (int)Segment.CurrentDir.Down:
                        seg.ChangeDirection((int)Segment.direction.QD);
                        break;
                    case (int)Segment.CurrentDir.Left:
                        seg.ChangeDirection((int)Segment.direction.QL);
                        break;
                    case (int)Segment.CurrentDir.Right:
                        seg.ChangeDirection((int)Segment.direction.QR);
                        break;

                }
                Console.WriteLine("YEp");
            }
            else if (index > 1)
            {
                seg.Image = segBefore.Image;
            }

            Console.WriteLine(" Index : " + index.ToString() + " Lastindex is : " + LastIndex.ToString());
            

            
            
        }
    }
}
