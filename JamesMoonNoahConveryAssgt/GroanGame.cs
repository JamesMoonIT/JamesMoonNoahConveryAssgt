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
        private Graphics firstDice, secondDice;
        private Random rand;
        private Session currentSession;
        private SolidBrush background = new SolidBrush(Color.White);
        private SolidBrush dots = new SolidBrush(Color.Black);
        GroanRules GroanRules = new GroanRules();
        frmGroanHome GroanHome = new frmGroanHome();


        public frmGroanGame(Session currentGame)
        {
            InitializeComponent();
            firstDice = picbxDice1.CreateGraphics();
            secondDice = picbxDice2.CreateGraphics();
            rand = new Random();
            currentSession = currentGame;
            lblPlayer1Name.Text = currentSession.GetCurrentGame().GetPlayers()[0].getName();
            lblPlayer2Name.Text = currentSession.GetCurrentGame().GetPlayers()[1].getName();
            lblTurnIndicator.Text = "It is " + currentSession.GetCurrentGame().GetPlayers()[currentSession.GetCurrentGame().WhosTurn()].getName() + "'s turn!";
            lblGoal.Text = "Goal: First to " + currentSession.GetCurrentGame().GetGoal() + " wins!";
            MakePlayerTurn();
            btnNewGame.Visible = false;
            Application.DoEvents();
        }

        private void btnRules_Click(object sender, EventArgs e)
        {
            GroanRules.Show();
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            currentSession.restart(currentSession.GetCurrentGame().GetGoal());
            txtbxPlayer1Score.Text = "Cumulative Score: \r\n";
            txtbxPlayer2Score.Text = "Cumulative Score: \r\n";
            btnNewGame.Visible = false;
            btnRoll.Visible = true;
            btnPass.Visible = true;
            EnableButtons();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
            GroanHome.Show();
        }

        private void btnPass_Click(object sender, EventArgs e)
        {
            PassTurn();
            if (currentSession.IsThereAI() && currentSession.GetCurrentGame().WhosTurn() == 1)
            {
                AIStart();
            }
            EnableButtons();
        }

        public void AIStart()
        {
            DisableButtons();
            string botTurn = "Ok now it's my turn";
            MessageBox.Show(botTurn);
            AITurn();
            EnableButtons();
        }

        private void btnRoll_Click(object sender, EventArgs e)
        {
            DisableButtons();
            DiceRoll();
            if (currentSession.GetCurrentGame().IsGameOver() == false)
            {
                if (currentSession.IsThereAI() && currentSession.GetCurrentGame().WhosTurn() == 1)
                {
                    AIStart();
                }
            }
            EnableButtons();
        }

        public void AITurn()
        {
            if (currentSession.GetCurrentGame().WhosTurn() == 1)
            {
                System.Threading.Thread.Sleep(3000);
                DiceRoll();
                if (!currentSession.HasGameEnded())
                {
                    AIBrain();
                }
            }
        }

        private void AIBrain()
        {
            if (currentSession.GetCurrentGame().GetRunningScore() < 11)
            {
                AITurn();
            }
            else
            {
                PassTurn();
            }
        }

        private void PassTurn()
        {
            int grabbedRunningScore = currentSession.GetCurrentGame().GetRunningScore(), playerscore = currentSession.GetCurrentGame().GetPlayers()[currentSession.GetCurrentGame().WhosTurn()].getScore();
            currentSession.GetCurrentGame().GetPlayers()[currentSession.GetCurrentGame().WhosTurn()].setScore(grabbedRunningScore + playerscore);
            currentSession.GetCurrentGame().SetRunningScore(0);
            txtbxRunningScore.Text = "Turn Passed";
            if (currentSession.GetCurrentGame().WhosTurn() == 0)
            {
                if (grabbedRunningScore == 0 && playerscore == 0)
                {
                    txtbxPlayer1Score.Text = "Cumulative Score: \r\n" + 0;

                }
                else
                {
                    txtbxPlayer1Score.Text += "\r\n" + Convert.ToString(grabbedRunningScore + playerscore);
                }
            }
            else
            {
                if (grabbedRunningScore == 0 && playerscore == 0) 
                {
                    txtbxPlayer2Score.Text = "Cumulative Score: \r\n" + 0;
                }
                else
                {
                    txtbxPlayer2Score.Text += "\r\n" + Convert.ToString(grabbedRunningScore + playerscore);
                }
            }
            currentSession.GetCurrentGame().SwitchPlayers();
            txtbxRunningScore.Text = Convert.ToString(currentSession.GetCurrentGame().GetPlayers()[currentSession.GetCurrentGame().WhosTurn()].getScore());
            MakePlayerTurn();
        }

        private void DiceRoll()
        {
            DisableButtons();
            ClearDice();
            int roll1 = 0, roll2 = 0;
            for (int iteration = 0; iteration < 10; iteration++)
            {
                roll1 = rand.Next(1, 7);
                roll2 = rand.Next(1, 7);
                DisplayDice(roll1, 1);
                DisplayDice(roll2, 2);
                System.Threading.Thread.Sleep(100);
            }
            CheckDice(roll1, roll2);
            if (currentSession.HasGameEnded())
            {
                UpdateWins();
                currentSession.GetCurrentGame().GameIsOver();
                btnRoll.Visible = false;
                btnPass.Visible = false;
                btnQuit.Enabled = true;
                btnRules.Enabled = true;
                btnNewGame.Visible = true;
            }
        }

        private void MakePlayerTurn()
        {
            lblTurnIndicator.Text = "It is " + currentSession.GetCurrentGame().GetPlayers()[currentSession.GetCurrentGame().WhosTurn()].getName() + "'s turn!";
            if (currentSession.GetCurrentGame().WhosTurn() == 0)
            {
                picbxTurnIndicator.BackColor = Color.Red;
            }
            else
            {
                picbxTurnIndicator.BackColor = Color.Green;
            }
        }

        private void CheckDice(int result1, int result2)
        {
            int runningscore = currentSession.GetCurrentGame().GetRunningScore(), currentscore = currentSession.GetCurrentGame().GetPlayers()[currentSession.GetCurrentGame().WhosTurn()].getScore();
            if (result1 == 1 && result2 == 1)
            {
                // if player rolls two 1's
                runningscore = 0;
                currentSession.GetCurrentGame().GetPlayers()[currentSession.GetCurrentGame().WhosTurn()].setScore(runningscore);
                txtbxRunningScore.Text = Convert.ToString(runningscore);
                PassTurn();
            }
            else if (result1 == 1 || result2 == 1)
            {
                // if player rolls one 1
                runningscore = 0;
                currentSession.GetCurrentGame().SetRunningScore(runningscore);
                txtbxRunningScore.Text = Convert.ToString(runningscore);
                PassTurn();
            }
            else
            {
                // if player rolls zero 1's
                runningscore += result1 + result2;
                currentSession.GetCurrentGame().SetRunningScore(runningscore);
                txtbxRunningScore.Text = Convert.ToString(runningscore + currentscore);
            }
        }

        private void DisplayDice(int diceNum, int dice)
        {
            if (diceNum == 1)
            {
                CreateDiceFaceOne(dice);
            }
            else if (diceNum == 2)
            {
                CreateDiceFaceTwo(dice);
            }
            else if (diceNum == 3)
            {
                CreateDiceFaceThree(dice);
            }
            else if (diceNum == 4)
            {
                CreateDiceFaceFour(dice);
            }
            else if (diceNum == 5)
            {
                CreateDiceFaceFive(dice);
            }
            else
            {
                CreateDiceFaceSix(dice);
            }
        }

        private void ClearDice()
        {
            firstDice.Clear(Color.White);
            secondDice.Clear(Color.White);
        }

        private void DisableButtons()
        {
            btnRoll.Enabled = false;
            btnPass.Enabled = false;
            btnRules.Enabled = false;
            btnQuit.Enabled = false;
        }

        private void EnableButtons()
        {
            btnRoll.Enabled = true;
            btnPass.Enabled = true;
            btnRules.Enabled = true;
            btnQuit.Enabled = true;
        }

        private void UpdateWins()
        {
            if (currentSession.GetCurrentGame().WhosTurn() == 0)
            {
                lblP1Wins.Text = "Wins: " + Convert.ToString(currentSession.GetPlayerOneWins());
            }
            else
            {
                lblP2Wins.Text = "Wins: " + Convert.ToString(currentSession.GetPlayerTwoWins());
            }
        }

        private void CreateDiceFaceOne(int diceNumber)
        {
            if (diceNumber == 1)
            {
                firstDice.FillRectangle(background, 0, 0, 133, 133);
                firstDice.FillEllipse(dots, 57, 57, 19, 19);
            }
            else
            {
                secondDice.FillRectangle(background, 0, 0, 133, 133);
                secondDice.FillEllipse(dots, 57, 57, 19, 19);
            }
        }

        private void CreateDiceFaceTwo(int diceNumber)
        {
            if (diceNumber == 1)
            {
                firstDice.FillRectangle(background, 0, 0, 133, 133);
                firstDice.FillEllipse(dots, 19, 19, 19, 19);
                firstDice.FillEllipse(dots, 95, 95, 19, 19);
            }
            else
            {
                secondDice.FillRectangle(background, 0, 0, 133, 133);
                secondDice.FillEllipse(dots, 19, 19, 19, 19);
                secondDice.FillEllipse(dots, 95, 95, 19, 19);
            }
        }

        private void CreateDiceFaceThree(int diceNumber)
        {
            if (diceNumber == 1)
            {
                firstDice.FillRectangle(background, 0, 0, 133, 133);
                firstDice.FillEllipse(dots, 19, 19, 19, 19);
                firstDice.FillEllipse(dots, 57, 57, 19, 19);
                firstDice.FillEllipse(dots, 95, 95, 19, 19);
            }
            else
            {
                secondDice.FillRectangle(background, 0, 0, 133, 133);
                secondDice.FillEllipse(dots, 19, 19, 19, 19);
                secondDice.FillEllipse(dots, 57, 57, 19, 19);
                secondDice.FillEllipse(dots, 95, 95, 19, 19);
            }
        }

        private void CreateDiceFaceFour(int diceNumber)
        {
            if (diceNumber == 1)
            {
                firstDice.FillRectangle(background, 0, 0, 133, 133);
                firstDice.FillEllipse(dots, 19, 19, 19, 19);
                firstDice.FillEllipse(dots, 19, 95, 19, 19);
                firstDice.FillEllipse(dots, 95, 19, 19, 19);
                firstDice.FillEllipse(dots, 95, 95, 19, 19);
            }
            else
            {
                secondDice.FillRectangle(background, 0, 0, 133, 133);
                secondDice.FillEllipse(dots, 19, 19, 19, 19);
                secondDice.FillEllipse(dots, 19, 95, 19, 19);
                secondDice.FillEllipse(dots, 95, 19, 19, 19);
                secondDice.FillEllipse(dots, 95, 95, 19, 19);
            }
        }

        private void CreateDiceFaceFive(int diceNumber)
        {
            if (diceNumber == 1)
            {
                firstDice.FillRectangle(background, 0, 0, 133, 133);
                firstDice.FillEllipse(dots, 19, 19, 19, 19);
                firstDice.FillEllipse(dots, 19, 95, 19, 19);
                firstDice.FillEllipse(dots, 57, 57, 19, 19);
                firstDice.FillEllipse(dots, 95, 19, 19, 19);
                firstDice.FillEllipse(dots, 95, 95, 19, 19);
            }
            else
            {
                secondDice.FillRectangle(background, 0, 0, 133, 133);
                secondDice.FillEllipse(dots, 19, 19, 19, 19);
                secondDice.FillEllipse(dots, 19, 95, 19, 19);
                secondDice.FillEllipse(dots, 57, 57, 19, 19);
                secondDice.FillEllipse(dots, 95, 19, 19, 19);
                secondDice.FillEllipse(dots, 95, 95, 19, 19);
            }
        }

        private void txtbxPlayer1Score_TextChanged(object sender, EventArgs e)
        {

        }

        private void CreateDiceFaceSix(int diceNumber)
        {
            if (diceNumber == 1)
            {
                firstDice.FillRectangle(background, 0, 0, 133, 133);
                firstDice.FillEllipse(dots, 19, 19, 19, 19);
                firstDice.FillEllipse(dots, 19, 57, 19, 19);
                firstDice.FillEllipse(dots, 19, 95, 19, 19);
                firstDice.FillEllipse(dots, 95, 19, 19, 19);
                firstDice.FillEllipse(dots, 95, 57, 19, 19);
                firstDice.FillEllipse(dots, 95, 95, 19, 19);
            }
            else
            {
                secondDice.FillRectangle(background, 0, 0, 133, 133);
                secondDice.FillEllipse(dots, 19, 19, 19, 19);
                secondDice.FillEllipse(dots, 19, 57, 19, 19);
                secondDice.FillEllipse(dots, 19, 95, 19, 19);
                secondDice.FillEllipse(dots, 95, 19, 19, 19);
                secondDice.FillEllipse(dots, 95, 57, 19, 19);
                secondDice.FillEllipse(dots, 95, 95, 19, 19);
            }
        }
    }
}
