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
        private Game MainGame;
        public Form1()
        {
            
            InitializeComponent();
            MainGame = new Game(
                new Coords(this.GamePanel.Left,this.GamePanel.Top),
                new Coords(this.GamePanel.Size.Width, this.GamePanel.Size.Height)
                );

            Snake = new List<Segment>();
            int i;
          //  Segment seg = new Segment((int)Segment.typeSel.Snake, (int)Segment.direction.DL, new Coords(50, 18));
            for (i = 5; i >0; i--)
            {
                Snake.Add(
                    new Segment((int)Segment.typeSel.Snake,
                        (int)Segment.direction.H,
                        new Coords(i*10 + MainGame.GameLocation.x  , 10 + MainGame.GameLocation.y)
                        )
                        );

            }
            Snake.ElementAt(0).ChangeDirection((int)Segment.direction.HL);
            Snake.Last().ChangeDirection((int)Segment.direction.QR);
            
            foreach (Segment segi in Snake)
            {
                this.Controls.Add(segi);
                segi.BringToFront();
            }

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Panel_Game_Paint(object sender, PaintEventArgs e)
        {
            
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            MainGame.SnakeMoving(Snake);
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


            }

            Console.WriteLine("Pressed");
         
        }


    }
}
