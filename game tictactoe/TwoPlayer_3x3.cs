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
    public partial class TwoPlayer_3x3 : Form
    {

        bool turn = true;
        int turn_count = 0;
        public TwoPlayer_3x3()
        {
            InitializeComponent();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            TwoPlayer_Mode form7 = new TwoPlayer_Mode();
            this.Hide();
            form7.ShowDialog();
        }

         private void button_click(object sender, EventArgs e)
        {
            
            Button b = (Button)sender; //delegate
            if (turn)
                b.Text = "X";
            else
                b.Text = "O";
            turn = !turn;
            b.Enabled = false;

            //chenanh(b);
            turn_count++;
            checkForWinner();
            
            btnRestart.Enabled = true;
            button5.Enabled = true;
            button12.Enabled = true;

        }
        # region checkForWinner
        private void checkForWinner()
        {
            bool there_is_a_Winner = false;
            if ((btnA1.Text == btnA2.Text) && (btnA2.Text == btnA3.Text) && (!btnA1.Enabled))
            {
                there_is_a_Winner = true;
            }
            else if ((btnB1.Text == btnB2.Text) && (btnB2.Text == btnB3.Text) && (!btnB1.Enabled))
            {
                there_is_a_Winner = true;
            }
            else if ((btnC1.Text == btnC2.Text) && (btnC2.Text == btnC3.Text) && (!btnC1.Enabled))
            {
                there_is_a_Winner = true;
            }

            if ((btnA1.Text == btnB1.Text) && (btnB1.Text == btnC1.Text) && (!btnA1.Enabled))
            {
                there_is_a_Winner = true;
            }
            else if ((btnA2.Text == btnB2.Text) && (btnB2.Text == btnC2.Text) && (!btnA2.Enabled))
            {
                there_is_a_Winner = true;
            }
            else if ((btnA3.Text == btnB3.Text) && (btnB3.Text == btnC3.Text) && (!btnA3.Enabled))
            {
                there_is_a_Winner = true;
            }

            if ((btnA1.Text == btnB2.Text) && (btnB2.Text == btnC3.Text) && (!btnA1.Enabled))
            {
                there_is_a_Winner = true;
            }

            else if ((btnA3.Text == btnB2.Text) && (btnB2.Text == btnC1.Text) && (!btnA3.Enabled))
            {
                there_is_a_Winner = true;
            }


            if (there_is_a_Winner)
            {
                disableButton();
                string winner;
                if (turn)
                    winner = "O";
                else
                    winner = "X";

                MessageBox.Show(winner + " Won");
            }
            else
            {
                if(turn_count == 9)
                    MessageBox.Show("Draw !!", "Bummer !!!");
            }
            #endregion
        }

        private void disableButton()
        {
            try
            {
                foreach (Control c in Controls)
                {
                    Button b = (Button)c;
                    b.Enabled = false;
                }
            }
            catch { };


        }
        private void button5_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            this.Hide();
            home.ShowDialog();
        }

        private void BtnRestart_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (Control c in Controls)
                {
                    Button b = (Button)c;
                    b.Enabled = true;
                    b.Text = "";
                    btnRestart.Text = "Restart";
                }

            }
            catch {}
        }

        //private void chenanh(Button bt)
        //{
        //    if (turn == false)
        //    {
        //        bt.Image = Image.FromFile(@"E:\tic tac toe html\đổi hình\đổi hình\NewFolder1\x.jpg");
        //        turn = false;
        //    }
        //    else
        //    {
        //        bt.Image = Image.FromFile(@"E:\tic tac toe html\đổi hình\đổi hình\NewFolder1\2.jpg");
        //        turn = true;
        //    }
        //    //bt.Enabled = false;     
        //}

        //private void btnA2_Click(object sender, EventArgs e)
        //{
        //    chenanh(btnA2);
        //}

        //private void btnA3_Click(object sender, EventArgs e)
        //{
        //    chenanh(btnA3);
        //}

        //private void btnB1_Click(object sender, EventArgs e)
        //{
        //    chenanh(btnB1);
        //}

        //private void btnB2_Click(object sender, EventArgs e)
        //{ 
        //    chenanh(btnB2);
        //}

        //private void btnB3_Click(object sender, EventArgs e)
        //{
        //    chenanh(btnB3);
        //}

        //private void btnC1_Click(object sender, EventArgs e)
        //{
        //   chenanh(btnC1);
        //}

        //private void btnC2_Click(object sender, EventArgs e)
        //{
        //    chenanh(btnC2);
        //}

        //private void btnC3_Click(object sender, EventArgs e)
        //{
        //    chenanh(btnC3);
        //}

    }
}
