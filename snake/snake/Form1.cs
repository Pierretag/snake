using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;


namespace snake
{
    public partial class Form1 : Form
    {
        
        private List<Segment> Snake;
        private List<Segment> Wall;
        private Segment Fruit;
        private Game MainGame;
        public Form1()
        {
            
            InitializeComponent();
            MainGame = new Game(
                new Coords(this.GamePanel.Left,this.GamePanel.Top),
                new Coords(this.GamePanel.Size.Width, this.GamePanel.Size.Height)
                );
            Fruit = new Segment((int)Segment.typeSel.Fruit, 0, new Coords(MainGame.GameLocation.x + 50, MainGame.GameLocation.y + 50));
            this.Controls.Add(Fruit);
            Fruit.BringToFront();


            Wall = new List<Segment>();



            Snake = new List<Segment>();
            int i;
          //  Segment seg = new Segment((int)Segment.typeSel.Snake, (int)Segment.direction.DL, new Coords(50, 18));
            for (i = 3; i >0; i--)
            {
                Snake.Add(
                    new Segment((int)Segment.typeSel.Snake,
                        (int)Segment.direction.H,
                        new Coords(i*10 + MainGame.GameLocation.x  , 10 + MainGame.GameLocation.y)
                        )
                        );

            }
            Snake.ElementAt(0).PictureLoad((int)Segment.direction.HL);
            Snake.Last().PictureLoad((int)Segment.direction.QR);
            
            foreach (Segment segi in Snake)
            {
                
                this.Controls.Add(segi);

                segi.BringToFront();
            }

        }

     
        private void timer1_Tick(object sender, EventArgs e)
        {

            MainGame.SnakeMoving(Snake,Fruit, Wall);

            this.Controls.Add(Snake.Last());
           if (Wall.Count() != 0) this.Controls.Add(Wall.Last());
            Snake.Last().BringToFront();
            if (Wall.Count() != 0) Wall.Last().BringToFront();
            /*
            foreach (Segment segi in Snake)
            {

                this.Controls.Add(segi);
                segi.BringToFront();

            }
            
            foreach (Segment segi in Wall)
            {

                this.Controls.Add(segi);
                segi.BringToFront();

            }
             * */
        }



        private void Form1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            
            switch (e.KeyCode)
            {
                case Keys.Up: if(MainGame.Currentdir !=(int)Segment.CurrentDir.Down) MainGame.Currentdir = (int)Segment.CurrentDir.Up;
                    break;
                case Keys.Right: if (MainGame.Currentdir != (int)Segment.CurrentDir.Left) MainGame.Currentdir = (int)Segment.CurrentDir.Right;
                    break;
                case Keys.Down: if (MainGame.Currentdir != (int)Segment.CurrentDir.Up) MainGame.Currentdir = (int)Segment.CurrentDir.Down;
                    break;
                case Keys.Left: if (MainGame.Currentdir != (int)Segment.CurrentDir.Right) MainGame.Currentdir = (int)Segment.CurrentDir.Left;
                    break;
                case Keys.B: MainGame.AddSnakePart(Snake);
                   
                    foreach (Segment segi in Snake)
                    {
                        
                        this.Controls.Add(segi);
                        segi.BringToFront();
                        
                    }

                    break;
               

            }

            Console.WriteLine("Pressed");
         
        }

       


    }
}
