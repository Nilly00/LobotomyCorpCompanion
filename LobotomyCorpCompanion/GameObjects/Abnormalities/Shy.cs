using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LobotomyCorpCompanion.GameObjects.Abnormalities
{
    internal class Shy : Abnormality
    {
        public Shy()
        {
            Name = "Today's Shy look";
            DerivedName = "Today's Expression";
            RiskLevel = RiskLevel.TETH;

            Weapon = new EgoWeapon(DerivedName, 25, 2, [0, 0, 0, 0, 0], DamageType.BLACK, RiskLevel, 2, 3, 10, 0.7);

            Suit = new EgoSuit(DerivedName, 30, 1, [2, 0, 0, 0, 0], RiskLevel, [0.7, 0.6, 1.5, 2.0]);

            Gift = new EgoGift(DerivedName, Slot.Eye, new SecondaryStats(SP:-2,SR:4,WS:4));
        }
    }
}
