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
        public Form1()
        {
            this.Snake = new List<Segment>();
            int i;
            InitializeComponent();
            for (i = 0; i < 5; i++)
            {
                Snake.Add(new Segment(1,new Coords(i+ 10 , 10)));
               
            }

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Panel_Game_Paint(object sender, PaintEventArgs e)
        {

        }


    }
}
