
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
            this.txbx = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblPlayerTwo = new System.Windows.Forms.Label();
            this.tbScoreLimit = new System.Windows.Forms.TrackBar();
            this.lblScoreLimit = new System.Windows.Forms.Label();
            this.gbNumberOfPlayers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbScoreLimit)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(30, 308);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(243, 308);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnRules
            // 
            this.btnRules.Location = new System.Drawing.Point(132, 308);
            this.btnRules.Name = "btnRules";
            this.btnRules.Size = new System.Drawing.Size(75, 23);
            this.btnRules.TabIndex = 2;
            this.btnRules.Text = "Rules";
            this.btnRules.UseVisualStyleBackColor = true;
            // 
            // gbNumberOfPlayers
            // 
            this.gbNumberOfPlayers.Controls.Add(this.rbTwoPlayers);
            this.gbNumberOfPlayers.Controls.Add(this.rbOnePlayer);
            this.gbNumberOfPlayers.Location = new System.Drawing.Point(12, 12);
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
            this.label1.Location = new System.Drawing.Point(19, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Player One Name:";
            // 
            // txbx
            // 
            this.txbx.Location = new System.Drawing.Point(19, 106);
            this.txbx.Name = "txbx";
            this.txbx.Size = new System.Drawing.Size(100, 23);
            this.txbx.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(218, 106);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 23);
            this.textBox2.TabIndex = 6;
            // 
            // lblPlayerTwo
            // 
            this.lblPlayerTwo.AutoSize = true;
            this.lblPlayerTwo.Location = new System.Drawing.Point(217, 88);
            this.lblPlayerTwo.Name = "lblPlayerTwo";
            this.lblPlayerTwo.Size = new System.Drawing.Size(101, 15);
            this.lblPlayerTwo.TabIndex = 7;
            this.lblPlayerTwo.Text = "Player Two Name:";
            // 
            // tbScoreLimit
            // 
            this.tbScoreLimit.Location = new System.Drawing.Point(12, 180);
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
            this.lblScoreLimit.Location = new System.Drawing.Point(12, 159);
            this.lblScoreLimit.Name = "lblScoreLimit";
            this.lblScoreLimit.Size = new System.Drawing.Size(153, 15);
            this.lblScoreLimit.TabIndex = 9;
            this.lblScoreLimit.Text = "Score Limit: First to 50 wins!";
            // 
            // frmGroan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 369);
            this.Controls.Add(this.lblScoreLimit);
            this.Controls.Add(this.tbScoreLimit);
            this.Controls.Add(this.lblPlayerTwo);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.txbx);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbNumberOfPlayers);
            this.Controls.Add(this.btnRules);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnStart);
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
        private System.Windows.Forms.TextBox txbx;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblPlayerTwo;
        private System.Windows.Forms.TrackBar tbScoreLimit;
        private System.Windows.Forms.Label lblScoreLimit;
    }
}

