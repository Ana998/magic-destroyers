using System;

namespace MagicDestroyers.Characters.Spellcasters
{
    public abstract class Spellcaster : Character
    {
        private int manaPoints;
        public int ManaPoints
        {
            get
            {
                return this.manaPoints;
            }
            set
            {
                if (value >= 1 && value <= 210)
                {
                    this.manaPoints = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, "Spellcaster mana points must be between 1 and 210");
                }
            }
        }
    }
}
