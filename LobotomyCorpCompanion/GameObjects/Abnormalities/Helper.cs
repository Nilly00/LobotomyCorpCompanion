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
            Name = "All-Around Helper";
            DerivedName = "Grinder Mk4";
            RiskLevel = RiskLevel.HE;

            Weapon = new EgoWeapon(DerivedName, 50, 1, [2, 0, 0, 0, 0], DamageType.RED, RiskLevel, 1, 3, 4, 1.6);

            Suit = new EgoSuit(DerivedName, 35, 3, [0, 2, 0, 0, 0], RiskLevel, [0.6, 1.3, 0.9, 1.5]);

            Gift = new EgoGift(DerivedName, Slot.Eye, new SecondaryStats(SR:2,WS:2));
        }

        internal override void WeaponEffect(Employee employee)
        {
            employee.SpecialEffects.Add("Hits 6 Times");
        }

        internal override void GiftEffect(Employee employee)
        {
            employee.SpecialEffects.Add("INSIGHT SR +3%");
        }
    }
}