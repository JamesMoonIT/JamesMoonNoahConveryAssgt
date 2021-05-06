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
        private Dice diceStats;
        private int intGoal, intTurn, intRunning;
        private bool boolEnd, boolCurrentPlayerWins;
        private Random rand = new Random();

        public Game(Player playerOne, Player playerTwo, int finalGoal)
        {
            intGoal = finalGoal;
            boolEnd = false;
            diceStats = new Dice();
            numOfPlayers[0] = playerOne;
            numOfPlayers[1] = playerTwo;
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

        public string GoalReached()
        {
            if (numOfPlayers[intTurn].getScore() >= intGoal)
            {
                boolCurrentPlayerWins = true;
                End();
            }
            return "";
        }

        public void End()
        {
            boolEnd = true;
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

        public bool GameOver()
        {
            return boolEnd;
        }

        public bool CurrentPlayerWins()
        {
            return boolCurrentPlayerWins;
        }


    }
}
