using MagicDestroyers.Equipment.Weapons;
using MagicDestroyers.Equipment.Armors;
using System;
using Enumerations;

namespace MagicDestroyers.Characters.Spellcasters
{
    public class Mage : Spellcaster
    {
        private readonly ClothRobe DEFAULT_BODY_ARMOR = new ClothRobe();
        private readonly Staff DEFAULT_WEAPON = new Staff();
        public Mage()
            : this(Consts.Mage.DEFAULT_NAME, Consts.Mage.DEFAULT_LEVEL)
        {

        }
        public Mage(string name, int level)
            : this(name, level, Consts.Mage.DEFAULT_HEALTH_POINTS)
        {

        }
        public Mage(string name, int level, int healthPoints)
        {
            base.Name = name;
            base.Level = level;
            base.HealthPoints = healthPoints;
            base.ManaPoints = Consts.Mage.DEFAULT_MANA_POINTS;
            base.Faction = Faction.Spellcaster;
            base.Weapon = DEFAULT_WEAPON;
            base.BodyArmor = DEFAULT_BODY_ARMOR;
            base.IsAlive = true;
            base.Scores = 0;
        }
        public int ArcaneWrath()
        {
            return base.Weapon.Damage + 10;
        }
        public int Fireball()
        {
            return base.Weapon.Damage + 10;
        }
        public int Meditation()
        {
            return base.BodyArmor.ArmorPoints + 5;
        }

        public override int Attack()
        {
            return this.Fireball();
        }

        public override int Defend()
        {
            return this.Meditation();
        }

        public override int SpecialAttack()
        {
            return this.ArcaneWrath();
        }
    }
}
