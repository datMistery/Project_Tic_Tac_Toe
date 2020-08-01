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
    public partial class Mode : Form
    {
        public Mode()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            AI_Easy form4 = new AI_Easy();
            this.Hide();
            form4.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AI_Medium form5 = new AI_Medium();
            this.Hide();
            form5.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Al_Hard form6 = new Al_Hard();
            this.Hide();
            form6.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PlayMode form2 = new PlayMode();
            this.Hide();
            form2.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            this.Hide();
            home.ShowDialog();
        }
    }
}
