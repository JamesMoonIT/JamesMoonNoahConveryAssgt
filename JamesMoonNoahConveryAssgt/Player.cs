/*
    Name: James Moon & Noah Convery
    Date: 12/5/21
    Description: Class that contains player name and score.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JamesMoonNoahConveryAssgt
{
    public class Player                                             // Player class that stores and retrieves player name and score
    {
        private string strName;
        private int intScore;

        public Player(string newPlayerName)                         // Constructor that stores player name and score. 
        {
            strName = newPlayerName;                                // Takes and stores a player name
            intScore = 0;                                           // Stores player score for later reference
        }

        public string GetName()                                     // Returns the player name
        {
            return strName;
        }

        public int GetScore()                                       // Returns the player score
        {
            return intScore;
        }

        public void SetScore(int newScore)                          // Stores the player score
        {
            intScore = newScore;
        }
    }
}
