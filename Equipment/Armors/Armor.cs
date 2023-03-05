using System;

namespace MagicDestroyers.Equipment.Armors
{
    public abstract class Armor : Equipment
    {
        private int armorPoints;
        public int ArmorPoints
        {
            get
            {
                return armorPoints;
            }
            set
            {
                if (value >= 1)
                {
                    armorPoints = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, "Armor points should be greater than 1");
                }
            }
        }
    }
}
