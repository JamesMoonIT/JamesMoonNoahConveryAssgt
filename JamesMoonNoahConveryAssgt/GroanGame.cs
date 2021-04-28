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
    public partial class frmGroanGame : Form
    {
        private Graphics graDiceOne;
        private Graphics graDiceTwo;
        private Graphics graDiceThree;
        private Graphics graDiceFour;
        private Graphics graDiceFive;
        private Graphics graDiceSix;
        private Graphics firstDice, secondDice;
        private PictureBox firstDiceBox, secondDiceBox;
        private Random rand;
        private Session currentSession;
        private SolidBrush background = new SolidBrush(Color.White);
        private SolidBrush dots = new SolidBrush(Color.Black);


        public frmGroanGame(Session currentGame)
        {
            InitializeComponent();
            rand = new Random();
            currentSession = currentGame;
            lblPlayer1Name.Text = currentSession.GetCurrentGame().GetPlayers()[0].getName();
            lblPlayer2Name.Text = currentSession.GetCurrentGame().GetPlayers()[1].getName();
            lblTurnIndicator.Text = "It is " + currentSession.GetCurrentGame().GetPlayers()[currentSession.GetCurrentGame().WhosTurn()].getName() + "'s turn!";
            lblGoal.Text = "Goal: First to " + currentSession.GetCurrentGame().GetGoal() + " wins!";
            //txtbxRunningScore.Text = currentSession.GetCurrentGame().get
        }

        private void btnRules_Click(object sender, EventArgs e)
        {
            GroanRules GroanRules = new GroanRules();

            GroanRules.Show();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            frmGroanHome GroanHome = new frmGroanHome();

            this.Close();
            GroanHome.Show();
            
        }

        private void btnRoll_Click(object sender, EventArgs e)
        {
            btnRoll.Visible = false;
            btnRoll.Refresh();
            DiceRoll();
            if (currentSession.IsThereAI() && currentSession.GetCurrentGame().WhosTurn() == 1)
            {
                AITurn();
            }
        }

        private void AITurn()
        {
            DiceRoll();
        }

        private void DiceRoll()
        {
            int[] intScore = new int[1];
            // CLearDice();
            for (int i = 0; i < 5; i++)
            {

            }
        }

        private void ClearDice()
        {
            array
        }

        private void CreateDiceFaceOne(Graphics graDiceNumber)
        {
            graDiceNumber.FillRectangle(background, 0, 0, 133, 133);
            graDiceNumber.FillEllipse(dots, 57, 57, 19, 19);
        }

        private void CreateDiceFaceTwo(Graphics graDiceNumber)
        {
            graDiceNumber.FillRectangle(background, 0, 0, 133, 133);
            graDiceNumber.FillEllipse(dots, 19, 19, 19, 19);
            graDiceNumber.FillEllipse(dots, 95, 95, 19, 19);
        }

        private void CreateDiceFaceThree(Graphics graDiceNumber)
        {
            graDiceNumber.FillRectangle(background, 0, 0, 133, 133);
            graDiceNumber.FillEllipse(dots, 19, 19, 19, 19);
            graDiceNumber.FillEllipse(dots, 57, 57, 19, 19);
            graDiceNumber.FillEllipse(dots, 95, 95, 19, 19);
        }

        private void CreateDiceFaceFour(Graphics graDiceNumber)
        {
            graDiceNumber.FillRectangle(background, 0, 0, 133, 133);
            graDiceNumber.FillEllipse(dots, 19, 19, 19, 19);
            graDiceNumber.FillEllipse(dots, 19, 95, 19, 19);
            graDiceNumber.FillEllipse(dots, 95, 19, 19, 19);
            graDiceNumber.FillEllipse(dots, 95, 95, 19, 19);
        }

        private void CreateDiceFaceFive(Graphics graDiceNumber)
        {
            graDiceNumber.FillRectangle(background, 0, 0, 133, 133);
            graDiceNumber.FillEllipse(dots, 19, 19, 19, 19);
            graDiceNumber.FillEllipse(dots, 19, 95, 19, 19);
            graDiceNumber.FillEllipse(dots, 57, 57, 19, 19);
            graDiceNumber.FillEllipse(dots, 95, 19, 19, 19);
            graDiceNumber.FillEllipse(dots, 95, 95, 19, 19);
        }

        private void CreateDiceFaceSix(Graphics graDiceNumber)
        {
            graDiceNumber.FillRectangle(background, 0, 0, 133, 133);
            graDiceNumber.FillEllipse(dots, 19, 19, 19, 19);
            graDiceNumber.FillEllipse(dots, 19, 57, 19, 19);
            graDiceNumber.FillEllipse(dots, 19, 95, 19, 19);
            graDiceNumber.FillEllipse(dots, 95, 19, 19, 19);
            graDiceNumber.FillEllipse(dots, 95, 57, 19, 19);
            graDiceNumber.FillEllipse(dots, 95, 95, 19, 19);
        }
    }
}
