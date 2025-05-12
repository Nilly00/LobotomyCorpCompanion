using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LobotomyCorpCompanion.GameObjects.Abnormalities
{
    internal class Heaven : Abnormality
    {
        public Heaven()
        {
            name = "The Burrowing Heaven";
            derivedName = "Heaven";
            riskLevel = RiskLevel.WAW;

            weapon = new EgoWeapon(derivedName, 40, 3, [0, 0, 0, 0, 3], DamageType.RED, WeaponRange.Medium, riskLevel, 8, 16, AttackSpeed.Fast);

            suit = new EgoSuit(derivedName, 50, 2, [3, 0, 0, 0, 0], riskLevel, [1.2, 0.8, 0.6, 1.5]);

            gift = new EgoGift(derivedName, Slot.Helmet, [4, 0, 2, 2, 0, 0]);
        }

        public override void SuitEffect(Employee employee)
        {
            employee.SpecialEffects.Add("");
        }

        public override void GiftEffect(Employee employee)
        {
            employee.SpecialEffects.Add("");
        }
    }
}
