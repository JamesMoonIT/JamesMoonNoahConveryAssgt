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
            Show();
            MakePlayerTurn();
            btnNewGame.Visible = false;
            if (currentGame.IsThereAI() == true)
            {
                AITurn();
            }
            //txtbxRunningScore.Text = currentSession.GetCurrentGame().get
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
            int grabbedRunningScore = currentSession.GetCurrentGame().GetRunningScore();
            currentSession.GetCurrentGame().SwitchPlayers();
            if(currentSession.GetCurrentGame().WhosTurn() == 0)
            {
                picbxTurnIndicator.BackColor = Color.Red;
                lblTurnIndicator.Text = "It is " + currentSession.GetCurrentGame().GetPlayers()[currentSession.GetCurrentGame().WhosTurn()].getName() + "'s turn!";
                txtbxRunningScore.Text = txtbxPlayer1Score.Text;
            }
            if(currentSession.GetCurrentGame().WhosTurn() == 1)
            {
                if (currentSession.IsThereAI() == true)
                {
                    btnRoll.Visible = false;
                    btnPass.Visible = false;
                    AITurn();
                }
                picbxTurnIndicator.BackColor = Color.Green;
                lblTurnIndicator.Text = "It is " + currentSession.GetCurrentGame().GetPlayers()[currentSession.GetCurrentGame().WhosTurn()].getName() + "'s turn!";
                txtbxRunningScore.Text = txtbxPlayer2Score.Text;
            }
            
        }

        private void btnRoll_Click(object sender, EventArgs e)
        {
            btnRoll.Visible = false;
            btnPass.Visible = false;
            DiceRoll();
            btnRoll.Visible = true;
            btnPass.Visible = true;
        }

        private void AITurn()
        {
            // Add some talking parts here or something....
            System.Threading.Thread.Sleep(3000);
            DiceRoll(); 
        }

        private void DiceRoll()
        {
            ClearDice();
            int roll1 = 0, roll2 = 0, result1, result2;
            for (int iteration = 0; iteration < 10; iteration++)
            {
                roll1 = rand.Next(1, 7);
                roll2 = rand.Next(1, 7);
                DisplayDice(roll1, 1);
                DisplayDice(roll2, 2);
                System.Threading.Thread.Sleep(100);
            }
            result1 = roll1;
            result2 = roll2;
            CheckDice(result1, result2);
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
                currentSession.GetCurrentGame().SwitchPlayers();
                if (currentSession.GetCurrentGame().WhosTurn() == 1)
                {
                    if (currentSession.IsThereAI() == true)
                    {
                        btnRoll.Visible = false;
                        btnPass.Visible = false;
                        AITurn();
                    }
                }
                btnRoll.Visible = true;
                btnPass.Visible = true;
            }
        }

        private void MakePlayerTurn()
        {
            if (currentSession.GetCurrentGame().WhosTurn() == 0)
            {
                picbxTurnIndicator.BackColor = Color.Red;
            }
            else
            {
                picbxTurnIndicator.BackColor = Color.Green;
                AITurn();
            }
        }

        private void CheckDice(int result1, int result2)
        {
            if (result1 == 1 || result2 == 1)
            {
                // if player rolls one 1

                txtbxRunningScore.Text = "Turn Passed";
                currentSession.GetCurrentGame().SwitchPlayers();
            }
            else if (result1 == 1 && result2 == 1)
            {
                // if player rolls two 1's
                txtbxRunningScore.Text = "Snake Eyes!";
            }
            else
            {
                // if player rolls zero 1's
                txtbxRunningScore.Text = Convert.ToString(result1 + result2);
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
