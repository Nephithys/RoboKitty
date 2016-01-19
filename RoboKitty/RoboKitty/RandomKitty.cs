using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoboKitty
{
    class RandomKitty : RoboSkeleton
    {

        public RandomKitty(int legs, int head, int tail)
        {
            numOfLegs = legs;
            numOfHeads = head;
            numOfTails = tail;
        }

        public int randomInt()
        {
            Random intRand = new Random();
            int  randomNum = intRand.Next(1, 12);
            return randomNum;
        }

    }
}
