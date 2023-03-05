using System;

namespace MagicDestroyers.Equipment.Weapons
{
    public abstract class Weapon : Equipment
    {
        private int damage;
        public int Damage
        {
            get
            {
                return damage;
            }
            set
            {
                if (value >= 1)
                {
                    damage = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, "Damage has to be greater than 1");
                }
            }
        }
    }
}
