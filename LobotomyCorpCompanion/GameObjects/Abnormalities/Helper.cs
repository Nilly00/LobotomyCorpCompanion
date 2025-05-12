using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LobotomyCorpCompanion.GameObjects.Abnormalities
{
    internal class Helper : Abnormality
    {
        public Helper()
        {
            name = "All-Around Helper";
            derivedName = "Grinder Mk4";
            riskLevel = RiskLevel.HE;

            weapon = new EgoWeapon(derivedName, 50, 1, [2, 0, 0, 0, 0], DamageType.RED, WeaponRange.Medium, riskLevel, 1, 3, AttackSpeed.Fast);

            suit = new EgoSuit(derivedName, 35, 3, [0, 2, 0, 0, 0], riskLevel, [0.6, 1.3, 0.9, 1.5]);

            gift = new EgoGift(derivedName, Slot.Eye, [0, 0, 2, 2, 0, 0]);
        }

        public override void WeaponEffect(Employee employee)
        {
            employee.SpecialEffects.Add("Hits 6 Times");
        }

        public override void GiftEffect(Employee employee)
        {
            employee.SpecialEffects.Add("INSIGHT SR +3%");
        }
    }
}