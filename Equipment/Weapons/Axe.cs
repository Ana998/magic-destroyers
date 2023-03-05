using System;

namespace MagicDestroyers.Equipment.Weapons
{
    public class Axe : Weapon
    {

        public Axe()
        {
            base.Damage = Consts.Axe.DEFAULT_DAMAGE;
        }
        public void HackNSlash()
        {
            throw new NotImplementedException();
        }
    }
}
