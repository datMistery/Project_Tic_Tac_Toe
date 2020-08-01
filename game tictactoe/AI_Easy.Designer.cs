namespace game_tictactoe
{
    partial class AI_Easy
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AI_Easy));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnA1 = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnA2 = new System.Windows.Forms.Button();
            this.btnA3 = new System.Windows.Forms.Button();
            this.btnB1 = new System.Windows.Forms.Button();
            this.btnB2 = new System.Windows.Forms.Button();
            this.btnB3 = new System.Windows.Forms.Button();
            this.btnC1 = new System.Windows.Forms.Button();
            this.btnC2 = new System.Windows.Forms.Button();
            this.btnC3 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.AImoves = new System.Windows.Forms.Timer(this.components);
            this.btnPlay = new System.Windows.Forms.Button();
            this.lblHuman = new System.Windows.Forms.Label();
            this.lblComputer = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(2, -8);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(870, 669);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnA1
            // 
            this.btnA1.BackColor = System.Drawing.Color.White;
            this.btnA1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnA1.ForeColor = System.Drawing.Color.Black;
            this.btnA1.Location = new System.Drawing.Point(184, 184);
            this.btnA1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnA1.Name = "btnA1";
            this.btnA1.Size = new System.Drawing.Size(156, 120);
            this.btnA1.TabIndex = 1;
            this.btnA1.Tag = "play";
            this.btnA1.UseVisualStyleBackColor = false;
            this.btnA1.Click += new System.EventHandler(this.button_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.MistyRose;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.Blue;
            this.btnReset.Location = new System.Drawing.Point(634, 114);
            this.btnReset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(114, 46);
            this.btnReset.TabIndex = 11;
            this.btnReset.Text = "Restart";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.BtnRestart_Click);
            // 
            // btnA2
            // 
            this.btnA2.BackColor = System.Drawing.Color.White;
            this.btnA2.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnA2.Location = new System.Drawing.Point(346, 184);
            this.btnA2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnA2.Name = "btnA2";
            this.btnA2.Size = new System.Drawing.Size(156, 120);
            this.btnA2.TabIndex = 14;
            this.btnA2.Tag = "play";
            this.btnA2.UseVisualStyleBackColor = false;
            this.btnA2.Click += new System.EventHandler(this.button_Click);
            // 
            // btnA3
            // 
            this.btnA3.BackColor = System.Drawing.Color.White;
            this.btnA3.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnA3.Location = new System.Drawing.Point(508, 184);
            this.btnA3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnA3.Name = "btnA3";
            this.btnA3.Size = new System.Drawing.Size(156, 120);
            this.btnA3.TabIndex = 15;
            this.btnA3.Tag = "play";
            this.btnA3.UseVisualStyleBackColor = false;
            this.btnA3.Click += new System.EventHandler(this.button_Click);
            // 
            // btnB1
            // 
            this.btnB1.BackColor = System.Drawing.Color.White;
            this.btnB1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnB1.Location = new System.Drawing.Point(184, 308);
            this.btnB1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnB1.Name = "btnB1";
            this.btnB1.Size = new System.Drawing.Size(156, 120);
            this.btnB1.TabIndex = 16;
            this.btnB1.Tag = "play";
            this.btnB1.UseVisualStyleBackColor = false;
            this.btnB1.Click += new System.EventHandler(this.button_Click);
            // 
            // btnB2
            // 
            this.btnB2.BackColor = System.Drawing.Color.White;
            this.btnB2.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnB2.Location = new System.Drawing.Point(346, 308);
            this.btnB2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnB2.Name = "btnB2";
            this.btnB2.Size = new System.Drawing.Size(156, 120);
            this.btnB2.TabIndex = 17;
            this.btnB2.Tag = "play";
            this.btnB2.UseVisualStyleBackColor = false;
            this.btnB2.Click += new System.EventHandler(this.button_Click);
            // 
            // btnB3
            // 
            this.btnB3.BackColor = System.Drawing.Color.White;
            this.btnB3.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnB3.Location = new System.Drawing.Point(508, 308);
            this.btnB3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnB3.Name = "btnB3";
            this.btnB3.Size = new System.Drawing.Size(156, 120);
            this.btnB3.TabIndex = 18;
            this.btnB3.Tag = "play";
            this.btnB3.UseVisualStyleBackColor = false;
            this.btnB3.Click += new System.EventHandler(this.button_Click);
            // 
            // btnC1
            // 
            this.btnC1.BackColor = System.Drawing.Color.White;
            this.btnC1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnC1.Location = new System.Drawing.Point(184, 432);
            this.btnC1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnC1.Name = "btnC1";
            this.btnC1.Size = new System.Drawing.Size(156, 120);
            this.btnC1.TabIndex = 19;
            this.btnC1.Tag = "play";
            this.btnC1.UseVisualStyleBackColor = false;
            this.btnC1.Click += new System.EventHandler(this.button_Click);
            // 
            // btnC2
            // 
            this.btnC2.BackColor = System.Drawing.Color.White;
            this.btnC2.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnC2.Location = new System.Drawing.Point(346, 432);
            this.btnC2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnC2.Name = "btnC2";
            this.btnC2.Size = new System.Drawing.Size(156, 120);
            this.btnC2.TabIndex = 20;
            this.btnC2.Tag = "play";
            this.btnC2.UseVisualStyleBackColor = false;
            this.btnC2.Click += new System.EventHandler(this.button_Click);
            // 
            // btnC3
            // 
            this.btnC3.BackColor = System.Drawing.Color.White;
            this.btnC3.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnC3.Location = new System.Drawing.Point(508, 432);
            this.btnC3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnC3.Name = "btnC3";
            this.btnC3.Size = new System.Drawing.Size(156, 120);
            this.btnC3.TabIndex = 21;
            this.btnC3.Tag = "play";
            this.btnC3.UseVisualStyleBackColor = false;
            this.btnC3.Click += new System.EventHandler(this.button_Click);
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.White;
            this.button12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button12.ForeColor = System.Drawing.Color.Red;
            this.button12.Image = global::game_tictactoe.Properties.Resources.left_5123;
            this.button12.Location = new System.Drawing.Point(2, 1);
            this.button12.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(86, 71);
            this.button12.TabIndex = 22;
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.button12_Click_1);
            // 
            // AImoves
            // 
            this.AImoves.Tick += new System.EventHandler(this.AImove);
            // 
            // btnPlay
            // 
            this.btnPlay.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.ForeColor = System.Drawing.Color.Blue;
            this.btnPlay.Location = new System.Drawing.Point(131, 115);
            this.btnPlay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(114, 45);
            this.btnPlay.TabIndex = 23;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // lblHuman
            // 
            this.lblHuman.AutoSize = true;
            this.lblHuman.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHuman.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblHuman.Location = new System.Drawing.Point(307, 125);
            this.lblHuman.Name = "lblHuman";
            this.lblHuman.Size = new System.Drawing.Size(106, 27);
            this.lblHuman.TabIndex = 24;
            this.lblHuman.Text = "Human: 0";
            // 
            // lblComputer
            // 
            this.lblComputer.AutoSize = true;
            this.lblComputer.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComputer.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblComputer.Location = new System.Drawing.Point(453, 125);
            this.lblComputer.Name = "lblComputer";
            this.lblComputer.Size = new System.Drawing.Size(132, 27);
            this.lblComputer.TabIndex = 24;
            this.lblComputer.Text = "Computer: 0";
            // 
            // button5
            // 
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.Location = new System.Drawing.Point(772, 1);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(81, 70);
            this.button5.TabIndex = 25;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // AI_Easy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 622);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.lblComputer);
            this.Controls.Add(this.lblHuman);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.btnC3);
            this.Controls.Add(this.btnC2);
            this.Controls.Add(this.btnC1);
            this.Controls.Add(this.btnB3);
            this.Controls.Add(this.btnB2);
            this.Controls.Add(this.btnB1);
            this.Controls.Add(this.btnA3);
            this.Controls.Add(this.btnA2);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnA1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AI_Easy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnA1;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnA2;
        private System.Windows.Forms.Button btnA3;
        private System.Windows.Forms.Button btnB1;
        private System.Windows.Forms.Button btnB2;
        private System.Windows.Forms.Button btnB3;
        private System.Windows.Forms.Button btnC1;
        private System.Windows.Forms.Button btnC2;
        private System.Windows.Forms.Button btnC3;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Timer AImoves;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Label lblHuman;
        private System.Windows.Forms.Label lblComputer;
        private System.Windows.Forms.Button button5;
    }
}