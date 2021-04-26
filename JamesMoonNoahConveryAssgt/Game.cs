using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JamesMoonNoahConveryAssgt
{
    class Game
    {
        private Player[] numOfPlayers = new Player[2];
        private Dice diceStats;
        private int intGoal, intTurn;
        private bool boolEnd, boolCurrentPlayerWins;
        private Random rand = new Random();

        public Game(Player playerOne, Player playerTwo, int finalGoal)
        {
            int intWhosTurn = rand.Next(0, 1);
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

        // public string CountScore() { }

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
