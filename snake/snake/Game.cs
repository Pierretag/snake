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
        
        public Coords GameLocation;
        public Coords GameSize;
        public Game() { }

        public Game(Coords Location, Coords Size)
        {
            GameLocation = Location;
            GameSize = Size;
        }



        public void SnakeMoving(List<Segment> Snake, Segment Fruit , List<Segment> Wall)
        {

            Segment segBefore = Snake.First();
            Segment segFirst = Snake.ElementAt(0);
            Segment segAfter = new Segment();
            int index = 0;
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

                //Console.WriteLine("   ");
                index++;
            }


            segFirst.move(Currentdir);

            SnakeColision(Snake, Fruit, Wall);
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
            if (segFirst.Coord.y > GameLocation.y + GameSize.y - 10)
            {
                segFirst.Coord.y = GameLocation.y;
            }
            if (segFirst.Coord.y < GameLocation.y)
            {
                segFirst.Coord.y = GameLocation.y + GameSize.y - 10;
            }
            segFirst.CoordApply();

        }

        public void SnakeColision(List<Segment> Snake, Segment Fruit , List<Segment> Wall)
        {
            Segment segFirst = Snake.First();
            
            Random rnd = new Random();
            int index = 0;
            int rand1, rand2;
            if (segFirst.Coord.equals(Fruit.Coord))
            {
                Console.WriteLine("Collision Ok ");
                rand1 = rnd.Next(GameLocation.x, GameLocation.x + GameSize.x);
                rand1 = rand1 - rand1 % 10;
                rand2 = rnd.Next(GameLocation.y, GameLocation.y + GameSize.y);
                rand2 = rand2 - rand2 % 10;
                
                Fruit.Coord = new Coords(rand1, rand2);
                Fruit.CoordApply();
                
                rand1 = rnd.Next(GameLocation.x, GameLocation.x + GameSize.x);
                rand1 = rand1 - rand1 % 10;

                rand2 = rnd.Next(GameLocation.y, GameLocation.y + GameSize.y);
                rand2 = rand2 - rand2 % 10;
               
                Wall.Add(new Segment(
                    (int)Segment.typeSel.Wall,
                    0,
                    new Coords(rand1, rand2)
                    ));
                
                

                AddSnakePart(Snake);
            }
            foreach (Segment seg in Snake)
            {
                if (index != 0)
                {
                    if (segFirst.Coord.equals(seg.Coord))
                    {
                        Console.WriteLine("GAME OVER");
                    }
                    foreach (Segment segwall in Wall)
                    {
                        if (segFirst.Coord.equals(segwall.Coord))
                        {
                            Console.WriteLine("GAME OVER");
                        }
                    }
                }
                index++;
            }




        }


        public void AddSnakePart(List<Segment> Snake)
        {
            Segment segBefore = Snake.Last();
            Segment SegNew = new Segment((int)Segment.typeSel.Snake, new Coords(segBefore.Coord.x, segBefore.Coord.y));

            switch (Currentdir)
            {
                case (int)Segment.CurrentDir.Up: SegNew.Coord.y += 10;
                    break;
                case (int)Segment.CurrentDir.Down: SegNew.Coord.y -= 10;
                    break;
                case (int)Segment.CurrentDir.Left: SegNew.Coord.x += 10;
                    break;
                case (int)Segment.CurrentDir.Right: SegNew.Coord.x -= 10;
                    break;
                default: Console.WriteLine("BUG");
                    break;
            }


            SegNew.CoordApply();

            SegNew.Image = segBefore.Image;
            Snake.Add(SegNew);


        }


        public void DirectionManager(Segment seg, Segment segBefore, int index, int LastIndex)
        {
            if (index == 1)
            {
                switch (Currentdir)
                {
                    case (int)Segment.CurrentDir.Up:
                    case (int)Segment.CurrentDir.Down:
                        seg.PictureLoad((int)Segment.direction.V);
                        break;
                    case (int)Segment.CurrentDir.Left:
                    case (int)Segment.CurrentDir.Right:
                        seg.PictureLoad((int)Segment.direction.H);
                        break;

                }
            }
            else if (index == LastIndex - 1)
            {
                switch (Currentdir)
                {
                    case (int)Segment.CurrentDir.Up:
                        seg.PictureLoad((int)Segment.direction.QU);
                        break;
                    case (int)Segment.CurrentDir.Down:
                        seg.PictureLoad((int)Segment.direction.QD);
                        break;
                    case (int)Segment.CurrentDir.Left:
                        seg.PictureLoad((int)Segment.direction.QL);
                        break;
                    case (int)Segment.CurrentDir.Right:
                        seg.PictureLoad((int)Segment.direction.QR);
                        break;

                }
            }

          else if (index > 1)
            {
                seg.Image = segBefore.Image;
            }

        }



    }
}


