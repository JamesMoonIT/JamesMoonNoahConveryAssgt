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

        public Session(string strP1Name, string strP2Name, int intScore, bool ai)
        {
            boolAi = ai;
            intPlayerOne = 0;
            intPlayerTwo = 0;
            playerOne = new Player(strP1Name);
            playerTwo = new Player(strP2Name);
            gameCurrent = new Game(playerOne, playerTwo, intScore);
        }

        public void restart(int iScore)
        {
            gameCurrent = new Game(playerOne, playerTwo, iScore);
        }

        public bool HasGameEnded()
        {
            if (GetCurrentGame().GetPlayers()[0].getScore() >= 50 || GetCurrentGame().GetPlayers()[1].getScore() >= 50)
            {
                if (gameCurrent.WhosTurn() == 0)
                {
                    PlayerOneWins();
                }
                else
                {
                    PlayerTwoWins();
                }
                return true;
            }
            else
            {
                return false;
            }
        }
        public Player GetPlayerOne()
        {
            return playerOne;
        }

        public Player GetPlayerTwo()
        {
            return playerTwo;
        }

        public Game GetCurrentGame()
        {
            return gameCurrent;
        }

        public int GetPlayerOneWins()
        {
            return intPlayerOne;
        }

        public int GetPlayerTwoWins()
        {
            return intPlayerTwo;
        }

        public void PlayerOneWins()
        {
            intPlayerOne++;
        }

        public void PlayerTwoWins()
        {
            intPlayerTwo++;
        }

        public bool IsThereAI()
        {
            return boolAi;
        }
    }
}
