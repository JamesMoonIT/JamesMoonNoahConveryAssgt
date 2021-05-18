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
    // Game help with communicating between session, game and player. It's main purpose is keepign track of game conditions and storing and retrieving player data.
    // Game.cs is inspired by James's own code from INFT2012 in 2020 on Github here: https://github.com/KarlKFoley/Inft2012-SixOfOne/blob/master/KarlFoleyJamesMoon/KarlFoleyJamesMoon/Game.cs
    // The reuse of some logic was for the benefit of keeping track of data in different constructors rather than reseting the entire form. This is to avoid having any issues with overloading or overwritten data that may mess with code.
    public class Game
    {
        private Player[] numOfPlayers = new Player[2];
        private int intGoal, intTurn, intRunning;
        private bool gameover;
        private Random rand = new Random();

        // Game contructor called when a new game is created in GroanGame.
        public Game(Player playerOne, Player playerTwo, int finalGoal)
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

        // sets game over to ended
        public void GameIsOver()
        {
            gameover = true;
        }

        // checks if game has ended
        public bool IsGameOver()
        {
            return gameover;
        }

        // stores running score
        public void SetRunningScore(int score)
        {
            intRunning = score;
        }

        // returns game running score
        public int GetRunningScore()
        {
            return intRunning;
        }

        // switches players
        public void SwitchPlayers()
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

        // returns player
        public Player[] GetPlayers()
        {
            return numOfPlayers;
        }

        // returns game's goal
        public int GetGoal()
        {
            return intGoal;
        }

        // returns who's turn it is
        public int WhosTurn()
        {
            return intTurn;
        }
    }
}
