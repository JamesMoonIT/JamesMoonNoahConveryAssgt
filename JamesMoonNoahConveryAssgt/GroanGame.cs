/*
    Name: James Moon & Noah Convery
    Date 12/05/21
    Description: This is the game page where players will play the game it contains the controls as buttons and updates the both scores and player turn labels.
    It also contains the method that creates the dice faces.
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
            lblPlayer1Name.Text = currentSession.GetCurrentGame().GetPlayers()[0].GetName();
            lblPlayer2Name.Text = currentSession.GetCurrentGame().GetPlayers()[1].GetName();
            lblTurnIndicator.Text = "It is " + currentSession.GetCurrentGame().GetPlayers()[currentSession.GetCurrentGame().WhosTurn()].GetName() + "'s turn!";
            lblGoal.Text = "Goal: First to " + currentSession.GetCurrentGame().GetGoal() + " wins!";
            MakePlayerTurn();
            btnNewGame.Visible = false;
            Application.DoEvents();
        }

        private void btnRules_Click(object sender, EventArgs e) // Button that opens the rules page
        {
            GroanRules.Show();
        }

        private void btnNewGame_Click(object sender, EventArgs e) //Button that starts a new game only shown after the current game has finished
        {
            currentSession.Restart(currentSession.GetCurrentGame().GetGoal());
            txtbxPlayer1Score.Text = "Cumulative Score:";
            currentSession.GetCurrentGame().GetPlayers()[0].SetScore(0);
            txtbxPlayer2Score.Text = "Cumulative Score:";
            currentSession.GetCurrentGame().GetPlayers()[1].SetScore(0);
            if (currentSession.IsThereAI() && currentSession.GetCurrentGame().WhosTurn() == 1)
            {
                AIStart();
            }
            MakePlayerTurn();
            txtbxRunningScore.Text = "0";
            btnNewGame.Visible = false;
            btnRoll.Visible = true;
            btnPass.Visible = true;
            EnableButtons();
        }

        private void btnQuit_Click(object sender, EventArgs e) // button that closes the game and returns you to the home menu
        {
            this.Close();
            GroanHome.Show();
        }

        private void btnPass_Click(object sender, EventArgs e) //Button that passes the players turn and swaps to the other player
        {
            PassTurn();
            if (currentSession.IsThereAI() && currentSession.GetCurrentGame().WhosTurn() == 1)
            {
                AIStart();
            }
            EnableButtons();
        }

        public void AIStart() //Start of the AI turn 
        {
            DisableButtons();
            string botTurn = "Ok now it's my turn";
            MessageBox.Show(botTurn);
            AITurn();
            EnableButtons();
        }

        private void btnRoll_Click(object sender, EventArgs e) //Button that rolls the dice 
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

        public void AITurn() //Method that starts the AI turn
        {
            if (currentSession.GetCurrentGame().WhosTurn() == 1)
            {
                System.Threading.Thread.Sleep(2000);
                DiceRoll();
                if (!currentSession.HasGameEnded())
                {
                    AIBrain();
                }
            }
        }

        private void AIBrain() //Method that contains the logic behind the AI's turn
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

        private void PassTurn() //Method that passes turn between players
        {
            int grabbedRunningScore = currentSession.GetCurrentGame().GetRunningScore(), playerscore = currentSession.GetCurrentGame().GetPlayers()[currentSession.GetCurrentGame().WhosTurn()].GetScore();
            currentSession.GetCurrentGame().GetPlayers()[currentSession.GetCurrentGame().WhosTurn()].SetScore(grabbedRunningScore + playerscore);
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
            txtbxRunningScore.Text = Convert.ToString(currentSession.GetCurrentGame().GetPlayers()[currentSession.GetCurrentGame().WhosTurn()].GetScore());
            MakePlayerTurn();
        }

        private void DiceRoll() //Method that simulates a dice roll
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

        private void MakePlayerTurn() //Method that changes the turn indicator based on which players turn it is
        {
            lblTurnIndicator.Text = "It is " + currentSession.GetCurrentGame().GetPlayers()[currentSession.GetCurrentGame().WhosTurn()].GetName() + "'s turn!";
            if (currentSession.GetCurrentGame().WhosTurn() == 0)
            {
                picbxTurnIndicator.BackColor = Color.FromArgb(69,00,81);
            }
            else
            {
                picbxTurnIndicator.BackColor = Color.DarkCyan;
            }
        }

        private void CheckDice(int result1, int result2) //Method that Checks the numbers that have been rolled for any ones and applies the consequences for doing so
        {
            int runningscore = currentSession.GetCurrentGame().GetRunningScore(), currentscore = currentSession.GetCurrentGame().GetPlayers()[currentSession.GetCurrentGame().WhosTurn()].GetScore();
            if (result1 == 1 && result2 == 1)
            {
                // if player rolls two 1's
                runningscore = 0;
                currentSession.GetCurrentGame().GetPlayers()[currentSession.GetCurrentGame().WhosTurn()].SetScore(runningscore);
                txtbxRunningScore.Text = Convert.ToString(runningscore + currentscore);
                PassTurn();
            }
            else if (result1 == 1 || result2 == 1)
            {
                // if player rolls one 1
                runningscore = 0;
                currentSession.GetCurrentGame().SetRunningScore(runningscore);
                txtbxRunningScore.Text = Convert.ToString(runningscore + currentscore);
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

        private void DisplayDice(int diceNum, int dice) //Method that displays the dice based on the number rolled
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

        private void ClearDice() //Method that clears the dice face 
        {
            firstDice.Clear(Color.White);
            secondDice.Clear(Color.White);
        }

        private void DisableButtons() //Method that disables the buttons mainly used so the player cannot press them during the bots turn
        {
            btnRoll.Enabled = false;
            btnPass.Enabled = false;
            btnRules.Enabled = false;
            btnQuit.Enabled = false;
        }

        private void EnableButtons() //Method that enables the buttons
        {
            btnRoll.Enabled = true;
            btnPass.Enabled = true;
            btnRules.Enabled = true;
            btnQuit.Enabled = true;
        }

        private void UpdateWins() //Method that updates the wins 
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

        private void CreateDiceFaceOne(int diceNumber) //Creates the dice face for the number 1
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

        private void CreateDiceFaceTwo(int diceNumber) //Creates the dice face for the number 2
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

        private void CreateDiceFaceThree(int diceNumber) //Creates the dice face for the number 3
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

        private void CreateDiceFaceFour(int diceNumber) //Creates the dice face for the number 4
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

        private void CreateDiceFaceFive(int diceNumber) //Creates the dice face for the number 5
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

        private void CreateDiceFaceSix(int diceNumber) //Creates the dice face for the number 6
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
