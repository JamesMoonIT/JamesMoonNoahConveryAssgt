﻿using System;
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
        public String sP1Name, sP2Name;
        private int iScore;
        frmGroanGame GroanGame = new frmGroanGame();
        frmGroanRules GroanRules = new frmGroanRules();

        public frmGroan()
        {
            InitializeComponent();
            lblBotName.Text = "Ultron";
            lblBotName.Visible = false;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            try
            {
                if (rbOnePlayer.Checked)
                {
                    sP1Name = txbxPlayerOneName.Text;
                    sP2Name = lblBotName.Text;
                }
                if (rbTwoPlayers.Checked) {
                    sP1Name = txbxPlayerOneName.Text;
                    sP2Name = txbxPlayerTwoName.Text;
                }
                GroanGame.Show();
            }
            catch
            {
                lblFeedback.Text = "Please enter a name into all applicable name fields.";
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
            GroanRules.Show();
        }

        private void rbTwoPlayers_CheckedChanged(object sender, EventArgs e)
        {
            txbxPlayerTwoName.Visible = true;
            lblBotName.Visible = true;
        }
    }
}
