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

        public int getOne()
        {
            return intFaceOne;
        }

        public int getTwo()
        {
            return intFaceTwo;
        }

        public int getThree()
        {
            return intFaceThree;
        }

        public int getFour()
        {
            return intFaceFour;
        }

        public int getFive()
        {
            return intFaceFive;
        }

        public int getSix()
        {
            return intFaceSix;
        }

        public void increse(int roll)
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
