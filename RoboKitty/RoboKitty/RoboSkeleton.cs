using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoboKitty
{
    public class RoboSkeleton
    {
        public int numOfLegs;
        public int numOfHeads;
        public int numOfTails;

        

        public virtual void walk()
        {
            Console.WriteLine("limp towards destination");
        }

        
    }
}
