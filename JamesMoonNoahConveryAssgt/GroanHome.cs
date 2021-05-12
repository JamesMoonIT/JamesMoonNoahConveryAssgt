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
    public partial class frmGroanHome : Form
    {
        public String sP1Name, sP2Name;
        private int iScore;
        private Session newSession;

        public frmGroanHome()
        {
            InitializeComponent();
            rbOnePlayer.Checked = true;
            lblBotName.Text = "Kitt";
            lblBotName.Visible = true;
        }
        // button that starts the game
        private void btnStart_Click(object sender, EventArgs e)
        {
            bool enableAI = false;
            if (rbOnePlayer.Checked) 
            {
                sP1Name = txbxPlayerOneName.Text;
                if (sP1Name == "")
                {
                    sP1Name = "Player One";
                }
                sP2Name = lblBotName.Text;
                enableAI = true;
            }
            if (rbTwoPlayers.Checked)
            {
                sP1Name = txbxPlayerOneName.Text;
                if (sP1Name == "")
                {
                    sP1Name = "Player One";
                }
                sP2Name = txbxPlayerTwoName.Text;
                if (sP2Name == "")
                {
                    sP2Name = "Player Two";
                }
            }
            iScore = Convert.ToInt32(tbScoreLimit.Value);
            newSession = new Session(sP1Name, sP2Name, iScore, enableAI);
            frmGroanGame GroanGame = new frmGroanGame(newSession);
            GroanGame.Show();
            Hide();
            if (newSession.IsThereAI() && newSession.GetCurrentGame().WhosTurn() == 1)
            {
                GroanGame.AIStart();
            }
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

        private void btnRules_Click(object sender, EventArgs e)
        {
            GroanRules GroanRules = new GroanRules();
            GroanRules.Show();
        }

        private void rbTwoPlayers_CheckedChanged(object sender, EventArgs e)
        {
            txbxPlayerTwoName.Visible = true;
            lblBotName.Visible = true;
        }
    }
}
