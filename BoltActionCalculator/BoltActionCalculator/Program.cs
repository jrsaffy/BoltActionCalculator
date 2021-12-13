using System;
using System.Collections.Generic;

namespace BoltActionCalculator
{
    class Program
    {

        static int rangeModifier(int distance, Weapon weapon)
        {
            int modifier = 0;
            if(weapon.range / 2 < distance)
            {
                modifier = 1;
            }
            if(distance < 6)
            {
                modifier = -1;
            }
            return modifier;
        }

        static int attackHits(Squad Attackers, Squad Defenders, int distance, int cover, int hasMoved = 0)
        {
            int numberOfHits = 0;

            
            
            Random dice_roller = new Random();
            //For Each Soldier
            for (int soldier = 0; soldier < Attackers.numberOfSoldiers; soldier++)
            {
                int hitOnValue = 3 + cover + hasMoved;

                Weapon weapon = Attackers.soldiers[soldier].weapon;

                Console.Write("Soldier: ");
                Console.Write(soldier);
                Console.Write(" ");

                Console.Write("Hit on Value: ");
                hitOnValue = hitOnValue + rangeModifier(distance, weapon);
                Console.WriteLine(hitOnValue);
     

                //For ever shot of their weapon: 
                //Note that big expression should not be in one line
                for (int shot = 1; shot <= weapon.numAttacks; shot++)
                {
                    Console.Write("Shot: ");
                    Console.Write(shot);
                    Console.Write(" ");
                    int dice_roll = dice_roller.Next(1,7);
                    Console.Write("dice_roll: ");
                    Console.WriteLine(dice_roll);
                    if (dice_roll >= hitOnValue)
                    {
                        numberOfHits++;
                    }
                }
                
            }
            return numberOfHits;
        }



        static void Main(string[] args)
        {
            Weapon rifle = new Weapon(24, 1);
            Weapon automatic_rifle = new Weapon(30, 2);
            Weapon assault_rifle = new Weapon(18, 2);

            Soldier soldier1 = new Soldier(rifle);
            Soldier soldier2 = new Soldier(automatic_rifle);
            Soldier soldier3 = new Soldier(assault_rifle);

            List<Soldier> list_soldiers = new List<Soldier>();
            list_soldiers.Add(soldier1);
            list_soldiers.Add(soldier2);
            list_soldiers.Add(soldier3);

            Squad test1 = new Squad(false, "Regular", list_soldiers);
            Squad test2 = new Squad(false, "Regular", list_soldiers);

            Console.WriteLine("Number of Hits: ");
            Console.Write(attackHits(test1, test2, distance: 14, cover: 1, hasMoved: 0 ));
        }
    }
}
