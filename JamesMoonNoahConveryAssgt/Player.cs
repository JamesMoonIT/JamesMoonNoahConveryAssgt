using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JamesMoonNoahConveryAssgt
{
    public class Player
    {
        private string strName;
        private int intScore;

        public Player(string newPlayerName)
        {
            strName = newPlayerName;
            intScore = 0;
        }

        public string GetName()
        {
            return strName;
        }

        public int GetScore()
        {
            return intScore;
        }

        public void SetScore(int newScore)
        {
            intScore = newScore;
        }
    }
}
