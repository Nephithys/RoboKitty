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
        public int enemies = 1;
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
            Console.WriteLine("sprint to destination");
        }

        
        
        public void attack()
        {
            if (enemies >= 8)
            {
                Console.WriteLine("Protect human and eleminate all threats");

            }
            else
            {
                Console.WriteLine("meow profusely");
                System.Media.SoundPlayer player = new System.Media.SoundPlayer("Kittens_And_Cats_Meowing.wav");
                player.Play();
                Console.ReadLine();
            }


          
        }

    }
}
