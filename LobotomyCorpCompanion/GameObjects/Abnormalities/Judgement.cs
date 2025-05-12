using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LobotomyCorpCompanion.GameObjects.Abnormalities
{
    internal class Judgement : Abnormality
    {
        public Judgement()
        {
            name = "Judgement Bird";
            derivedName = "Justitia";
            riskLevel = RiskLevel.WAW;

            weapon = new EgoWeapon(derivedName, 150, 1, [0, 0, 0, 5, 5], DamageType.PALE, WeaponRange.Medium, RiskLevel.ALEPH, 2, 4, AttackSpeed.Normal);

            suit = new EgoSuit(derivedName, 120, 1, [0, 0, 0, 5, 5], RiskLevel.ALEPH, [0.5, 0.5, 0.5, 0.5]);

            gift = new EgoGift(derivedName, Slot.Eye, [0, 0, 0, 0, 3, 3]);
        }

        public override void WeaponEffect(Employee employee)
        {
            employee.SpecialEffects.Add("Hits 5 Times");
            employee.SpecialEffects.Add("Special Attack that hits 13 Times");
        }

        public override void GiftEffect(Employee employee)
        {
            employee.SpecialEffects.Add("REPRESSION SR +6%");
        }
    }
}
