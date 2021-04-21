using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JamesMoonNoahConveryAssgt
{
    public partial class frmGroan : Form
    {
        public frmGroan()
        {
            InitializeComponent();
            lblBotName.Text = "Ultron";
            lblBotName.Visible = false;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            frmGroanGame GroanGame = new frmGroanGame();
            GroanGame.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void rbOnePlayer_CheckedChanged(object sender, EventArgs e)
        {
            txbxPlayerTwoName.Visible = false;
            lblBotName.Visible = true;
            
        }

        private void tbScoreLimit_Scroll(object sender, EventArgs e)
        {
            lblScoreLimit.Text = "Score Limit: First to " + tbScoreLimit.Value + " wins!";
        }

        private void rbTwoPlayers_CheckedChanged(object sender, EventArgs e)
        {
            txbxPlayerTwoName.Visible = true;
            lblBotName.Visible = true;
        }
    }
}
