using System;

namespace MagicDestroyers.Equipment.Weapons
{
    public class Staff : Weapon
    {
        public Staff()
        {
            base.Damage = Consts.Staff.DEFAULT_DAMAGE;
        }
        public void Empower()
        {
            throw new NotImplementedException();
        }
    }
}
