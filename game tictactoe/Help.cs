using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace game_tictactoe
{
    public partial class Help : Form
    {
        float X, Y;
        public Help()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://docvui-suynghi.net/chuyen-phiem/phiem-2014/cp147/");

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.youtube.com/watch?v=pKxzVYuFaWU");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Home form1 = new Home();
            this.Hide();
            form1.ShowDialog();
        }

        private void Form11_Load(object sender, EventArgs e)
        {
            X = this.Width;
            Y = this.Height;
            SetTag(this);
        }

        private void Form11_Resize(object sender, EventArgs e)
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
        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
