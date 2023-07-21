using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinoVsRobot
{
    public class Battlefield
    {
       
        public int attacknum;
        static public bool Winner = false;
        static public string WinnerName;

        public void runGame()
        {
            Welcome();

            while(!Winner)
            {
                attack();
            }
            AnnounceWinner();
        }


        public void AnnounceWinner()
        {
            Console.WriteLine($"Winner is {WinnerName}!!!!!");
        }

        public void attack()
        {
            //Dino Attacks Robot
            Dinosaur.AttackRobot();

            //Robot Attacks Dino
            Robot.AttackDino(); 
        }

        public void Welcome()
        {
            Console.WriteLine("Welcome to the battle feilds :)");
            Console.WriteLine();
        }
    }
}
