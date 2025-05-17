using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LobotomyCorpCompanion.GameObjects.Abnormalities
{
    internal class Army : Abnormality
    {
        public Army()
        {
            Name = "Army in Black";
            DerivedName = "Pink";
            RiskLevel = RiskLevel.ALEPH;

            Weapon = new EgoWeapon(DerivedName,222, 1, [0, 5, 0, 0, 5], DamageType.WHITE, RiskLevel,20,24, 1, 1.0);

            Suit = new EgoSuit(DerivedName,120, 1, [5, 0, 0, 0, 5], RiskLevel, [0.5, 0.3, 0.4, 1.0]);

            Gift = new EgoGift(DerivedName, Slot.Helmet, new SecondaryStats(AS:5, MS:5));
        }

        internal override void WeaponEffect(Employee employee)
        {
            employee.SpecialEffects.Add("Requires 2 seconds of setup time before commencing attack.");
        }

        internal override void GiftEffect(Employee employee)
        {
            if (employee.weapon == this)
            {
                employee.permanentBoni.damagePercent *= 1.15;
            }
        }
    }
}
