using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JamesMoonNoahConveryAssgt
{
    class Dice
    {
        private int intFaceOne, intFaceTwo, intFaceThree, intFaceFour, intFaceFive, intFaceSix;
        
        public Dice()
        {
            intFaceOne = 0;
            intFaceTwo = 0;
            intFaceThree = 0;
            intFaceFour = 0;
            intFaceFive = 0;
            intFaceSix = 0;
        }

        public int GetOne()
        {
            return intFaceOne;
        }

        public int GetTwo()
        {
            return intFaceTwo;
        }

        public int GetThree()
        {
            return intFaceThree;
        }

        public int GetFour()
        {
            return intFaceFour;
        }

        public int GetFive()
        {
            return intFaceFive;
        }

        public int GetSix()
        {
            return intFaceSix;
        }

        public void Increase(int roll)
        {
            if (roll == 1)
            {
                intFaceOne++;
            }
            if (roll == 2)
            {
                intFaceTwo++;
            }
            if (roll == 3)
            {
                intFaceThree++;
            }
            if (roll == 4)
            {
                intFaceFour++;
            }
            if (roll == 5)
            {
                intFaceFive++;
            }
            if (roll == 6)
            {
                intFaceFive++;
            }
        }
    }
}
