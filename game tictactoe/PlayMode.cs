using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace game_tictactoe
{
    public partial class PlayMode : Form
    {
        public PlayMode()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TwoPlayer_Mode form7 = new TwoPlayer_Mode();
            this.Hide();
            form7.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Mode form3 = new Mode();
            this.Hide();
            form3.ShowDialog();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Home form1 = new Home();
            this.Hide();
            form1.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Home form1 = new Home();
            this.Hide();
            form1.ShowDialog();
        }

 
        private void button3_Click_1(object sender, EventArgs e)
        {
            Home form1 = new Home();
            this.Hide();
            form1.ShowDialog();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Home home = new Home();
            this.Hide();
            home.ShowDialog();
        }
    }
}
