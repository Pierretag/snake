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
           // Gestion du deplacement du snake 
            foreach (Segment seg in Snake)
            {
                segAfter = new Segment();
                Coords.CoordsCopy(segAfter.Coord, seg.Coord);
                Coords.CoordsCopy(seg.Coord, segBefore.Coord);

                segBefore = segAfter;
                seg.CoordApply();

                Console.WriteLine("   ");
              
            }
            
            segFirst.move(Currentdir);
            Console.WriteLine(" Fisrt is : " + segFirst.Coord.ToString());
            segFirst.CoordApply();

            // Gestion des Colisions avec la frame de jeu
            if (segFirst.Coord.x >  GameSize.x -2) segFirst.Coord.x = GameLocation.x;
            if (segFirst.Coord.x < GameLocation.x) segFirst.Coord.x = GameLocation.x + GameSize.x-10;
            if (segFirst.Coord.y > GameLocation.y + GameSize.y) segFirst.Coord.y = GameLocation.y;
            if (segFirst.Coord.y < GameLocation.y) segFirst.Coord.y = GameLocation.y + GameSize.y;
           
        }
    }
}
