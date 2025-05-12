using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LobotomyCorpCompanion.GameObjects.Abnormalities
{
    internal class Galaxy : Abnormality
    {
        public Galaxy()
        {
            name = "Child of the Galaxy";
            derivedName = "Our Galaxy";
            riskLevel = RiskLevel.HE;

            weapon = new EgoWeapon(derivedName, 45, 1, [0, 2, 0, 0, 2], DamageType.BLACK, WeaponRange.Medium, riskLevel, 9, 15, AttackSpeed.Normal);

            suit = new EgoSuit(derivedName, 30, 3, [0, 0, 0, 0, 0], riskLevel, [0.8, 0.8, 1.2, 1.5]);

            gift = new EgoGift(derivedName, Slot.Neckwear, [0, 0, 3, 3, 0, 0]);
        }


        public override void SuitEffect(Employee employee)
        {
            employee.SpecialEffects.Add("Galaxy Child Pebble healing increased");
        }

        public override void GiftEffect(Employee employee)
        {
            employee.SpecialEffects.Add("Periodically recover a small amount of HP");
        }
    }
}
