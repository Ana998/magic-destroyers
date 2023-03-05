using MagicDestroyers.Equipment.Weapons;
using MagicDestroyers.Equipment.Armors;
using System;
using Enumerations;

namespace MagicDestroyers.Characters.Melee
{
    public class Knight : Melee
    {
        private readonly Chainlink DEFAULT_BODY_ARMOR = new Chainlink();
        private readonly Hammer DEFAULT_WEAPON = new Hammer();

        public override int HealthPoints 
        {
            get
            {
                return base.HealthPoints;
            }
            set
            {
                if (value < 170)
                {
                    base.HealthPoints = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, "Health points for knights should be less than 170");
                }
            }
        }

        public Knight()
            : this(Consts.Knight.DEFAULT_NAME, Consts.Knight.DEFAULT_LEVEL)
        {

        }
        public Knight(string name, int level)
            : this(name, level, Consts.Knight.DEFAULT_HEALTH_POINTS)
        {

        }
        public Knight(string name, int level, int healthPoints)
        {
            base.Name = name;
            base.Level = level;
            base.HealthPoints = healthPoints;
            base.AbilityPoints = Consts.Knight.DEFAULT_ABILITY_POINTS;
            base.Faction = Consts.Knight.DEFAULT_FACTION;
            base.Weapon = DEFAULT_WEAPON;
            base.BodyArmor = DEFAULT_BODY_ARMOR;
            base.IsAlive = true;
            base.Scores = 0;
        }
        public int HolyBlow()
        {
            return base.Weapon.Damage + 10;
        }
        public int PurifySoul()
        {
            return base.BodyArmor.ArmorPoints + 5;
        }
        public int RighteousWings()
        {
            return base.Weapon.Damage + 15;
        }

        public override int Attack()
        {
            return this.HolyBlow();
        }

        public override int Defend()
        {
            return this.PurifySoul();
        }

        public override int SpecialAttack()
        {
            return this.RighteousWings();
        }
    }
}