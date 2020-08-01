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
	public partial class Form9 : Form
	{
		
		bool turn = true;
		int turn_count = 0;

		public Form9()
		{
			InitializeComponent();
		}





        // Kiểm tra người chiến thắng

        #region Check Winner
        private void checkForWinner(object sender)
		{
			bool aWinner = false;

			/*
			 * Xét từng trường hợp có thể xảy ra cho game 
			 */

			// Xét trường hợp hàng ngang

			if ((btnA1.Text == btnA2.Text) && (btnA2.Text == btnA3.Text) && (btnA3.Text == btnA4.Text) && (!btnA1.Enabled))
			{
				aWinner = true;
			}
			if ((btnB1.Text == btnB2.Text) && (btnB2.Text == btnB3.Text) && (btnB3.Text == btnB4.Text) && (!btnB1.Enabled))
			{
				aWinner = true;
			}
			if ((btnC1.Text == btnC2.Text) && (btnC2.Text == btnC3.Text) && (btnC3.Text == btnC4.Text) && (!btnC1.Enabled))
			{
				aWinner = true;
			}
			if ((btnD1.Text == btnD2.Text) && (btnD2.Text == btnD3.Text) && (btnD3.Text == btnD4.Text) && (!btnD1.Enabled))
			{
				aWinner = true;
			}
			if ((btnE1.Text == btnE2.Text) && (btnE2.Text == btnE3.Text) && (btnE3.Text == btnE4.Text) && (!btnE1.Enabled))
			{
				aWinner = true;
			}
			//Xét từng trường hợp theo chiều ngang ngược lại
			if ((btnA5.Text == btnA4.Text) && (btnA4.Text == btnA3.Text) && (btnA3.Text == btnA2.Text) && (!btnA5.Enabled))
			{
				aWinner = true;
			}
			if ((btnB5.Text == btnB4.Text) && (btnB4.Text == btnB3.Text) && (btnB3.Text == btnB2.Text) && (!btnB5.Enabled))
			{
				aWinner = true;
			}
			if ((btnC5.Text == btnC4.Text) && (btnC4.Text == btnC3.Text) && (btnC3.Text == btnC2.Text) && (!btnC5.Enabled))
			{
				aWinner = true;
			}
			if ((btnD5.Text == btnD4.Text) && (btnD4.Text == btnD3.Text) && (btnD3.Text == btnD2.Text) && (!btnD5.Enabled))
			{
				aWinner = true;
			}
			if ((btnE5.Text == btnE4.Text) && (btnE4.Text == btnE3.Text) && (btnE3.Text == btnE2.Text) && (!btnE5.Enabled))
			{
				aWinner = true;
			}
			//Xét theo trường hợp theo hàng dọc 
			if ((btnA1.Text == btnB1.Text) && (btnB1.Text == btnC1.Text) && (btnC1.Text == btnD1.Text) && (!btnA1.Enabled))
			{
				aWinner = true;
			}
			if ((btnA2.Text == btnB2.Text) && (btnB2.Text == btnC2.Text) && (btnC2.Text == btnD2.Text) && (!btnA2.Enabled))
			{
				aWinner = true;
			}
			if ((btnA3.Text == btnB3.Text) && (btnB3.Text == btnC3.Text) && (btnC3.Text == btnD3.Text) && (!btnA3.Enabled))
			{
				aWinner = true;
			}
			if ((btnA4.Text == btnB4.Text) && (btnB4.Text == btnC4.Text) && (btnC4.Text == btnD4.Text) && (!btnA4.Enabled))
			{
				aWinner = true;
			}
			if ((btnA5.Text == btnB5.Text) && (btnB5.Text == btnC5.Text) && (btnC5.Text == btnD5.Text) && (!btnA5.Enabled))
			{
				aWinner = true;
			}
			//Xét theo chiều dọc theo chiều ngược lại
			if ((btnE1.Text == btnD1.Text) && (btnD1.Text == btnC1.Text) && (btnC1.Text == btnB1.Text) && (!btnE1.Enabled))
			{
				aWinner = true;
			}
			if ((btnE2.Text == btnD2.Text) && (btnD2.Text == btnC2.Text) && (btnC2.Text == btnB2.Text) && (!btnE2.Enabled))
			{
				aWinner = true;
			}
			if ((btnE3.Text == btnD3.Text) && (btnD3.Text == btnC3.Text) && (btnC3.Text == btnB3.Text) && (!btnE3.Enabled))
			{
				aWinner = true;
			}
			if ((btnE4.Text == btnD4.Text) && (btnD4.Text == btnC4.Text) && (btnC4.Text == btnB4.Text) && (!btnE4.Enabled))
			{
				aWinner = true;
			}
			if ((btnE5.Text == btnD5.Text) && (btnD5.Text == btnC5.Text) && (btnC5.Text == btnB5.Text) && (!btnE5.Enabled))
			{
				aWinner = true;
			}
			//Xét đường chéo từ trái sang phải
			if ((btnA1.Text == btnB2.Text) && (btnB2.Text == btnC3.Text) && (btnC3.Text == btnD4.Text) && (!btnA1.Enabled))
			{
				aWinner = true;
			}
			if ((btnE5.Text == btnD4.Text) && (btnD4.Text == btnC3.Text) && (btnC3.Text == btnB2.Text) && (!btnE5.Enabled))
			{
				aWinner = true;
			}
			if ((btnA2.Text == btnB3.Text) && (btnB3.Text == btnC4.Text) && (btnC4.Text == btnD5.Text) && (!btnA2.Enabled))
			{
				aWinner = true;
			}
			if ((btnB1.Text == btnC2.Text) && (btnC2.Text == btnD3.Text) && (btnD3.Text == btnE4.Text) && (!btnB1.Enabled))
			{
				aWinner = true;
			}
			// Xét đường chéo từ phải sang trái
			if ((btnA5.Text == btnB4.Text) && (btnB4.Text == btnC3.Text) && (btnC3.Text == btnD2.Text) && (!btnA5.Enabled))
			{
				aWinner = true;
			}
			if ((btnE1.Text == btnD2.Text) && (btnD2.Text == btnC3.Text) && (btnC3.Text == btnB4.Text) && (!btnE1.Enabled))
			{
				aWinner = true;
			}
			if ((btnA4.Text == btnB3.Text) && (btnB3.Text == btnC2.Text) && (btnC2.Text == btnD1.Text) && (!btnA4.Enabled))
			{
				aWinner = true;
			}
			if ((btnB5.Text == btnC4.Text) && (btnC4.Text == btnD3.Text) && (btnD3.Text == btnE2.Text) && (!btnB5.Enabled))
			{
				aWinner = true;
			}
            try
            {
                if (aWinner)
                {
                    DisableButton();
                    string winner;
                    if (turn)
                    {

                        winner = "O";
                    }
               
                    else
                    {
                        winner = "X";
                    }
                    MessageBox.Show(winner + " Won !!!");
                }
                else
                {
                    if (turn_count == 25)
                        MessageBox.Show("Draw !!! Stupid (-_-)");
                }
            }
            catch { }

		}
        #endregion

        // Hàm hủy nút bấm khi Game thắng hoặc hòa

        #region Disable Button
        private void DisableButton()
		{
			try
			{
				foreach (Control c in Controls)
				{
					Button b = (Button)c;
					b.Enabled = false;
				}
			}
			catch (Exception ex)
			{
				throw ex;
			};

		}



        #endregion




        private void BtnMenu_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            this.Hide();
            home.ShowDialog();

        }

        private void button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            Convert.ToString((turn) ? button.Text = "X" : button.Text = "O");
            /*
			 * Phải chuyển đổi(Convert) toàn bộ câu lệnh sử dụng toán tử 3 ngôi sang kiểu string 
			 *		=> Mới có thể sử dụng được  
			 * */

            turn = !turn;
            /*
			 * Do là khi đánh mỗi lượt luôn là true nên là tới lượt tiếp theo nó sẽ luôn là "X"
			 *		=> Nên phải có câu lệnh trên để tránh trường hợp nó luôn là true
			 */
            button.Enabled = false;
            /* 
			 * Do là khi đánh xong 1 ô thì nó có thể chuyển từ "O" sang "X" và ngược lại trên cùng 1 ô
			 *		=> Chính vì vậy nên sử dụng hàm cho phép(Enabled) = false để nó cố định lại không thay đổi được
			 */
            turn_count++;
            /*
			 * Dùng để tăng số lượt đánh vào ô 
			 *		=> Cho tới khi mà nó đủ các ô thì hòa 
			 */
            checkForWinner(sender);
            btnRestart.Enabled = true;
            btnBack.Enabled = true;
            btnMenu.Enabled = true;
        }

        private void BtnRestart_Click(object sender, EventArgs e)
        {

            turn = true;
            turn_count = 0;
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
            catch
            {

            }
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            TwoPlayer_Mode form7 = new TwoPlayer_Mode();
            this.Hide();
            form7.ShowDialog();
        }
    }
}

