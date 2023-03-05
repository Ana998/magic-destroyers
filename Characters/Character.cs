using Characters.Interfaces;
using Enumerations;
using MagicDestroyers.Equipment.Armors;
using MagicDestroyers.Equipment.Weapons;
using System;

namespace MagicDestroyers.Characters
{
    public abstract class Character : IAttack, IDefend
    {
        private int level;
        private int healthPoints;
        private int scores;

        private string name;

        private bool isAlive;

        private Faction faction;
        private Armor bodyArmor;
        private Weapon weapon;
        public int Level 
        { 
            get
            {
                return this.level;
            }
            set
            {
                if (value >= 1)
                {
                    this.level = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, "Level should be greater than 1");
                }
            }
        }
        public virtual int HealthPoints 
        { 
            get
            {
                return this.healthPoints;
            }
            set
            {
                if (value <= 300)
                {
                    this.healthPoints = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, "Health points for characters must be less than 300!");
                }
            }
        }
        public int Scores 
        { 
            get
            {
                return this.scores;
            }
            set
            {
                this.scores = value;
            }
        }
        public string Name 
        { 
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }
        public bool IsAlive 
        { 
            get
            {
                return this.isAlive;
            }
            set
            {
                this.isAlive = value;
            }
        }
        public Faction Faction 
        { 
            get
            {
                return this.faction;
            }
            set
            {
                    this.faction = value;
            }
        }
        public Weapon Weapon
        {
            get
            {
                return this.weapon;
            }
            set
            {
                this.weapon = value;
            }
        }
        public Armor BodyArmor
        {
            get
            {
                return this.bodyArmor;
            }
            set
            {
                this.bodyArmor = value;
            }
        }
        public abstract int Attack();
        public abstract int Defend();
        public abstract int SpecialAttack();
        public void TakeDamage(int damage, string attackerName, string type)
        {
            if (this.Defend() < damage)
            {
                this.HealthPoints = this.HealthPoints - damage + this.Defend();
                if (this.HealthPoints <= 0)
                {
                    this.isAlive = false;
                }
            }
            else
            {
                Tools.ColorfulWriteLine("Haha! Your damage was not enough to harm me!", ConsoleColor.DarkYellow);
            }

            if (!this.isAlive)
            {
                Tools.TypeSpecificColorfulCW($"{this.name} received {damage} damage from {attackerName}, and is now dead!", type);
            }
            else
            {
                Tools.TypeSpecificColorfulCW($"{this.name} received {damage} damage from {attackerName}, and now has {this.healthPoints} health points!", type);
            }
        }
        public void WonBattle()
        {
            this.scores++;
            if (scores % 10 == 0)
            {
                this.level += 1;
            }    
        }
    }
}
