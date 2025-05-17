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
            Name = "Judgement Bird";
            DerivedName = "Justitia";
            RiskLevel = RiskLevel.WAW;

            Weapon = new EgoWeapon(DerivedName, 150, 1, [0, 0, 0, 5, 5], DamageType.PALE, RiskLevel.ALEPH, 2, 4, 1, 1.0);

            Suit = new EgoSuit(DerivedName, 120, 1, [0, 0, 0, 5, 5], RiskLevel.ALEPH, [0.5, 0.5, 0.5, 0.5]);

            Gift = new EgoGift(DerivedName, Slot.Eye, new SecondaryStats(AS:3,MS:3));
        }

        internal override void WeaponEffect(Employee employee)
        {
            employee.SpecialEffects.Add("Hits 5 Times");
            employee.SpecialEffects.Add("Special Attack that hits 13 Times");
        }

        internal override void GiftEffect(Employee employee)
        {
            employee.SpecialEffects.Add("REPRESSION SR +6%");
        }
    }
}
