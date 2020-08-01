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
    public partial class TwoPlayer_Mode : Form
    {
        float X, Y;
        public TwoPlayer_Mode()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TwoPlayer_3x3 form8 = new TwoPlayer_3x3();
            this.Hide();
            form8.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PlayMode form2 = new PlayMode();
            this.Hide();
            form2.ShowDialog();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            X = this.Width;
            Y = this.Height;
            SetTag(this);
        }

        private void Form7_Resize(object sender, EventArgs e)
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

        private void button5_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            this.Hide();
            home.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form9 form9 = new Form9();
            this.Hide();
            form9.ShowDialog();
        }
    }
}
