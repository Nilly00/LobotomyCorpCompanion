using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LobotomyCorpCompanion.GameObjects.Abnormalities
{
    internal class OldLady : Abnormality
    {
        public OldLady()
        {
            Name = "Old Lady";
            DerivedName = "Solitude";
            RiskLevel = RiskLevel.TETH;

            Weapon = new EgoWeapon(DerivedName, 30, 2, [0, 0, 0, 0, 0], DamageType.WHITE, RiskLevel, 2, 3, 10, 0.7);

            Suit = new EgoSuit(DerivedName, 20, 3, [0, 0, 0, 0, 0], RiskLevel, [1.5, 0.8, 0.8, 2.0]);

            Gift = new EgoGift(DerivedName, Slot.Eye, new SecondaryStats(SR:3,WS:3));
        }
    }
}
