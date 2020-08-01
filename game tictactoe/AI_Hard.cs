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
    public partial class Al_Hard : Form
    {
        float X, Y;
        bool turn = true;
        int turnCount = 0;

        public Al_Hard()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Mode form3 = new Mode();
            this.Hide();
            form3.ShowDialog();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            X = this.Width;
            Y = this.Height;
            SetTag(this);
        }

        private void Form6_Resize(object sender, EventArgs e)
        {
            float newX = this.Width / X;
            float newY = this.Height / Y;
            SetControls(newX, newY, this);
        }
        private void SetTag(Control cons)
        {
            foreach (Control con in cons.Controls)
            {
                con.Tag = con.Width + ":" + con.Height + ":" + con.Left + ":" + con.Top + ":" + con.Font.Size;
            }
        }

        private void SetControls(float newX, float newY, Control cons)
        {
            foreach (Control con in cons.Controls)
            {
                try
                {
                    string[] mytag = con.Tag.ToString().Split(new char[] { ':' });
                    float a = Convert.ToSingle(mytag[0]) * newX;
                    con.Width = (int)(a);

                    a = Convert.ToSingle(mytag[1]) * newY;
                    con.Height = (int)(a);

                    a = Convert.ToSingle(mytag[2]) * newX;
                    con.Left = (int)(a);

                    a = Convert.ToSingle(mytag[3]) * newY;
                    con.Top = (int)(a);

                    Single currentSize = Convert.ToSingle(mytag[4]) * newY;
                    con.Font = new Font(con.Font.Name, currentSize, con.Font.Style, con.Font.Unit);
                }
                catch { }
            }
        }



        private void Button_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender; //delegate
            if (turn)
                b.Text = "X";
            else
                b.Text = "O";
            turn = !turn;
            b.Enabled = false;
            turnCount++;
            checkForWinner();

            if ((!turn))
            {
                ComputerMove();
            }
            btnRestart.Enabled = true;
            btnMenu.Enabled = true;
            btnBack.Enabled = true;
        }

        private void ComputerMove()
        {
            Button move = null;
            move = LookForWinOrBlock("O");
            if (move == null)
            {
                move = LookForWinOrBlock("X");
                if (move == null)
                {
                    move = LookForCorner();
                    if (move == null)
                    {
                        move = LookForOpenSpace();
                    }
                }

            }
            move.PerformClick();
        }

        private Button LookForWinOrBlock(string mark)
        {
            Console.WriteLine("Looking for win or block! " + mark);
            //Kiem tra hang ngang
            if ((btnA1.Text == mark) && (btnA2.Text == mark) && (btnA3.Text == ""))
            {
                return btnA3;
            }
            if ((btnA2.Text == mark) && (btnA3.Text == mark) && (btnA1.Text == ""))
            {
                return btnA1;
            }
            if ((btnA1.Text == mark) && (btnA3.Text == mark) && (btnA2.Text == ""))
            {
                return btnA2;
            }

            if ((btnB1.Text == mark) && (btnB2.Text == mark) && (btnB3.Text == ""))
            {
                return btnB3;
            }
            if ((btnB2.Text == mark) && (btnB3.Text == mark) && (btnB1.Text == ""))
            {
                return btnB1;
            }
            if ((btnB1.Text == mark) && (btnB3.Text == mark) && (btnB2.Text == ""))
            {
                return btnB2;
            }

            if ((btnC1.Text == mark) && (btnC2.Text == mark) && (btnC3.Text == ""))
            {
                return btnC3;
            }
            if ((btnC2.Text == mark) && (btnC3.Text == mark) && (btnC1.Text == ""))
            {
                return btnC1;
            }
            if ((btnC1.Text == mark) && (btnC3.Text == mark) && (btnC2.Text == ""))
            {
                return btnC2;
            }
            // Kiem tra hang doc
            if ((btnA1.Text == mark) && (btnB1.Text == mark) && (btnC1.Text == ""))
            {
                return btnC1;
            }
            if ((btnB1.Text == mark) && (btnC1.Text == mark) && (btnA1.Text == ""))
            {
                return btnA1;
            }
            if ((btnA1.Text == mark) && (btnC1.Text == mark) && (btnB1.Text == ""))
            {
                return btnB1;
            }

            if ((btnA2.Text == mark) && (btnB2.Text == mark) && (btnC2.Text == ""))
            {
                return btnC2;
            }
            if ((btnB2.Text == mark) && (btnC2.Text == mark) && (btnA2.Text == ""))
            {
                return btnA2;
            }
            if ((btnA2.Text == mark) && (btnC2.Text == mark) && (btnB2.Text == ""))
            {
                return btnB2;
            }

            if ((btnA3.Text == mark) && (btnB3.Text == mark) && (btnC3.Text == ""))
            {
                return btnC3;
            }
            if ((btnB3.Text == mark) && (btnC3.Text == mark) && (btnA3.Text == ""))
            {
                return btnA3;
            }
            if ((btnA3.Text == mark) && (btnC3.Text == mark) && (btnB3.Text == ""))
            {
                return btnB3;
            }

            // Kiem tra duong cheo
            if ((btnA1.Text == mark) && (btnB2.Text == mark) && (btnC3.Text == ""))
            {
                return btnC3;
            }
            if ((btnB2.Text == mark) && (btnC3.Text == mark) && (btnA1.Text == ""))
            {
                return btnA1;
            }
            if ((btnA1.Text == mark) && (btnC3.Text == mark) && (btnB2.Text == ""))
            {
                return btnB2;
            }

            if ((btnA3.Text == mark) && (btnB2.Text == mark) && (btnC1.Text == ""))
            {
                return btnC1;
            }
            if ((btnB2.Text == mark) && (btnC1.Text == mark) && (btnA3.Text == ""))
            {
                return btnA3;
            }
            if ((btnA3.Text == mark) && (btnC1.Text == mark) && (btnB2.Text == ""))
            {
                return btnB2;
            }
            return null;
        }
        private Button LookForCorner()
        {
            Console.WriteLine("Look for corner!");
            if (btnA1.Text == "O")
            {
                if (btnA3.Text == "")
                    return btnA3;
                if (btnC3.Text == "")
                    return btnC3;
                if (btnC1.Text == "")
                    return btnC1;
            }
            if (btnA3.Text == "O")
            {
                if (btnA1.Text == "")
                    return btnA1;
                if (btnC3.Text == "")
                    return btnC3;
                if (btnC1.Text == "")
                    return btnC1;
            }
            if (btnC3.Text == "O")
            {
                if (btnA3.Text == "")
                    return btnA3;
                if (btnA1.Text == "")
                    return btnA3;
                if (btnC1.Text == "")
                    return btnC1;
            }
            if (btnC1.Text == "O")
            {
                if (btnA1.Text == "")
                    return btnA3;
                if (btnA3.Text == "")
                    return btnA3;
                if (btnC3.Text == "")
                    return btnC3;
            }
            if (btnA1.Text == "")
                return btnA1;
            if (btnA3.Text == "")
                return btnA3;
            if (btnC1.Text == "")
                return btnC1;
            if (btnC3.Text == "")
                return btnC3;
            return null;
        }
        private Button LookForOpenSpace()
        {
            Console.WriteLine("Look for open space!");
            Button b = null;
            foreach (Control c in Controls)
            {
                b = c as Button;
                if (b != null)
                {
                    if (b.Text == "")
                    {
                        return b;
                    }
                }
            }
            return null;
        }
        #region checkForWinner
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

                string winner = "";
                if (turn)
                    winner = "0";
                else
                    winner = "X";

                MessageBox.Show(winner + " Won", "Yeah ^^");
            }
            else
            {
                if (turnCount == 9)
                    MessageBox.Show("Draw !!", "Bummer !!!");
            }
            #endregion
        }

        private void BtnRestart_Click(object sender, EventArgs e)
        {
            turn = true;
            turnCount = 0;
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
            catch { }
        }


        private void BtnHome_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            this.Hide();
            home.ShowDialog();

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
    }
}
