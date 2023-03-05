using System;

namespace MagicDestroyers.Equipment.Weapons
{
    public class Sword : Weapon
    {
        public Sword()
        {
            base.Damage = Consts.Sword.DEFAULT_DAMAGE;
        }
        public void BloodThirst()
        {
            throw new NotImplementedException();
        }
    }
}
