/*
    Name: James Moon & Noah Convery
    Date: 12/05/21
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


        public frmGroanGame(Session currentGame)                                                                // incroporates a new session with every form
        {
            InitializeComponent();
            firstDice = picbxDice1.CreateGraphics();
            secondDice = picbxDice2.CreateGraphics();
            rand = new Random();
            currentSession = currentGame;
            lblPlayer1Name.Text = currentSession.GetCurrentGame().GetPlayers()[0].GetName();                    // gets the name of player 1
            lblPlayer2Name.Text = currentSession.GetCurrentGame().GetPlayers()[1].GetName();                    // gets the name of player 2
            lblTurnIndicator.Text = "It is " + currentSession.GetCurrentGame().GetPlayers()[currentSession.GetCurrentGame().WhosTurn()].GetName() + "'s turn!";
            lblGoal.Text = "Goal: First to " + currentSession.GetCurrentGame().GetGoal() + " wins!";            // ^ Created top label with player name
            MakePlayerTurn();                                                           // ^ Grabs game score
            btnNewGame.Visible = false;                                                                         // Hides the new game button
            Application.DoEvents();
        }

        private void btnRules_Click(object sender, EventArgs e)                                                 // Button that opens the rules page
        {
            GroanRules.Show();                                                                                  // brings up the Rules window
        }

        private void btnNewGame_Click(object sender, EventArgs e)                                               //Button that starts a new game only shown after the current game has finished
        {
            currentSession.Restart(currentSession.GetCurrentGame().GetGoal());                                  // Creates a new game in the session
            txtbxPlayer1Score.Text = "Cumulative Score:";                                                       // Reset's cumulative score box for player 1
            currentSession.GetCurrentGame().GetPlayers()[0].SetScore(0);                                        // Updates player 1's score
            txtbxPlayer2Score.Text = "Cumulative Score:";                                                       // Reset's cumulative score box for player 2
            currentSession.GetCurrentGame().GetPlayers()[1].SetScore(0);                                        // Updates player 2's score
            if (currentSession.IsThereAI() && currentSession.GetCurrentGame().WhosTurn() == 1)                  // Checks who is starting
            {
                AIStart();                                                                                      // AI starts the game
            }
            MakePlayerTurn();                                                                                   // Creates the look of the players turn (failsafe)
            txtbxRunningScore.Text = "0";                                                                       // Running Score set to 0
            btnNewGame.Visible = false;                                                                         // Hides new game button
            btnRoll.Visible = true;                                                                             // Shows Roll button
            btnPass.Visible = true;                                                                             // Shows Pass button
            EnableButtons();                                                                                    // Re-enables all buttons on screen
        }

        private void btnQuit_Click(object sender, EventArgs e)                                                  // button that closes the game and returns you to the home menu
        {
            this.Close();                                                                                       // Closes GroanGame
            GroanHome.Show();                                                                                   // Shows GroanHome
        }

        private void btnPass_Click(object sender, EventArgs e)                                                  //Button that passes the players turn and swaps to the other player
        {
            PassTurn();                                                                                         // passes the current players turn
            if (currentSession.IsThereAI() && currentSession.GetCurrentGame().WhosTurn() == 1)                  // checks if its player 2's turn and if there is an ai
            {
                AIStart();                                                                                      // ai starts their turn
            }
            EnableButtons();                                                                                    // enables all buttons
        }

        public void AIStart()                                                                                   //Start of the AI turn 
        {
            DisableButtons();                                                                                   // disables all buttons
            string botTurn = "Ok now it's my turn";
            MessageBox.Show(botTurn);                                                                           // shows a message box with ai's text
            AITurn();                                                                                           // ai plays their turn
            EnableButtons();                                                                                    // enables all game buttons
        }

        private void btnRoll_Click(object sender, EventArgs e)                                                  //Button that rolls the dice 
        {
            DisableButtons();                                                                                   // disables all buttons
            DiceRoll();                                                                                         // starts rolling the dice
            if (currentSession.GetCurrentGame().IsGameOver() == false)                                          // checks if game is over
            {
                if (currentSession.IsThereAI() && currentSession.GetCurrentGame().WhosTurn() == 1)              // checks if its player two's turn and if there is an ai
                {
                    AIStart();                                                                                  // ai starts its turn
                }
            }
            EnableButtons();                                                                                    // re-enables all buttons
        }

        public void AITurn()                                                                                    //Method that starts the AI turn
        {
            if (currentSession.GetCurrentGame().WhosTurn() == 1)                                                // if its the ai's turn (in place incase its player 2's turn and there is no ai)
            {
                System.Threading.Thread.Sleep(2000);                                                            // pause for 2 seconds
                DiceRoll();                                                                                     // performs a dice roll
                if (!currentSession.HasGameEnded())                                                             // checks if the game has ended
                {
                    AIBrain();                                                                                  // runs ai logic
                }
            }
        }

        private void AIBrain()                                                                                  //Method that contains the logic behind the AI's turn
        {
            if (currentSession.GetCurrentGame().GetRunningScore() < 11)                                         // checks the ai's running score for their turn if they had scored under 11
            {
                AITurn();                                                                                       // the ai will have their turn again
            }
            else                                                                                                // if the ai's running score is more than 11
            {
                PassTurn();                                                                                     // ai passes their turn
            }
        }

        private void PassTurn()                                                                                 //Method that passes turn between players
        {
            int grabbedRunningScore = currentSession.GetCurrentGame().GetRunningScore();                                                                // grabs the game's current running score
            int playerscore = currentSession.GetCurrentGame().GetPlayers()[currentSession.GetCurrentGame().WhosTurn()].GetScore();                      // grabs the current players score
            currentSession.GetCurrentGame().GetPlayers()[currentSession.GetCurrentGame().WhosTurn()].SetScore(grabbedRunningScore + playerscore);       // adds the running score to the current players score
            currentSession.GetCurrentGame().SetRunningScore(0);                                                                                         // resets the game's running score to 0
            txtbxRunningScore.Text = "Turn Passed";                                                                                                     // Sets the running score text to Turn Passed
            if (currentSession.GetCurrentGame().WhosTurn() == 0)                                                                                        // Checks if its player 1's turn
            {
                if (grabbedRunningScore == 0 && playerscore == 0)                                                                                       // if the player rolled snake eyes
                {
                    txtbxPlayer1Score.Text = "Cumulative Score: \r\n" + 0;                                                                              // resets cumulative score textbox to 0

                }
                else                                                                                                                                    // if player has active running score or player score
                {
                    txtbxPlayer1Score.Text += "\r\n" + Convert.ToString(grabbedRunningScore + playerscore);                                             // adds new score to cumulative score
                }
            }
            else                                                                                                                                        // Checks if its player 1's turn
            {
                if (grabbedRunningScore == 0 && playerscore == 0)                                                                                       // if the player rolled snake eyes
                {
                    txtbxPlayer2Score.Text = "Cumulative Score: \r\n" + 0;                                                                              // resets cumulative score textbox to 0
                }
                else                                                                                                                                    // if player has active running score or player score
                {
                    txtbxPlayer2Score.Text += "\r\n" + Convert.ToString(grabbedRunningScore + playerscore);                                             // adds new score to cumulative score
                }
            }
            currentSession.GetCurrentGame().SwitchPlayers();                                                                                            // switches players
            txtbxRunningScore.Text = Convert.ToString(currentSession.GetCurrentGame().GetPlayers()[currentSession.GetCurrentGame().WhosTurn()].GetScore());     // updates running score with current player's score
            MakePlayerTurn();                                                                                                                           // generates player turn visuals
        }

        private void DiceRoll()                                                                                 // Method that simulates a dice roll
        {
            DisableButtons();                                                                                   // disables all buttons
            ClearDice();                                                                                        // clears the dice so its not showing any faces
            int roll1 = 0, roll2 = 0;                                                                           
            for (int iteration = 0; iteration < 10; iteration++)                                                // loops grenerating dice
            {
                roll1 = rand.Next(1, 7);                                                                        // generates a random number for the first dice
                roll2 = rand.Next(1, 7);                                                                        // generates a random number for the second dice
                DisplayDice(roll1, 1);                                                                          // displays dice 1
                DisplayDice(roll2, 2);                                                                          // displays dice 2
                System.Threading.Thread.Sleep(100);                                                             // tiny delay between dice so you can see it changing
            }
            CheckDice(roll1, roll2);                                                                            // checks the rules for dice roll
            if (currentSession.HasGameEnded())                                                                  // checks if game has ended
            {
                UpdateWins();                                                                                   // updates the wins of the current player
                currentSession.GetCurrentGame().GameIsOver();                                                   // updates the game so it has ended
                btnRoll.Visible = false;                                                                        // hide the roll button
                btnPass.Visible = false;                                                                        // hide the pass button
                btnQuit.Enabled = true;                                                                         // re-enable the quit button
                btnRules.Enabled = true;                                                                        // re-enables the rules button
                btnNewGame.Visible = true;                                                                      // shows the new game button
            }
        }

        private void MakePlayerTurn()                                                                           //Method that changes the turn indicator based on which players turn it is
        {
            lblTurnIndicator.Text = "It is " + currentSession.GetCurrentGame().GetPlayers()[currentSession.GetCurrentGame().WhosTurn()].GetName() + "'s turn!";
            if (currentSession.GetCurrentGame().WhosTurn() == 0)                                                // checks if its player 1's turn
            {
                picbxTurnIndicator.BackColor = Color.FromArgb(69,00,81);                                        // changes background color of TurnIndicator picturebox
            }
            else                                                                                                // checks if its player 2's turn
            {
                picbxTurnIndicator.BackColor = Color.DarkCyan;                                                  // changes background color of TurnIndicator picturebox
            }
        }

        private void CheckDice(int result1, int result2)                                                        //Method that Checks the numbers that have been rolled for any ones and applies the consequences for doing so
        {
            int runningscore = currentSession.GetCurrentGame().GetRunningScore();                               // grabs running score
            int currentscore = currentSession.GetCurrentGame().GetPlayers()[currentSession.GetCurrentGame().WhosTurn()].GetScore();         // grabs player score
            if (result1 == 1 && result2 == 1)                                                                   // if player rolls two 1's
            {
                runningscore = 0;                                                                               // sets running score to 0
                currentSession.GetCurrentGame().GetPlayers()[currentSession.GetCurrentGame().WhosTurn()].SetScore(runningscore);            // resets the player score to 0
                txtbxRunningScore.Text = Convert.ToString(runningscore + currentscore);                         // updates running score textbox
                PassTurn();                                                                                     // passes the current player's turn
            }
            else if (result1 == 1 || result2 == 1)                                                              // if player rolls one 1
            {
                runningscore = 0;                                                                               // sets runnign score to 0
                currentSession.GetCurrentGame().SetRunningScore(runningscore);                                  // updates game running score
                txtbxRunningScore.Text = Convert.ToString(runningscore + currentscore);                         // 
                PassTurn();
            }
            else                                                                                                // if player rolls zero 1's
            {
                runningscore += result1 + result2;
                currentSession.GetCurrentGame().SetRunningScore(runningscore);
                txtbxRunningScore.Text = Convert.ToString(runningscore + currentscore);
            }
        }

        private void DisplayDice(int diceNum, int dice)                                                         //Method that displays the dice based on the number rolled
        {
            if (diceNum == 1)                                                                                   // if the player rolls a 1
            {
                CreateDiceFaceOne(dice);                                                                        // generate dice face one
            }
            else if (diceNum == 2)                                                                              // if the player rolls a 2
            {
                CreateDiceFaceTwo(dice);                                                                        // generate dice face one
            }
            else if (diceNum == 3)                                                                              // if the player rolls a 3
            {
                CreateDiceFaceThree(dice);                                                                      // generate dice face one
            }
            else if (diceNum == 4)                                                                              // if the player rolls a 4
            {
                CreateDiceFaceFour(dice);                                                                       // generate dice face one
            }
            else if (diceNum == 5)                                                                              // if the player rolls a 5
            {
                CreateDiceFaceFive(dice);                                                                       // generate dice face one
            }
            else                                                                                                // if the player rolls a 6
            {
                CreateDiceFaceSix(dice);                                                                        // generate dice face one
            }
        }

        private void ClearDice()                                                                                //Method that clears the dice face 
        {
            firstDice.Clear(Color.White);                                                                       // clears dice 1
            secondDice.Clear(Color.White);                                                                      // clears dice 2
        }

        private void DisableButtons()                                                                           //Method that disables the buttons mainly used so the player cannot press them during the bots turn
        {
            btnRoll.Enabled = false;                                                                            // disables roll
            btnPass.Enabled = false;                                                                            // disables pass
            btnRules.Enabled = false;                                                                           // disables rules
            btnQuit.Enabled = false;                                                                            // disables quit
        }

        private void EnableButtons()                                                                            //Method that enables the buttons
        {
            btnRoll.Enabled = true;                                                                             // enables roll
            btnPass.Enabled = true;                                                                             // enables pass
            btnRules.Enabled = true;                                                                            // enables rules
            btnQuit.Enabled = true;                                                                             // enables quit
        }

        private void UpdateWins()                                                                               //Method that updates the wins 
        {
            if (currentSession.GetCurrentGame().WhosTurn() == 0)                                                // if its player 1's turn
            {
                lblP1Wins.Text = "Wins: " + Convert.ToString(currentSession.GetPlayerOneWins());                // update player 1 wins textbox
            }
            else                                                                                                // if its player 2's turn
            {
                lblP2Wins.Text = "Wins: " + Convert.ToString(currentSession.GetPlayerTwoWins());                // update player 2 wins textbox
            }
        }

        private void CreateDiceFaceOne(int diceNumber)                                                          //Creates the dice face for the number 1
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

        private void CreateDiceFaceTwo(int diceNumber)                                                          //Creates the dice face for the number 2
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

        private void CreateDiceFaceThree(int diceNumber)                                                        //Creates the dice face for the number 3
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

        private void CreateDiceFaceFour(int diceNumber)                                                         //Creates the dice face for the number 4
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

        private void CreateDiceFaceFive(int diceNumber)                                                         //Creates the dice face for the number 5
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

        private void CreateDiceFaceSix(int diceNumber)                                                          //Creates the dice face for the number 6
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
