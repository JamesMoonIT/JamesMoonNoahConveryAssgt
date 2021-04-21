
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picbxPlayerOneBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbxPlayerTwoBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // picbxPlayerOneBack
            // 
            this.picbxPlayerOneBack.Location = new System.Drawing.Point(0, 0);
            this.picbxPlayerOneBack.Name = "picbxPlayerOneBack";
            this.picbxPlayerOneBack.Size = new System.Drawing.Size(170, 462);
            this.picbxPlayerOneBack.TabIndex = 0;
            this.picbxPlayerOneBack.TabStop = false;
            // 
            // picbxPlayerTwoBack
            // 
            this.picbxPlayerTwoBack.Location = new System.Drawing.Point(630, 0);
            this.picbxPlayerTwoBack.Name = "picbxPlayerTwoBack";
            this.picbxPlayerTwoBack.Size = new System.Drawing.Size(170, 462);
            this.picbxPlayerTwoBack.TabIndex = 1;
            this.picbxPlayerTwoBack.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(166, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(466, 93);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // frmGroanGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 461);
            this.Controls.Add(this.picbxPlayerTwoBack);
            this.Controls.Add(this.picbxPlayerOneBack);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmGroanGame";
            this.Text = "GroanGame";
            ((System.ComponentModel.ISupportInitialize)(this.picbxPlayerOneBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbxPlayerTwoBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picbxPlayerOneBack;
        private System.Windows.Forms.PictureBox picbxPlayerTwoBack;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}