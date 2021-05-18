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
    // Player class that stores and retrieves player name and score
    public class Player                                             
    {
        private string strName;
        private int intScore;

        // Constructor that stores player name and score. 
        public Player(string newPlayerName)                         
        {
            strName = newPlayerName;                                // Takes and stores a player name
            intScore = 0;                                           // Stores player score for later reference
        }

        // Returns the player name
        public string GetName()                                     
        {
            return strName;
        }

        // Returns the player score
        public int GetScore()                                       
        {
            return intScore;
        }

        // Stores the player score
        public void SetScore(int newScore)                          
        {
            intScore = newScore;
        }
    }
}
