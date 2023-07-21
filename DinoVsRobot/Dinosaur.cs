using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DinoVsRobot
{
    public class Dinosaur
    {
       static public string DinoName = "Peggo the Dino";
       static public int DinoHealth = 200;
       static public int DinoAttackPower = 25;

        static public void AttackRobot()
        {
            //Checks if dino is at 0 or less then 0
            if (DinoHealth <= 0)
            {
                Console.WriteLine($"{DinoName} has reached {DinoHealth}");
                Console.WriteLine(Robot.RobotName + " Kills " + DinoName);
                Battlefield.WinnerName = Robot.RobotName;
                Battlefield.Winner = true;
            }
            else
            {
                //Attacks the Robot
            Robot.RobotHealth = Robot.RobotHealth - DinoAttackPower;
            Console.WriteLine($"{DinoName} Attacked the {Robot.RobotName} with {DinoAttackPower} Attack Damage");

            //shows Dino and Robot health
            Console.WriteLine($"{DinoName}: Health {DinoHealth}. {Robot.RobotName}: Health {Robot.RobotHealth}"); 
            }
        }

        
    }
}
