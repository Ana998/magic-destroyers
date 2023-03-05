using MagicDestroyers.Equipment.Weapons;
using MagicDestroyers.Equipment.Armors;
using System;
using Enumerations;

namespace MagicDestroyers.Characters.Melee
{
    public class Warrior : Melee
    {
        private readonly Chainlink DEFAULT_BODY_ARMOR = new Chainlink();
        private readonly Axe DEFAULT_WEAPON = new Axe();
       
        public override int HealthPoints 
        {
            get
            {
                return base.HealthPoints;
            }
            set
            {
                if (value <= 140)
                {
                    base.HealthPoints = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, "Health points for warriors need to be less than 140!");
                }
            }
        }

        public Warrior()
            : this(Consts.Warrior.DEFAULT_NAME, Consts.Warrior.DEFAULT_LEVEL)
        {

        }
        public Warrior(string name, int level)
            : this(name, level, Consts.Warrior.DEFAULT_HEALTH_POINTS)
        {

        }
        public Warrior(string name, int level, int healthPoints)
        {
            base.Name = name;
            base.Level = level;
            base.HealthPoints = healthPoints;
            base.AbilityPoints = Consts.Warrior.DEFAULT_ABILITY_POINTS;
            base.Faction = Consts.Warrior.DEFAULT_FACTION;
            base.Weapon = DEFAULT_WEAPON;
            base.BodyArmor = DEFAULT_BODY_ARMOR;
            base.IsAlive = true;
            base.Scores = 0;
        }
        public int Strike()
        {
            //we are going to strike with the damage points from the weapon plus the 10 points from the strike
            return base.Weapon.Damage + 10;
        }
        public int Execute()
        {
            return base.Weapon.Damage + 10;
        }
        public int SkinHarden()
        {
            return base.BodyArmor.ArmorPoints + 5;
        }

        public override int Attack()
        {
            return this.Strike();
        }

        public override int Defend()
        {
            return this.SkinHarden();
        }

        public override int SpecialAttack()
        {
            return this.Execute();
        }
    }
}
