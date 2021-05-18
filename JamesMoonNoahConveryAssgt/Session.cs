/* 
    Name: James Moon & Noah Convery
    Date: 12/5/2021
    Description: This class stores the session data given through GroanGame for later reference in the program, as well as
                    extra methods for modifiying and creating session data.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JamesMoonNoahConveryAssgt
{
    public class Session
    {
        private Player playerOne, playerTwo;
        private Game gameCurrent;
        private int intPlayerOne, intPlayerTwo;
        private bool boolAi;

        // Creates a session with player data and game data
        public Session(string strP1Name, string strP2Name, int intScore, bool ai)               
        {
            boolAi = ai;                                                                        // Set to true if an ai is present, false if otherwise
            intPlayerOne = 0;                                                                   // Total number of wins for player one
            intPlayerTwo = 0;                                                                   // Total number of wins for player two
            playerOne = new Player(strP1Name);                                                  // Creates a new player with player one name
            playerTwo = new Player(strP2Name);                                                  // Creates a new player with player two name
            gameCurrent = new Game(playerOne, playerTwo, intScore);                             // Creates a new game with player one and two's name, and score
        }

        // Creates a new game with player names and current score
        public void Restart(int iScore)                                                         
        {
            gameCurrent = new Game(playerOne, playerTwo, iScore);                               // Calls new game class with variables
        }

        // checks and updates the game if the score has been reached
        public bool HasGameEnded()                                                              
        {
            int score = gameCurrent.GetGoal();
            if ((GetCurrentGame().GetPlayers()[GetCurrentGame().WhosTurn()].GetScore() + GetCurrentGame().GetRunningScore()) >= score)
            {                                                                                   // ^ Checks the current players score and cumulative score if it is over the game score
                if (gameCurrent.WhosTurn() == 0)                                                // if its player one's turn
                {
                    PlayerOneWins();                                                            // increases player one wins by one
                }
                else                                                                            // if its player two's turn
                {
                    PlayerTwoWins();                                                            // increases player two wins by one
                }
                return true;                                                                    // returns that a player has won
            }
            else
            {
                return false;                                                                   // returns that a player has not won
            }
        }

        // returns current game
        public Game GetCurrentGame()                                                            
        {
            return gameCurrent;
        }

        // returns player one total wins
        public int GetPlayerOneWins()                                                           
        {
            return intPlayerOne;
        }

        // returns player two total wins
        public int GetPlayerTwoWins()                                                           
        {
            return intPlayerTwo;
        }

        // increases player one wins by 1
        public void PlayerOneWins()                                                             
        {
            intPlayerOne++;
        }

        // increases player two wins by 1
        public void PlayerTwoWins()                                                             
        {
            intPlayerTwo++;
        }

        // returns if an ai is active in the current session
        public bool IsThereAI()                                                                 
        {
            return boolAi;
        }
    }
}
