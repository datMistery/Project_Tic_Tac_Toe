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
    public partial class AI_Easy : Form
    {


        public enum Player
        {
            X, O
        }
        public AI_Easy()
        {
            InitializeComponent();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Mode form3 = new Mode();
            this.Hide();
            form3.ShowDialog();
        }

        private void button12_Click_1(object sender, EventArgs e)
        {
            Mode form3 = new Mode();
            this.Hide();
            form3.ShowDialog();
        }

        Player currentPlayer;
        List<Button> buttons;
        Random rand = new Random();
        int playerWins = 0;
        int computerWins = 0;

        private void button_Click(object sender, EventArgs e)
        {
            try
            {
                var button = (Button)sender;
                button.Enabled = false;
                buttons.Remove(button);
                currentPlayer = Player.X;

                button.Text = currentPlayer.ToString();
                buttons.Remove(button);
                Check();
                AImoves.Start();
                btnPlay.Enabled = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Sorry !!! You have to enter the Play button first!!!");
            }

        }

        private void loadButton()
        {
            buttons = new List<Button> { btnA1, btnA2, btnA3, btnB1, btnB2, btnB3, btnC1, btnC2, btnC3 };
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            lblHuman.Text = "Human: 0";
            playerWins = 0;
            lblComputer.Text = "Computer: 0";
            computerWins = 0;
            ResetGame();
        }

        private void ResetGame()
        {
            foreach (Control X in this.Controls)
            {
                if (X is Button && X.Tag == "play")
                {
                    ((Button)X).Enabled = true;
                    ((Button)X).Text = "";
               
                }
            }
            loadButton();
        }

        private void Check()
        {

                if (btnA1.Text == "X" && btnA2.Text == "X" && btnA3.Text == "X"
                    || btnB1.Text == "X" && btnB2.Text == "X" && btnB3.Text == "X"
                    || btnC1.Text == "X" && btnC2.Text == "X" && btnC3.Text == "X"
                    || btnA1.Text == "X" && btnB1.Text == "X" && btnC1.Text == "X"
                    || btnA2.Text == "X" && btnB2.Text == "X" && btnC2.Text == "X"
                    || btnA3.Text == "X" && btnB3.Text == "X" && btnC3.Text == "X"
                    || btnA1.Text == "X" && btnB2.Text == "X" && btnC3.Text == "X"
                    || btnA3.Text == "X" && btnB2.Text == "X" && btnC1.Text == "X")
                {
                    AImoves.Stop();
                    MessageBox.Show("You won !!! ^^");
                    AImoves.Stop();
                    playerWins++;
                    lblHuman.Text = "Human: " + playerWins;
                    AImoves.Stop();
                    ResetGame();
                }
                else if (btnA1.Text == "O" && btnA2.Text == "O" && btnA3.Text == "O"
                   || btnB1.Text == "O" && btnB2.Text == "O" && btnB3.Text == "O"
                   || btnC1.Text == "O" && btnC2.Text == "O" && btnC3.Text == "O"
                   || btnA1.Text == "O" && btnB1.Text == "O" && btnC1.Text == "O"
                   || btnA2.Text == "O" && btnB2.Text == "O" && btnC2.Text == "O"
                   || btnA3.Text == "O" && btnB3.Text == "O" && btnC3.Text == "O"
                   || btnA1.Text == "O" && btnB2.Text == "O" && btnC3.Text == "O"
                   || btnA3.Text == "O" && btnB2.Text == "O" && btnC1.Text == "O")
                {
                    AImoves.Stop();
                    MessageBox.Show("You lose !!! -_-");
                    AImoves.Stop();
                    computerWins++;
                    lblComputer.Text = "Computer: " + computerWins;
                    AImoves.Stop();
                    ResetGame();
                }
        }

        private void AImove(object sender, EventArgs e)
        {
            if (buttons.Count > 0)
            {
                int index = rand.Next(buttons.Count);
                buttons[index].Enabled = false;
                currentPlayer = Player.O;
                buttons[index].Text = currentPlayer.ToString();
                buttons.RemoveAt(index);
                Check();
                AImoves.Stop();
            }
        }

        private void BtnRestart_Click(object sender, EventArgs e)
        {
            ResetGame();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            this.Hide();
            home.ShowDialog();
        }
    }
}
