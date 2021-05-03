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
            int intWhosTurn = rand.Next(0, 2);
            intGoal = finalGoal;
            boolEnd = false;
            diceStats = new Dice();
            numOfPlayers[0] = playerOne;
            numOfPlayers[1] = playerTwo;

            if (intWhosTurn == 0)
            {
                intTurn = 0;
            }
            else
            {
                intTurn = 1;
            }
        }

        public int GetRunningScore()
        {
            return intRunning;
        }

        public string CountScore(int[] intResult)
        {
            int result = 0;
            diceStats = new Dice();
            for (int i = 0; i < intResult.Length; i++)
            {
                switch (intResult[i])
                {
                    case 1: diceStats.Increase(1); break;
                    case 2: diceStats.Increase(2); break;
                    case 3: diceStats.Increase(3); break;
                    case 4: diceStats.Increase(4); break;
                    case 5: diceStats.Increase(5); break;
                    case 6: diceStats.Increase(6); break;
                }
                result += intResult[i];
            }
            return GroanRules(result);
        }

        public string GroanRules(int score)
        {
            string message = "";
            if (diceStats.GetOne() >= 1)
            {
                switch (diceStats.GetOne())
                {
                    case 1: message = RuleOne(); break;
                    case 2: message = RuleTwo(); break;
                }
            }
            return message;
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

        private string RuleOne()
        {
            return ""; // fill later
        }

        private string RuleTwo()
        {
            return ""; // fill later
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
