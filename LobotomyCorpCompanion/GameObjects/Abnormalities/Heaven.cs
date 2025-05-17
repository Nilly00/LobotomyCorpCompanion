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
            Name = "The Burrowing Heaven";
            DerivedName = "Heaven";
            RiskLevel = RiskLevel.WAW;

            Weapon = new EgoWeapon(DerivedName, 40, 3, [0, 0, 0, 0, 3], DamageType.RED, RiskLevel, 8, 16, 1, 1.0);

            Suit = new EgoSuit(DerivedName, 50, 2, [3, 0, 0, 0, 0], RiskLevel, [1.2, 0.8, 0.6, 1.5]);

            Gift = new EgoGift(DerivedName, Slot.Helmet, new SecondaryStats(HP:4,SR:2,WS:2));
        }

        internal override void SuitEffect(Employee employee)
        {
            employee.SpecialEffects.Add("");
        }

        internal override void GiftEffect(Employee employee)
        {
            employee.SpecialEffects.Add("");
        }
    }
}
