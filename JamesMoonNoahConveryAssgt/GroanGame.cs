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
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            GroanHome.Show();
            Hide();
        }

        private void btnPass_Click(object sender, EventArgs e)
        {
            PassTurn();
            if (currentSession.IsThereAI() && currentSession.GetCurrentGame().WhosTurn() == 1)
            {
                string botTurn = "Ok now it's my turn";
                MessageBox.Show(botTurn);
                AITurn();
            }
        }

        private void btnRoll_Click(object sender, EventArgs e)
        {
            DiceRoll();
            if (currentSession.IsThereAI() && currentSession.GetCurrentGame().WhosTurn() == 1)
            {
                MakePlayerTurn();
                string botTurn = "Ok now it's my turn";
                MessageBox.Show(botTurn);
                AITurn();
            }
        }

        private void AITurn()
        {
            // Add some talking parts here or something....
            btnRoll.Visible = false;
            btnPass.Visible = false;
            System.Threading.Thread.Sleep(3000);
            DiceRoll();
            if (Convert.ToInt32(txtbxRunningScore.Text) < 6)
            {
                DiceRoll();
            }
            else
            {
                PassTurn();
            }

        }

        private void AIBrain()
        {

        }

        private void PassTurn()
        {
            int grabbedRunningScore = currentSession.GetCurrentGame().GetRunningScore();
            currentSession.GetCurrentGame().GetPlayers()[currentSession.GetCurrentGame().WhosTurn()].setScore(grabbedRunningScore);
            txtbxRunningScore.Text = "Turn Passed";
            if (currentSession.GetCurrentGame().WhosTurn() == 0)
            {
                txtbxPlayer1Score.Text += "\r\n" + Convert.ToString(grabbedRunningScore);
            }
            else
            {
                txtbxPlayer2Score.Text += "\r\n" + Convert.ToString(grabbedRunningScore);
            }
            currentSession.GetCurrentGame().SwitchPlayers();
            MakePlayerTurn();
        }

        private void DiceRoll()
        {
            btnRoll.Visible = false;
            btnPass.Visible = false;
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
            txtbxRunningScore.Text = "0";
            CheckDice(roll1, roll2);
            if (currentSession.HasGameEnded())
            {
                UpdateWins();
                btnRoll.Visible = false;
                btnPass.Visible = false;
                btnQuit.Visible = true;
                btnNewGame.Visible = true;
            }
            else
            {
                if (currentSession.GetCurrentGame().WhosTurn() == 1 && currentSession.IsThereAI() == true)
                {
                    AITurn();
                }
                btnRoll.Visible = true;
                btnPass.Visible = true;
            }
            MakePlayerTurn();
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
            int currentScore = currentSession.GetCurrentGame().GetPlayers()[currentSession.GetCurrentGame().WhosTurn()].getScore(), runningscore = 0;
            if (result1 == 1 && result2 == 1)
            {
                // if player rolls two 1's
                currentSession.GetCurrentGame().GetPlayers()[currentSession.GetCurrentGame().WhosTurn()].setScore(runningscore);
                txtbxRunningScore.Text = "Snake Eyes!";
                PassTurn();
            }
            else if (result1 == 1 || result2 == 1)
            {
                // if player rolls one 1
                txtbxRunningScore.Text = "0";
                PassTurn();
            }
            else
            {
                // if player rolls zero 1's
                runningscore = currentScore + result1 + result2;
                txtbxRunningScore.Text = Convert.ToString(runningscore);
                currentScore = Convert.ToInt32(txtbxRunningScore.Text);
                currentSession.GetCurrentGame().GetPlayers()[currentSession.GetCurrentGame().WhosTurn()].setScore(runningscore);
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

        private void UpdateWins()
        {
            txtbxPlayer1Score.Text = "Total Wins: " + currentSession.GetPlayerOneWins() + "\n\nTest";
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
