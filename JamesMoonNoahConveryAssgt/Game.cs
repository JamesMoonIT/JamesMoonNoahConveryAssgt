/*
    Name: James Moon & Noah Convery
    Date: 12/05/21
    Description: A class that contains information about the game such as the number of players, scores and turn order.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JamesMoonNoahConveryAssgt
{
    public class Game
    {
        private Player[] numOfPlayers = new Player[2];
        private int intGoal, intTurn, intRunning;
        private bool gameover;
        private Random rand = new Random();

        public Game(Player playerOne, Player playerTwo, int finalGoal)                      // Game contructor called when a new game is created in GroanGame.
        {
            int intFirstTurn = rand.Next(0, 2);                                             // creates a random integer to see who starts the game
            gameover = false;                                                               // sets the game to true if the win condition is met
            intGoal = finalGoal;                                                            // sets the score of the game
            numOfPlayers[0] = playerOne;                                                    // stores player 1 in Game class
            numOfPlayers[1] = playerTwo;                                                    // stores player 2 in Game class
            if (intFirstTurn == 0)                                                          // checks in random in is 0
            {
                intTurn = 0;                                                                // game will start with player 1
            }
            else
            {
                intTurn = 1;                                                                // game will start with player 2
            }
        }

        public void GameIsOver()                                                            // sets game over to ended
        {
            gameover = true;
        }

        public bool IsGameOver()                                                            // checks if game has ended
        {
            return gameover;
        }

        public void SetRunningScore(int score)                                              // stores running score
        {
            intRunning = score;
        }

        public int GetRunningScore()                                                        // returns game running score
        {
            return intRunning;
        }

        public void SwitchPlayers()                                                         // switches players
        {
            if (intTurn == 0)
            {
                intTurn = 1;
            }
            else
            {
                intTurn = 0;
            }
        }

        public Player[] GetPlayers()                                                        // returns player
        {
            return numOfPlayers;
        }

        public int GetGoal()                                                                // returns game's goal
        {
            return intGoal;
        }

        public int WhosTurn()                                                               // returns who's turn it is
        {
            return intTurn;
        }
    }
}
