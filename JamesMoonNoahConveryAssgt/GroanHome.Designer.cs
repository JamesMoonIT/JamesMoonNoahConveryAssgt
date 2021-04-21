
namespace JamesMoonNoahConveryAssgt
{
    partial class frmGroan
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnStart = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnRules = new System.Windows.Forms.Button();
            this.gbNumberOfPlayers = new System.Windows.Forms.GroupBox();
            this.rbTwoPlayers = new System.Windows.Forms.RadioButton();
            this.rbOnePlayer = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txbxPlayerOneName = new System.Windows.Forms.TextBox();
            this.txbxPlayerTwoName = new System.Windows.Forms.TextBox();
            this.lblPlayerTwo = new System.Windows.Forms.Label();
            this.tbScoreLimit = new System.Windows.Forms.TrackBar();
            this.lblScoreLimit = new System.Windows.Forms.Label();
            this.lblGroan = new System.Windows.Forms.Label();
            this.lblBotName = new System.Windows.Forms.Label();
            this.lblFeedback = new System.Windows.Forms.Label();
            this.gbNumberOfPlayers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbScoreLimit)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(19, 308);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(228, 308);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnRules
            // 
            this.btnRules.Location = new System.Drawing.Point(124, 308);
            this.btnRules.Name = "btnRules";
            this.btnRules.Size = new System.Drawing.Size(75, 23);
            this.btnRules.TabIndex = 2;
            this.btnRules.Text = "Rules";
            this.btnRules.UseVisualStyleBackColor = true;
            this.btnRules.Click += new System.EventHandler(this.btnRules_Click);
            // 
            // gbNumberOfPlayers
            // 
            this.gbNumberOfPlayers.Controls.Add(this.rbTwoPlayers);
            this.gbNumberOfPlayers.Controls.Add(this.rbOnePlayer);
            this.gbNumberOfPlayers.Location = new System.Drawing.Point(12, 73);
            this.gbNumberOfPlayers.Name = "gbNumberOfPlayers";
            this.gbNumberOfPlayers.Size = new System.Drawing.Size(306, 54);
            this.gbNumberOfPlayers.TabIndex = 3;
            this.gbNumberOfPlayers.TabStop = false;
            this.gbNumberOfPlayers.Text = "Number of Players";
            // 
            // rbTwoPlayers
            // 
            this.rbTwoPlayers.AutoSize = true;
            this.rbTwoPlayers.Location = new System.Drawing.Point(205, 23);
            this.rbTwoPlayers.Name = "rbTwoPlayers";
            this.rbTwoPlayers.Size = new System.Drawing.Size(86, 19);
            this.rbTwoPlayers.TabIndex = 1;
            this.rbTwoPlayers.TabStop = true;
            this.rbTwoPlayers.Text = "Two Players";
            this.rbTwoPlayers.UseVisualStyleBackColor = true;
            this.rbTwoPlayers.CheckedChanged += new System.EventHandler(this.rbTwoPlayers_CheckedChanged);
            // 
            // rbOnePlayer
            // 
            this.rbOnePlayer.AutoSize = true;
            this.rbOnePlayer.Location = new System.Drawing.Point(7, 23);
            this.rbOnePlayer.Name = "rbOnePlayer";
            this.rbOnePlayer.Size = new System.Drawing.Size(82, 19);
            this.rbOnePlayer.TabIndex = 0;
            this.rbOnePlayer.TabStop = true;
            this.rbOnePlayer.Text = "One Player";
            this.rbOnePlayer.UseVisualStyleBackColor = true;
            this.rbOnePlayer.CheckedChanged += new System.EventHandler(this.rbOnePlayer_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Player One Name:";
            // 
            // txbxPlayerOneName
            // 
            this.txbxPlayerOneName.Location = new System.Drawing.Point(19, 167);
            this.txbxPlayerOneName.Name = "txbxPlayerOneName";
            this.txbxPlayerOneName.Size = new System.Drawing.Size(100, 23);
            this.txbxPlayerOneName.TabIndex = 5;
            // 
            // txbxPlayerTwoName
            // 
            this.txbxPlayerTwoName.Location = new System.Drawing.Point(218, 167);
            this.txbxPlayerTwoName.Name = "txbxPlayerTwoName";
            this.txbxPlayerTwoName.Size = new System.Drawing.Size(100, 23);
            this.txbxPlayerTwoName.TabIndex = 6;
            // 
            // lblPlayerTwo
            // 
            this.lblPlayerTwo.AutoSize = true;
            this.lblPlayerTwo.Location = new System.Drawing.Point(217, 149);
            this.lblPlayerTwo.Name = "lblPlayerTwo";
            this.lblPlayerTwo.Size = new System.Drawing.Size(101, 15);
            this.lblPlayerTwo.TabIndex = 7;
            this.lblPlayerTwo.Text = "Player Two Name:";
            // 
            // tbScoreLimit
            // 
            this.tbScoreLimit.Location = new System.Drawing.Point(12, 241);
            this.tbScoreLimit.Maximum = 100;
            this.tbScoreLimit.Minimum = 50;
            this.tbScoreLimit.Name = "tbScoreLimit";
            this.tbScoreLimit.Size = new System.Drawing.Size(306, 45);
            this.tbScoreLimit.TabIndex = 8;
            this.tbScoreLimit.Value = 50;
            this.tbScoreLimit.Scroll += new System.EventHandler(this.tbScoreLimit_Scroll);
            // 
            // lblScoreLimit
            // 
            this.lblScoreLimit.AutoSize = true;
            this.lblScoreLimit.Location = new System.Drawing.Point(12, 220);
            this.lblScoreLimit.Name = "lblScoreLimit";
            this.lblScoreLimit.Size = new System.Drawing.Size(153, 15);
            this.lblScoreLimit.TabIndex = 9;
            this.lblScoreLimit.Text = "Score Limit: First to 50 wins!";
            // 
            // lblGroan
            // 
            this.lblGroan.AutoSize = true;
            this.lblGroan.Font = new System.Drawing.Font("Showcard Gothic", 30F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblGroan.Location = new System.Drawing.Point(82, 9);
            this.lblGroan.Name = "lblGroan";
            this.lblGroan.Size = new System.Drawing.Size(154, 50);
            this.lblGroan.TabIndex = 10;
            this.lblGroan.Text = "Groan";
            // 
            // lblBotName
            // 
            this.lblBotName.AutoSize = true;
            this.lblBotName.Location = new System.Drawing.Point(218, 170);
            this.lblBotName.Name = "lblBotName";
            this.lblBotName.Size = new System.Drawing.Size(0, 15);
            this.lblBotName.TabIndex = 11;
            // 
            // lblFeedback
            // 
            this.lblFeedback.AutoSize = true;
            this.lblFeedback.Location = new System.Drawing.Point(44, 342);
            this.lblFeedback.Name = "lblFeedback";
            this.lblFeedback.Size = new System.Drawing.Size(0, 15);
            this.lblFeedback.TabIndex = 12;
            // 
            // frmGroan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 369);
            this.Controls.Add(this.lblFeedback);
            this.Controls.Add(this.lblGroan);
            this.Controls.Add(this.lblScoreLimit);
            this.Controls.Add(this.tbScoreLimit);
            this.Controls.Add(this.lblPlayerTwo);
            this.Controls.Add(this.txbxPlayerTwoName);
            this.Controls.Add(this.txbxPlayerOneName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbNumberOfPlayers);
            this.Controls.Add(this.btnRules);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblBotName);
            this.Name = "frmGroan";
            this.Text = "Groan";
            this.gbNumberOfPlayers.ResumeLayout(false);
            this.gbNumberOfPlayers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbScoreLimit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnRules;
        private System.Windows.Forms.GroupBox gbNumberOfPlayers;
        private System.Windows.Forms.RadioButton rbTwoPlayers;
        private System.Windows.Forms.RadioButton rbOnePlayer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbxPlayerOneName;
        private System.Windows.Forms.TextBox txbxPlayerTwoName;
        private System.Windows.Forms.Label lblPlayerTwo;
        private System.Windows.Forms.TrackBar tbScoreLimit;
        private System.Windows.Forms.Label lblScoreLimit;
        private System.Windows.Forms.Label lblGroan;
        private System.Windows.Forms.Label lblBotName;
        private System.Windows.Forms.Label lblFeedback;
    }
}

