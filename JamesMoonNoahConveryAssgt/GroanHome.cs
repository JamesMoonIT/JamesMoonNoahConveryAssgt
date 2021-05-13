/*
    Name: James Moon & Noah Convery
    Date: 12/05/21
    Description: The home page where the user can choose how many players, their names, and the score limit they would like to play to.
*/
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
            rbOnePlayer.Checked = true;                                                                                     // by default, checks one player
            lblBotName.Text = "Kitt";                                                                                       // sets bot name to Kitt (hope you know the reference)
            lblBotName.Visible = true;                                                                                      // makes sure the bot name is visible
        }
        // button that starts the game
        private void btnStart_Click(object sender, EventArgs e)
        {
            bool enableAI = false;                                                                                          // by default, the ai is set to false
            if (rbOnePlayer.Checked)                                                                                        // if only one player is selected
            {
                sP1Name = txbxPlayerOneName.Text;                                                                           // sets player 1 name
                if (sP1Name == "")                                                                                          // if player 1 name textbox is empty
                {
                    sP1Name = "Player One";                                                                                 // sets player one name to "Player One"
                }
                sP2Name = lblBotName.Text;                                                                                  // sets player two name to kitt
                enableAI = true;                                                                                            // enables ai
            }
            if (rbTwoPlayers.Checked)                                                                                       // if two player is selected
            {
                sP1Name = txbxPlayerOneName.Text;                                                                           // sets player 1 name
                if (sP1Name == "")                                                                                          // if player 1 name textbox is empty
                {
                    sP1Name = "Player One";                                                                                 // sets player one name to "Player One"
                }
                sP2Name = txbxPlayerTwoName.Text;                                                                           // sets player 2 name
                if (sP2Name == "")                                                                                          // if player 2 name textbox is empty
                {
                    sP2Name = "Player Two";                                                                                 // sets player 2 name to "Player Two"
                }
            }
            iScore = Convert.ToInt32(tbScoreLimit.Value);                                                                   // sets score to slider result
            newSession = new Session(sP1Name, sP2Name, iScore, enableAI);                                                   // creates new session with player 1 name, player 2 name, game score and boolean ai
            frmGroanGame GroanGame = new frmGroanGame(newSession);                                                          // creates a new form og GroanGame
            GroanGame.Show();                                                                                               // shows GroanGame form
            Hide();                                                                                                         // hides GroanRules
            if (newSession.IsThereAI() && newSession.GetCurrentGame().WhosTurn() == 1)                                      // checks if an ai is starting
            {
                GroanGame.AIStart();                                                                                        // ai starts their turn
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();                                                                                             // closes the program
        }

        private void rbOnePlayer_CheckedChanged(object sender, EventArgs e)                                                 // if player two selected while player one selected
        {
            txbxPlayerTwoName.Visible = false;                                                                              // hides player two name textbox
            lblBotName.Visible = true;                                                                                      // shows bot name

        }

        private void tbScoreLimit_Scroll(object sender, EventArgs e)                                                        // if slider is slid
        {
            lblScoreLimit.Text = "Score Limit: First to " + tbScoreLimit.Value + " wins!";                                  // updates score label
        }

        private void btnRules_Click(object sender, EventArgs e)
        {
            GroanRules GroanRules = new GroanRules();                                                                       // creates GroanRules as a form
            GroanRules.Show();                                                                                              // shows GroanRules
        }

        private void rbTwoPlayers_CheckedChanged(object sender, EventArgs e)                                                // if player one selected while player two selected
        {
            txbxPlayerTwoName.Visible = true;                                                                               // shows player two textbox
            lblBotName.Visible = false;                                                                                     // hides bot name
        }
    }
}
