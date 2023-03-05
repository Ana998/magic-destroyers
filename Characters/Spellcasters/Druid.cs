using MagicDestroyers.Equipment.Weapons;
using MagicDestroyers.Equipment.Armors;
using System;
using Enumerations;

namespace MagicDestroyers.Characters.Spellcasters
{
    public class Druid : Spellcaster
    {
        private readonly LightLeatherVest DEFAULT_BODY_ARMOR = new LightLeatherVest();
        private readonly Staff DEFAULT_WEAPON = new Staff();

        public override int HealthPoints 
        {
            get
            {
                return base.HealthPoints;
            }
            set
            {
                if (value < 190)
                {
                    base.HealthPoints = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, "Health points for druid should be less than 190");
                }
            }
        }

        public Druid()
            : this(Consts.Druid.DEFAULT_NAME, Consts.Druid.DEFAULT_LEVEL)
        {

        }
        public Druid(string name, int level)
            : this(name, level, Consts.Druid.DEFAULT_HEALTH_POINTS)
        {

        }
        public Druid(string name, int level, int healthPoints)
        {
            base.Name = name;
            base.Level = level;
            base.HealthPoints = healthPoints;
            base.ManaPoints = Consts.Druid.DEFAULT_MANA_POINTS;
            base.Faction = Faction.Spellcaster;
            base.Weapon = DEFAULT_WEAPON;
            base.BodyArmor = DEFAULT_BODY_ARMOR;
            base.IsAlive = true;
            base.Scores = 0;
        }
        public int Moonfire()
        {
            return base.Weapon.Damage + 10;
        }
        public int Starbust()
        {
            return base.Weapon.Damage + 15;
        }
        public int OneWithTheNature()
        {
            return base.BodyArmor.ArmorPoints + 5;
        }

        public override int Attack()
        {
            return this.Moonfire();
        }

        public override int Defend()
        {
            return this.OneWithTheNature();
        }

        public override int SpecialAttack()
        {
            return this.Starbust();
        }
    }
}