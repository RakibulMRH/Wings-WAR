using WarriorWars.Enums;

namespace WarriorWars.Equipment
{
    public class Armor
    {
        private const int GOOD_GUY_ARMOR_POINTS = 5;
        private const int BAD_GUY_ARMOR_POINTS = 5;

        private int armorPoints;

        public int ArmorPoints
        {
            get
            {
                return armorPoints;
            }
        }

        public Armor(Faction faction)
        {
            if (faction == Faction.GoodGuy)
            {
                armorPoints = GOOD_GUY_ARMOR_POINTS;
            }
            else if (faction == Faction.BadGuy)
            {
                armorPoints = BAD_GUY_ARMOR_POINTS;
            }
        }
    }
}
