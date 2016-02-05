using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace snake
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btn_play_Click(object sender, EventArgs e)
        {
            if (this.txt_pseudo.Text != "")
            {
                string pseudo = this.txt_pseudo.Text;
                //MessageBox.Show(pseudo);
                Form1 g = new Form1();
                g.ShowDialog();
            }
            else
            {
                MessageBox.Show("Vous avez oublier de mettre votre Pseudo");
            }
        }

        private void btn_quit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_instr_Click(object sender, EventArgs e)
        {
            Instruction I = new Instruction();
            I.ShowDialog();
        }
    }
}
