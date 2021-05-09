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

        public Game(Player playerOne, Player playerTwo, int finalGoal)
        {
            intTurn = rand.Next(0, 2);
            gameover = false;
            intGoal = finalGoal;
            numOfPlayers[0] = playerOne;
            numOfPlayers[1] = playerTwo;
        }

        public void GameIsOver()
        {
            gameover = true;
        }

        public bool IsGameOver()
        {
            return gameover;
        }

        public void SetRunningScore(int score)
        {
            intRunning = score;
        }

        public int GetRunningScore()
        {
            return intRunning;
        }

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

        public Player[] GetPlayers()
        {
            return numOfPlayers;
        }

        public int GetGoal()
        {
            return intGoal;
        }

        public int WhosTurn()
        {
            return intTurn;
        }
    }
}
