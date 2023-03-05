using System;

namespace MagicDestroyers.Equipment.Weapons
{
    public class Hammer : Weapon
    {
        public Hammer()
        {
            base.Damage = Consts.Hammer.DEFAULT_DAMAGE;
        }
        public void Stun()
        {
            throw new NotImplementedException();
        }
    }
}
