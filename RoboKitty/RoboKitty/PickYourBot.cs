using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoboKitty
{
    public class PickYourBot
    {
        public void ChooseBot()
        {
            Console.WriteLine("Choose your bot, enter:");
            Console.WriteLine(" '1' for Robotcat");
            Console.WriteLine("or");
            Console.WriteLine(" '2' for BattleModeRoboKitty ");
            string userInput = Console.ReadLine();

            switch (userInput)
            {
                case "1":
                    Console.Clear();
                    RobotCat myRoboCat = new RobotCat(4, 1, 1, true);
                    myRoboCat.scan();
                    myRoboCat.walk();
                    myRoboCat.knockOverGlass();
                    break;

                case "2":
                    Console.Clear();
                    BattleModeRoboKitty myBattleModeRoboKitty = new BattleModeRoboKitty(4, 1, 1, 5, "Iroh");
                    myBattleModeRoboKitty.walk();
                    myBattleModeRoboKitty.attack();
                    break;

                default:
                    Console.Clear();
                    Console.WriteLine("Not a valid Robot");
                    break;
            }
        }
    }
}
