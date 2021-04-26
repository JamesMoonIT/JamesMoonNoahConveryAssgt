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
        private Random rnd = new Random();

        public string getName()
        {
            return strName;
        }

        public void setName(string myname)
        {
            strName = myname;
        }

        public int getScore()
        {
            return intScore;
        }

        public void setScore(int newScore)
        {
            intScore = newScore;
        }

        public Player()
        {
            strName = "";
            intScore = 0;
        }

        public Player(string newPlayerName)
        {
            strName = newPlayerName;
            intScore = 0;
        }
    }
}
