using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DinoVsRobot
{
    public class Robot
    {
        static public string RobotName = "Robot";
        static public int RobotHealth = 100;
        static public int attackPower;
        static string weapon;
       
        static void activeWeapon(string weapon)
        {
          
            Weapon.WeaponType(weapon);
            attackPower = Weapon.AttackPower;
            
        }

        static public void AttackDino()
        {
            //Checks if Robot is at 0 or less then 0
             if (RobotHealth <= 0)
            {
                Console.WriteLine($"{RobotName} has reached {RobotHealth}");
                Console.WriteLine(Dinosaur.DinoName + " Kills " + RobotName);

                Battlefield.WinnerName = Dinosaur.DinoName;
                Battlefield.Winner = true;
            }
            else
            {
                //Enter what weapon you want to use
              Console.WriteLine("What Weapon should the robot use? Enter Lazor, Knife, Carrot!");
             weapon = Console.ReadLine();
            activeWeapon(weapon);

                //Attacks the Dino
            Dinosaur.DinoHealth = Dinosaur.DinoHealth - attackPower;
            Console.WriteLine($"{RobotName} attacked {Dinosaur.DinoHealth} with {attackPower} Attack Damage");

            //shows Dino and Robot health
            Console.WriteLine($"{Dinosaur.DinoName}: Health {Dinosaur.DinoHealth}. {RobotName}: Health {RobotHealth}");
            Console.WriteLine();
            }
        }
    }
}
