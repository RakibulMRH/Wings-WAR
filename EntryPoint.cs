using System;
using System.Threading;
using WarriorWars.Enums;

namespace WarriorWars
{
    class EntryPoint
    {
        static Random rng = new Random();

        static void Main()
        {
            Warrior goodGuy = new Warrior("Zoro", Faction.GoodGuy);
            Warrior badGuy = new Warrior("Sanji", Faction.BadGuy);

            int rand_num = rng.Next(0, 10);


            while (goodGuy.IsAlive && badGuy.IsAlive)
            {
                if (rand_num < 5)
                {
                    goodGuy.Attack(badGuy);
                    badGuy.Attack(goodGuy);
                }
                else
                {
                    badGuy.Attack(goodGuy);
                    goodGuy.Attack(badGuy);
                }

                Thread.Sleep(500);

            }
        }
    }
}
