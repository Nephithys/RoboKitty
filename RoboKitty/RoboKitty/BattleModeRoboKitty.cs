using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoboKitty
{
    public class BattleModeRoboKitty : RoboSkeleton
    {
        public int numOfGuns;
        public string Name;
        public int enemies = 56;
        public BattleModeRoboKitty(int legs, int head, int tail, int guns, string name)
        {
            numOfLegs = legs;
            numOfHeads = head;
            numOfTails = tail;
            numOfGuns = guns;
            Name = name;

        }

        public override void walk()
        {
            Console.WriteLine("sprint to enemies");
        }

        public void attack()
        {
            if (enemies >= 1)
            {
                Console.WriteLine("Protect human and eleminate all threats");

            }
            else
            {
                Console.WriteLine();
            }


          
        }

    }
}
