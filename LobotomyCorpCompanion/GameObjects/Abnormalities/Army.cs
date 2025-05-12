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
            name = "Army in Black";
            derivedName = "Pink";
            riskLevel = RiskLevel.ALEPH;

            weapon = new EgoWeapon(derivedName,222, 1, [0, 5, 0, 0, 5], DamageType.WHITE, WeaponRange.VeryLong, riskLevel,20,24, AttackSpeed.Normal);

            suit = new EgoSuit(derivedName,120, 1, [5, 0, 0, 0, 5], riskLevel, [0.5, 0.3, 0.4, 1.0]);

            gift = new EgoGift(derivedName, Slot.Helmet, [0, 0, 0, 0, 5, 5]);
        }

        public override void WeaponEffect(Employee employee)
        {
            employee.SpecialEffects.Add("Requires 2 seconds of setup time before commencing attack.");
        }

        public override void GiftEffect(Employee employee)
        {
            if (employee.weapon == this)
            {
                //todo properly implement damage boost
                employee.SpecialEffects.Add("+15% Damage");
            }
        }
    }
}
