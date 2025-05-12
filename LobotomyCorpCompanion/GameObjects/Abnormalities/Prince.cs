using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LobotomyCorpCompanion.GameObjects.Abnormalities
{
    internal class Prince : Abnormality
    {
        public Prince()
        {
            name = "The Little Prince";
            derivedName = "Spore";
            riskLevel = RiskLevel.WAW;

            weapon = new EgoWeapon(derivedName,50, 3, [0, 0, 2, 0, 2], DamageType.WHITE, WeaponRange.Medium, riskLevel, 8,16, AttackSpeed.Fast);

            suit = new EgoSuit(derivedName,50, 3, [0, 2, 0, 0, 2], riskLevel, [0.8, 0.6, 1.2, 1.5]);

            gift = new EgoGift(derivedName, Slot.Hand_2, [0, 5, 2, 2, 0, 0]);
        }

        public override void WeaponEffect(Employee employee)
        {
            employee.SpecialEffects.Add("25% chance to make the target more vulnerable to WHITE damage");
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
