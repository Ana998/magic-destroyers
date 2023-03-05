using System;
namespace MagicDestroyers.Equipment.Armors
{
    public class Chainlink : Armor
    {
        public Chainlink()
        {
            base.ArmorPoints = Consts.Chainlink.DEFAULT_ARMOR_POINTS;
        }
        public Chainlink(int armorPoints)
        {
            base.ArmorPoints = armorPoints;
        }
    }
}
