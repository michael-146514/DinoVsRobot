using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinoVsRobot
{
    public class Weapon
    {
        static public int AttackPower;
        static public void WeaponType(string type)
        {
            if (type == "Lazor")
            {
                int laser = 15;
                AttackPower = laser;
               
            }
            else if(type == "Knife")
            {
                int knife = 20;
                AttackPower = knife;
            }else if(type == "Carrot"){
                int Carrot = 25;
                AttackPower = Carrot;
            }
            else
            {
                int wrong = 1;
                AttackPower = wrong;
                Console.WriteLine("Incorrect Weapon Name! Attack is 1");
            }
        }
    }
}
