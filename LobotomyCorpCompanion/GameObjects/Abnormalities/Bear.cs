using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LobotomyCorpCompanion.GameObjects.Abnormalities
{
    internal class Bear : Abnormality
    {
        public Bear()
        {
            name = "Happy Teddy Bear";
            derivedName = "Bear Paws";
            riskLevel = RiskLevel.HE;

            weapon = new EgoWeapon(derivedName, 40, 2, [2, 0, 0, 0, 0], DamageType.RED, WeaponRange.VeryShort, riskLevel, 6, 7, AttackSpeed.Normal);

            suit = new EgoSuit(derivedName, 30, 3, [0, 0, 0, 0, 2], riskLevel, [0.8, 1.0, 1.0, 1.5]);

            gift = new EgoGift(derivedName, Slot.Hat, [0, 4, 0, 0, 0, 0]);
        }

        public override void WeaponEffect(Employee employee)
        {
            employee.SpecialEffects.Add("Dual Weapon");
        }

        public override void GiftEffect(Employee employee)
        {
            employee.SpecialEffects.Add("ATTACHMENT work SR +3%");
        }
    }
}
