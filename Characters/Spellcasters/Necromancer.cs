using MagicDestroyers.Equipment.Weapons;
using MagicDestroyers.Equipment.Armors;
using System;
using Enumerations;

namespace MagicDestroyers.Characters.Spellcasters
{
    public class Necromancer : Spellcaster
    {
        private readonly LightLeatherVest DEFAULT_BODY_ARMOR = new LightLeatherVest();
        private readonly Sword DEFAULT_WEAPON = new Sword();

        public Necromancer()
            : this(Consts.Necromancer.DEFAULT_NAME, Consts.Necromancer.DEFAULT_LEVEL)
        {

        }
        public Necromancer(string name, int level)
            : this(name, level, Consts.Necromancer.DEFAULT_HEALTH_POINTS)
        {

        }
        public Necromancer(string name, int level, int healthPoints)
        {
            base.Name = name;
            base.Level = level;
            base.HealthPoints = healthPoints;
            base.ManaPoints = Consts.Necromancer.DEFAULT_MANA_POINTS;
            base.Faction = Faction.Spellcaster;
            base.Weapon = DEFAULT_WEAPON;
            base.BodyArmor = DEFAULT_BODY_ARMOR;
            base.IsAlive = true;
            base.Scores = 0;
        }
        public int ShadowRage()
        {
            return base.Weapon.Damage + 10;
        }
        public int VampireTouch()
        {
            return base.Weapon.Damage + 15;
        }
        public int BoneShield()
        {
            return base.BodyArmor.ArmorPoints + 5;
        }

        public override int Attack()
        {
            return this.ShadowRage();
        }

        public override int Defend()
        {
            return this.BoneShield();
        }

        public override int SpecialAttack()
        {
            return this.VampireTouch();
        }
    }
}