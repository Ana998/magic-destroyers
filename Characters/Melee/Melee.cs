using System;

namespace MagicDestroyers.Characters.Melee
{
    public abstract class Melee : Character
    {
        private int abilityPoints;
        public int AbilityPoints
        {
            get
            {
                return abilityPoints;
            }
            set
            {
                if (value >= 1 && value <= 200)
                {
                    abilityPoints = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, "Ability points for Melee characters must be between 1 and 200");
                }
            }
        }
    }
}
