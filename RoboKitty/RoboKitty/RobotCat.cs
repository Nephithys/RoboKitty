using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoboKitty
{
    public class RobotCat : RoboSkeleton
    {
        
        bool isGlassPopulated;
        public RobotCat(int legs, int head, int tail, bool glass)
        {
            numOfLegs = legs;
            numOfHeads = head;
            numOfTails = tail;
            isGlassPopulated = glass;
        }

        public override void walk()
        {
            Console.WriteLine("trot to the destination");
        }

        public void scan()
        {
            Console.WriteLine("look for mice, ball, string, or humans shoelace");
        }

        public void knockOverGlass()
        {
            if (isGlassPopulated == true)
            {
                Console.WriteLine("knock over Humans glass");
            }
            else
            {
                Console.WriteLine("leave humans glass till it is populated");
            }
        }
    }
}
