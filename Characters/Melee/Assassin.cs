using MagicDestroyers.Equipment.Weapons;
using MagicDestroyers.Equipment.Armors;
using System;
using Enumerations;

namespace MagicDestroyers.Characters.Melee
{
    public class Assassin : Melee
    {
        private readonly LightLeatherVest DEFAULT_BODY_ARMOR = new LightLeatherVest();
        private readonly Sword DEFAULT_WEAPON = new Sword();

        public override int HealthPoints {
            get
            {
                return base.HealthPoints;
            }
            set
            {
                if (value < 200)
                {
                    base.HealthPoints = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, "Health points for assasin should be less than than 200");
                }
            }
        }
        /*public int HealthPoints
        {
            get
            {
                return healthPoints;
            }
            set
            {
                if (value >= 1)
                {
                    HealthPoints = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, "Health points should be greater than 1");
                }
            }
        }
        public int Level
        {
            get
            {
                return level;
            }
            set
            {
                if (value >= 1)
                {
                    level = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, "Level should be greater than 1");
                }
            }
        }
        public string Name { get; set; }
        public Faction Faction
        {
            get
            {
                return faction;
            }
            set
            {
                faction = value;
                /*if (value == Faction.Melee)
                {
                    faction = value;
                }
                else
                {
                    throw new ArgumentException(string.Empty, $@"The faction {faction} is not valid");
                }
            }
        }*/
        public Assassin()
            :this(Consts.Assasin.DEFAULT_NAME, Consts.Assasin.DEFAULT_LEVEL)
        {

        }
        public Assassin(string name, int level)
            :this(name, level, Consts.Assasin.DEFAULT_HEALTH_POINTS)
        {

        }
        public Assassin(string name, int level, int healthPoints)
        {
            base.Name = name;
            base.Level = level;
            base.HealthPoints = healthPoints;
            base.AbilityPoints = Consts.Assasin.DEFAULT_ABILITY_POINTS;
            base.Faction = Consts.Assasin.DEFAULT_FACTION;
            base.Weapon = DEFAULT_WEAPON;
            base.BodyArmor = DEFAULT_BODY_ARMOR;
            base.IsAlive = true;
            base.Scores = 0;
        }
        public int Raze()
        {
            return base.Weapon.Damage + 10;
        }
        public int BleedToDeath()
        {
            return base.Weapon.Damage + 15;
        }
        public int Survival()
        {
            return base.BodyArmor.ArmorPoints + 5;
        }

        public override int Attack()
        {
            return this.Raze();
        }

        public override int Defend()
        {
            return this.Survival();
        }

        public override int SpecialAttack()
        {
            return this.BleedToDeath();
        }
    }
}
