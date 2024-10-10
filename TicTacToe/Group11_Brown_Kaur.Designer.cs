namespace TicTacToe
{
    partial class Group11_Brown_Kaur
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
            this.lblGridsize = new System.Windows.Forms.Label();
            this.lblround = new System.Windows.Forms.Label();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.displayrounds = new System.Windows.Forms.Label();
            this.buttonStartnewgame = new System.Windows.Forms.Button();
            this.Exitgame = new System.Windows.Forms.Button();
            this.labelscoreboard = new System.Windows.Forms.Label();
            this.Player1 = new System.Windows.Forms.Label();
            this.panel = new System.Windows.Forms.Panel();
            this.lblgame = new System.Windows.Forms.Label();
            this.labelplayer2 = new System.Windows.Forms.Label();
            this.labelPlayertwo = new System.Windows.Forms.Label();
            this.scoreplayer1 = new System.Windows.Forms.Label();
            this.pictureBoxCircle = new System.Windows.Forms.PictureBox();
            this.pictureBoxX = new System.Windows.Forms.PictureBox();
            this.CircleWinning = new System.Windows.Forms.PictureBox();
            this.Xwinning = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCircle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CircleWinning)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Xwinning)).BeginInit();
            this.SuspendLayout();
            // 
            // lblGridsize
            // 
            this.lblGridsize.AutoSize = true;
            this.lblGridsize.BackColor = System.Drawing.Color.Lavender;
            this.lblGridsize.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGridsize.Location = new System.Drawing.Point(11, 120);
            this.lblGridsize.Name = "lblGridsize";
            this.lblGridsize.Size = new System.Drawing.Size(94, 20);
            this.lblGridsize.TabIndex = 0;
            this.lblGridsize.Text = "Grid Size:";
            // 
            // lblround
            // 
            this.lblround.AutoSize = true;
            this.lblround.BackColor = System.Drawing.Color.Lavender;
            this.lblround.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblround.Location = new System.Drawing.Point(15, 156);
            this.lblround.Name = "lblround";
            this.lblround.Size = new System.Drawing.Size(68, 20);
            this.lblround.TabIndex = 1;
            this.lblround.Text = "Round:";
            // 
            // comboBox
            // 
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Location = new System.Drawing.Point(127, 118);
            this.comboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(108, 24);
            this.comboBox.TabIndex = 2;
            this.comboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox_SelectedIndexChanged);
            // 
            // displayrounds
            // 
            this.displayrounds.AutoSize = true;
            this.displayrounds.BackColor = System.Drawing.Color.Lavender;
            this.displayrounds.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayrounds.Location = new System.Drawing.Point(132, 155);
            this.displayrounds.Name = "displayrounds";
            this.displayrounds.Size = new System.Drawing.Size(27, 24);
            this.displayrounds.TabIndex = 3;
            this.displayrounds.Text = " 1";
            // 
            // buttonStartnewgame
            // 
            this.buttonStartnewgame.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStartnewgame.Location = new System.Drawing.Point(11, 204);
            this.buttonStartnewgame.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonStartnewgame.Name = "buttonStartnewgame";
            this.buttonStartnewgame.Size = new System.Drawing.Size(202, 30);
            this.buttonStartnewgame.TabIndex = 4;
            this.buttonStartnewgame.Text = "Start New Game";
            this.buttonStartnewgame.UseVisualStyleBackColor = true;
            this.buttonStartnewgame.Click += new System.EventHandler(this.buttonStartnewgame_Click);
            // 
            // Exitgame
            // 
            this.Exitgame.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exitgame.Location = new System.Drawing.Point(67, 249);
            this.Exitgame.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Exitgame.Name = "Exitgame";
            this.Exitgame.Size = new System.Drawing.Size(85, 36);
            this.Exitgame.TabIndex = 5;
            this.Exitgame.Text = "Exit";
            this.Exitgame.UseVisualStyleBackColor = true;
            this.Exitgame.Click += new System.EventHandler(this.Exitgame_Click);
            // 
            // labelscoreboard
            // 
            this.labelscoreboard.AutoSize = true;
            this.labelscoreboard.BackColor = System.Drawing.Color.Lavender;
            this.labelscoreboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelscoreboard.Location = new System.Drawing.Point(777, 137);
            this.labelscoreboard.Name = "labelscoreboard";
            this.labelscoreboard.Size = new System.Drawing.Size(114, 20);
            this.labelscoreboard.TabIndex = 6;
            this.labelscoreboard.Text = "Score Board";
            // 
            // Player1
            // 
            this.Player1.AutoSize = true;
            this.Player1.BackColor = System.Drawing.Color.Lavender;
            this.Player1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player1.Location = new System.Drawing.Point(694, 181);
            this.Player1.Name = "Player1";
            this.Player1.Size = new System.Drawing.Size(72, 20);
            this.Player1.TabIndex = 0;
            this.Player1.Text = "Player1";
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.Azure;
            this.panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel.ForeColor = System.Drawing.SystemColors.Control;
            this.panel.Location = new System.Drawing.Point(294, 107);
            this.panel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(367, 339);
            this.panel.TabIndex = 8;
            // 
            // lblgame
            // 
            this.lblgame.AutoSize = true;
            this.lblgame.Font = new System.Drawing.Font("Goudy Stout", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgame.Location = new System.Drawing.Point(228, 14);
            this.lblgame.Name = "lblgame";
            this.lblgame.Size = new System.Drawing.Size(547, 60);
            this.lblgame.TabIndex = 10;
            this.lblgame.Text = "TIC TAC TOE";
            // 
            // labelplayer2
            // 
            this.labelplayer2.AutoSize = true;
            this.labelplayer2.BackColor = System.Drawing.Color.Lavender;
            this.labelplayer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelplayer2.Location = new System.Drawing.Point(897, 181);
            this.labelplayer2.Name = "labelplayer2";
            this.labelplayer2.Size = new System.Drawing.Size(72, 20);
            this.labelplayer2.TabIndex = 0;
            this.labelplayer2.Text = "Player2";
            // 
            // labelPlayertwo
            // 
            this.labelPlayertwo.AutoSize = true;
            this.labelPlayertwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlayertwo.ForeColor = System.Drawing.SystemColors.Control;
            this.labelPlayertwo.Location = new System.Drawing.Point(892, 349);
            this.labelPlayertwo.Name = "labelPlayertwo";
            this.labelPlayertwo.Size = new System.Drawing.Size(118, 17);
            this.labelPlayertwo.TabIndex = 1;
            this.labelPlayertwo.Text = "Player 2 Wins: ";
            // 
            // scoreplayer1
            // 
            this.scoreplayer1.AutoSize = true;
            this.scoreplayer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreplayer1.ForeColor = System.Drawing.SystemColors.Control;
            this.scoreplayer1.Location = new System.Drawing.Point(704, 349);
            this.scoreplayer1.Name = "scoreplayer1";
            this.scoreplayer1.Size = new System.Drawing.Size(118, 17);
            this.scoreplayer1.TabIndex = 1;
            this.scoreplayer1.Text = "Player 1 Wins: ";
            // 
            // pictureBoxCircle
            // 
            this.pictureBoxCircle.Image = global::TicTacToe.Properties.Resources.PlayerCircle;
            this.pictureBoxCircle.Location = new System.Drawing.Point(698, 214);
            this.pictureBoxCircle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxCircle.Name = "pictureBoxCircle";
            this.pictureBoxCircle.Size = new System.Drawing.Size(72, 59);
            this.pictureBoxCircle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCircle.TabIndex = 11;
            this.pictureBoxCircle.TabStop = false;
            // 
            // pictureBoxX
            // 
            this.pictureBoxX.Image = global::TicTacToe.Properties.Resources.PlayerX;
            this.pictureBoxX.Location = new System.Drawing.Point(895, 214);
            this.pictureBoxX.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxX.Name = "pictureBoxX";
            this.pictureBoxX.Size = new System.Drawing.Size(65, 49);
            this.pictureBoxX.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxX.TabIndex = 12;
            this.pictureBoxX.TabStop = false;
            // 
            // CircleWinning
            // 
            this.CircleWinning.BackColor = System.Drawing.Color.Transparent;
            this.CircleWinning.Image = global::TicTacToe.Properties.Resources.Winner;
            this.CircleWinning.Location = new System.Drawing.Point(698, 433);
            this.CircleWinning.Name = "CircleWinning";
            this.CircleWinning.Size = new System.Drawing.Size(77, 79);
            this.CircleWinning.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CircleWinning.TabIndex = 14;
            this.CircleWinning.TabStop = false;
            // 
            // Xwinning
            // 
            this.Xwinning.BackColor = System.Drawing.Color.Transparent;
            this.Xwinning.Image = global::TicTacToe.Properties.Resources.Winner;
            this.Xwinning.Location = new System.Drawing.Point(892, 433);
            this.Xwinning.Name = "Xwinning";
            this.Xwinning.Size = new System.Drawing.Size(77, 79);
            this.Xwinning.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Xwinning.TabIndex = 15;
            this.Xwinning.TabStop = false;
            // 
            // Group11_Brown_Kaur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1042, 584);
            this.Controls.Add(this.Xwinning);
            this.Controls.Add(this.CircleWinning);
            this.Controls.Add(this.pictureBoxX);
            this.Controls.Add(this.pictureBoxCircle);
            this.Controls.Add(this.labelPlayertwo);
            this.Controls.Add(this.scoreplayer1);
            this.Controls.Add(this.labelplayer2);
            this.Controls.Add(this.lblgame);
            this.Controls.Add(this.Player1);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.labelscoreboard);
            this.Controls.Add(this.Exitgame);
            this.Controls.Add(this.buttonStartnewgame);
            this.Controls.Add(this.displayrounds);
            this.Controls.Add(this.comboBox);
            this.Controls.Add(this.lblround);
            this.Controls.Add(this.lblGridsize);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Group11_Brown_Kaur";
            this.Text = "Group11_Brown_Kaur11";
            this.Load += new System.EventHandler(this.Group11_Brown_Kaur_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCircle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CircleWinning)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Xwinning)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGridsize;
        private System.Windows.Forms.Label lblround;
        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.Label displayrounds;
        private System.Windows.Forms.Button buttonStartnewgame;
        private System.Windows.Forms.Button Exitgame;
        private System.Windows.Forms.Label labelscoreboard;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Label Player1;
        private System.Windows.Forms.Label lblgame;
        private System.Windows.Forms.Label labelplayer2;
        private System.Windows.Forms.Label labelPlayertwo;
        private System.Windows.Forms.Label scoreplayer1;
        private System.Windows.Forms.PictureBox pictureBoxCircle;
        private System.Windows.Forms.PictureBox pictureBoxX;
        private System.Windows.Forms.PictureBox CircleWinning;
        private System.Windows.Forms.PictureBox Xwinning;
    }
}

