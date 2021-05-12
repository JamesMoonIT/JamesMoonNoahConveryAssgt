
namespace JamesMoonNoahConveryAssgt
{
    partial class frmGroanGame
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
            this.picbxPlayerOneBack = new System.Windows.Forms.PictureBox();
            this.picbxPlayerTwoBack = new System.Windows.Forms.PictureBox();
            this.picbxTurnIndicator = new System.Windows.Forms.PictureBox();
            this.lblPlayer2Name = new System.Windows.Forms.Label();
            this.lblPlayer1Name = new System.Windows.Forms.Label();
            this.lblTurnIndicator = new System.Windows.Forms.Label();
            this.btnRoll = new System.Windows.Forms.Button();
            this.lblRunningScore = new System.Windows.Forms.Label();
            this.btnPass = new System.Windows.Forms.Button();
            this.txtbxRunningScore = new System.Windows.Forms.TextBox();
            this.btnRules = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.txtbxPlayer1Score = new System.Windows.Forms.TextBox();
            this.txtbxPlayer2Score = new System.Windows.Forms.TextBox();
            this.picbxDice1 = new System.Windows.Forms.PictureBox();
            this.picbxDice2 = new System.Windows.Forms.PictureBox();
            this.lblGoal = new System.Windows.Forms.Label();
            this.picbxBackground = new System.Windows.Forms.PictureBox();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.lblP1Wins = new System.Windows.Forms.Label();
            this.lblP2Wins = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picbxPlayerOneBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbxPlayerTwoBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbxTurnIndicator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbxDice1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbxDice2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbxBackground)).BeginInit();
            this.SuspendLayout();
            // 
            // picbxPlayerOneBack
            // 
            this.picbxPlayerOneBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.picbxPlayerOneBack.Location = new System.Drawing.Point(0, 0);
            this.picbxPlayerOneBack.Name = "picbxPlayerOneBack";
            this.picbxPlayerOneBack.Size = new System.Drawing.Size(170, 462);
            this.picbxPlayerOneBack.TabIndex = 0;
            this.picbxPlayerOneBack.TabStop = false;
            // 
            // picbxPlayerTwoBack
            // 
            this.picbxPlayerTwoBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.picbxPlayerTwoBack.Location = new System.Drawing.Point(630, 0);
            this.picbxPlayerTwoBack.Name = "picbxPlayerTwoBack";
            this.picbxPlayerTwoBack.Size = new System.Drawing.Size(170, 462);
            this.picbxPlayerTwoBack.TabIndex = 1;
            this.picbxPlayerTwoBack.TabStop = false;
            // 
            // picbxTurnIndicator
            // 
            this.picbxTurnIndicator.BackColor = System.Drawing.Color.White;
            this.picbxTurnIndicator.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picbxTurnIndicator.Location = new System.Drawing.Point(166, 0);
            this.picbxTurnIndicator.Name = "picbxTurnIndicator";
            this.picbxTurnIndicator.Size = new System.Drawing.Size(466, 93);
            this.picbxTurnIndicator.TabIndex = 2;
            this.picbxTurnIndicator.TabStop = false;
            // 
            // lblPlayer2Name
            // 
            this.lblPlayer2Name.BackColor = System.Drawing.Color.Black;
            this.lblPlayer2Name.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPlayer2Name.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPlayer2Name.ForeColor = System.Drawing.Color.White;
            this.lblPlayer2Name.Location = new System.Drawing.Point(650, 18);
            this.lblPlayer2Name.Name = "lblPlayer2Name";
            this.lblPlayer2Name.Size = new System.Drawing.Size(128, 28);
            this.lblPlayer2Name.TabIndex = 3;
            this.lblPlayer2Name.Text = "Player2Name";
            this.lblPlayer2Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPlayer1Name
            // 
            this.lblPlayer1Name.BackColor = System.Drawing.Color.Black;
            this.lblPlayer1Name.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPlayer1Name.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPlayer1Name.ForeColor = System.Drawing.Color.White;
            this.lblPlayer1Name.Location = new System.Drawing.Point(21, 18);
            this.lblPlayer1Name.Name = "lblPlayer1Name";
            this.lblPlayer1Name.Size = new System.Drawing.Size(128, 28);
            this.lblPlayer1Name.TabIndex = 4;
            this.lblPlayer1Name.Text = "Player1Name";
            this.lblPlayer1Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTurnIndicator
            // 
            this.lblTurnIndicator.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTurnIndicator.BackColor = System.Drawing.Color.Transparent;
            this.lblTurnIndicator.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTurnIndicator.Location = new System.Drawing.Point(206, 18);
            this.lblTurnIndicator.Name = "lblTurnIndicator";
            this.lblTurnIndicator.Size = new System.Drawing.Size(396, 28);
            this.lblTurnIndicator.TabIndex = 5;
            this.lblTurnIndicator.Text = "It is Player 1\'s turn";
            this.lblTurnIndicator.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnRoll
            // 
            this.btnRoll.Location = new System.Drawing.Point(325, 370);
            this.btnRoll.Name = "btnRoll";
            this.btnRoll.Size = new System.Drawing.Size(75, 23);
            this.btnRoll.TabIndex = 6;
            this.btnRoll.Text = "Roll";
            this.btnRoll.UseVisualStyleBackColor = true;
            this.btnRoll.Click += new System.EventHandler(this.btnRoll_Click);
            // 
            // lblRunningScore
            // 
            this.lblRunningScore.AutoSize = true;
            this.lblRunningScore.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRunningScore.Location = new System.Drawing.Point(325, 109);
            this.lblRunningScore.Name = "lblRunningScore";
            this.lblRunningScore.Size = new System.Drawing.Size(139, 28);
            this.lblRunningScore.TabIndex = 7;
            this.lblRunningScore.Text = "Running Score";
            // 
            // btnPass
            // 
            this.btnPass.Location = new System.Drawing.Point(420, 370);
            this.btnPass.Name = "btnPass";
            this.btnPass.Size = new System.Drawing.Size(75, 23);
            this.btnPass.TabIndex = 8;
            this.btnPass.Text = "Pass";
            this.btnPass.UseVisualStyleBackColor = true;
            this.btnPass.Click += new System.EventHandler(this.btnPass_Click);
            // 
            // txtbxRunningScore
            // 
            this.txtbxRunningScore.Enabled = false;
            this.txtbxRunningScore.Location = new System.Drawing.Point(342, 140);
            this.txtbxRunningScore.Name = "txtbxRunningScore";
            this.txtbxRunningScore.ReadOnly = true;
            this.txtbxRunningScore.Size = new System.Drawing.Size(100, 23);
            this.txtbxRunningScore.TabIndex = 9;
            // 
            // btnRules
            // 
            this.btnRules.Location = new System.Drawing.Point(325, 415);
            this.btnRules.Name = "btnRules";
            this.btnRules.Size = new System.Drawing.Size(75, 23);
            this.btnRules.TabIndex = 10;
            this.btnRules.Text = "Rules";
            this.btnRules.UseVisualStyleBackColor = true;
            this.btnRules.Click += new System.EventHandler(this.btnRules_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(420, 415);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(75, 23);
            this.btnQuit.TabIndex = 11;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // txtbxPlayer1Score
            // 
            this.txtbxPlayer1Score.BackColor = System.Drawing.Color.Black;
            this.txtbxPlayer1Score.ForeColor = System.Drawing.Color.White;
            this.txtbxPlayer1Score.Location = new System.Drawing.Point(21, 93);
            this.txtbxPlayer1Score.Multiline = true;
            this.txtbxPlayer1Score.Name = "txtbxPlayer1Score";
            this.txtbxPlayer1Score.ReadOnly = true;
            this.txtbxPlayer1Score.Size = new System.Drawing.Size(128, 345);
            this.txtbxPlayer1Score.TabIndex = 12;
            this.txtbxPlayer1Score.Text = "Cumulative Score:";
            // 
            // txtbxPlayer2Score
            // 
            this.txtbxPlayer2Score.BackColor = System.Drawing.Color.Black;
            this.txtbxPlayer2Score.ForeColor = System.Drawing.Color.White;
            this.txtbxPlayer2Score.Location = new System.Drawing.Point(650, 93);
            this.txtbxPlayer2Score.Multiline = true;
            this.txtbxPlayer2Score.Name = "txtbxPlayer2Score";
            this.txtbxPlayer2Score.ReadOnly = true;
            this.txtbxPlayer2Score.Size = new System.Drawing.Size(128, 345);
            this.txtbxPlayer2Score.TabIndex = 13;
            this.txtbxPlayer2Score.Text = "Cumulative Score:";
            // 
            // picbxDice1
            // 
            this.picbxDice1.Location = new System.Drawing.Point(206, 213);
            this.picbxDice1.Name = "picbxDice1";
            this.picbxDice1.Size = new System.Drawing.Size(133, 133);
            this.picbxDice1.TabIndex = 14;
            this.picbxDice1.TabStop = false;
            // 
            // picbxDice2
            // 
            this.picbxDice2.Location = new System.Drawing.Point(469, 213);
            this.picbxDice2.Name = "picbxDice2";
            this.picbxDice2.Size = new System.Drawing.Size(133, 133);
            this.picbxDice2.TabIndex = 15;
            this.picbxDice2.TabStop = false;
            // 
            // lblGoal
            // 
            this.lblGoal.BackColor = System.Drawing.Color.Transparent;
            this.lblGoal.Location = new System.Drawing.Point(336, 56);
            this.lblGoal.Name = "lblGoal";
            this.lblGoal.Size = new System.Drawing.Size(128, 21);
            this.lblGoal.TabIndex = 16;
            this.lblGoal.Text = "Goal :";
            this.lblGoal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picbxBackground
            // 
            this.picbxBackground.BackColor = System.Drawing.Color.MidnightBlue;
            this.picbxBackground.Location = new System.Drawing.Point(166, 93);
            this.picbxBackground.Name = "picbxBackground";
            this.picbxBackground.Size = new System.Drawing.Size(466, 369);
            this.picbxBackground.TabIndex = 17;
            this.picbxBackground.TabStop = false;
            // 
            // btnNewGame
            // 
            this.btnNewGame.Location = new System.Drawing.Point(367, 370);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(75, 23);
            this.btnNewGame.TabIndex = 18;
            this.btnNewGame.Text = "New Game";
            this.btnNewGame.UseVisualStyleBackColor = true;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // lblP1Wins
            // 
            this.lblP1Wins.AutoSize = true;
            this.lblP1Wins.BackColor = System.Drawing.Color.Black;
            this.lblP1Wins.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblP1Wins.ForeColor = System.Drawing.Color.White;
            this.lblP1Wins.Location = new System.Drawing.Point(58, 59);
            this.lblP1Wins.Name = "lblP1Wins";
            this.lblP1Wins.Size = new System.Drawing.Size(47, 17);
            this.lblP1Wins.TabIndex = 19;
            this.lblP1Wins.Text = "Wins: 0";
            // 
            // lblP2Wins
            // 
            this.lblP2Wins.AutoSize = true;
            this.lblP2Wins.BackColor = System.Drawing.Color.Black;
            this.lblP2Wins.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblP2Wins.ForeColor = System.Drawing.Color.White;
            this.lblP2Wins.Location = new System.Drawing.Point(689, 59);
            this.lblP2Wins.Name = "lblP2Wins";
            this.lblP2Wins.Size = new System.Drawing.Size(47, 17);
            this.lblP2Wins.TabIndex = 20;
            this.lblP2Wins.Text = "Wins: 0";
            // 
            // frmGroanGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 461);
            this.Controls.Add(this.lblP2Wins);
            this.Controls.Add(this.lblP1Wins);
            this.Controls.Add(this.btnNewGame);
            this.Controls.Add(this.lblGoal);
            this.Controls.Add(this.picbxDice2);
            this.Controls.Add(this.picbxDice1);
            this.Controls.Add(this.txtbxPlayer2Score);
            this.Controls.Add(this.txtbxPlayer1Score);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnRules);
            this.Controls.Add(this.txtbxRunningScore);
            this.Controls.Add(this.btnPass);
            this.Controls.Add(this.lblRunningScore);
            this.Controls.Add(this.btnRoll);
            this.Controls.Add(this.lblTurnIndicator);
            this.Controls.Add(this.lblPlayer1Name);
            this.Controls.Add(this.lblPlayer2Name);
            this.Controls.Add(this.picbxPlayerTwoBack);
            this.Controls.Add(this.picbxPlayerOneBack);
            this.Controls.Add(this.picbxTurnIndicator);
            this.Controls.Add(this.picbxBackground);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmGroanGame";
            this.Text = "GroanGame";
            ((System.ComponentModel.ISupportInitialize)(this.picbxPlayerOneBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbxPlayerTwoBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbxTurnIndicator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbxDice1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbxDice2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbxBackground)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picbxPlayerOneBack;
        private System.Windows.Forms.PictureBox picbxPlayerTwoBack;
        private System.Windows.Forms.PictureBox picbxTurnIndicator;
        private System.Windows.Forms.Label lblPlayer2Name;
        private System.Windows.Forms.Label lblPlayer1Name;
        private System.Windows.Forms.Label lblTurnIndicator;
        private System.Windows.Forms.Button btnRoll;
        private System.Windows.Forms.Label lblRunningScore;
        private System.Windows.Forms.Button btnPass;
        private System.Windows.Forms.TextBox txtbxRunningScore;
        private System.Windows.Forms.Button btnRules;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.TextBox txtbxPlayer1Score;
        private System.Windows.Forms.TextBox txtbxPlayer2Score;
        private System.Windows.Forms.PictureBox picbxDice1;
        private System.Windows.Forms.PictureBox picbxDice2;
        private System.Windows.Forms.Label lblGoal;
        private System.Windows.Forms.PictureBox picbxBackground;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.Label lblP1Wins;
        private System.Windows.Forms.Label lblP2Wins;
    }
}