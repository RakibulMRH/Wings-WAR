using WarriorWars.Enums;

namespace WarriorWars.Equipment
{
    public class Weapon
    {
        private const int GOOD_GUY_DAMAGE = 10;
        private const int BAD_GUY_DAMAGE = 10;

        private int damage;

        public int Damage
        {
            get
            {
                return damage;
            }
        }

        public Weapon(Faction faction)
        {
            if (faction == Faction.GoodGuy)
            {
                damage = GOOD_GUY_DAMAGE;
            }
            else if (faction == Faction.BadGuy)
            {
                damage = BAD_GUY_DAMAGE;
            }
        }
    }
}
