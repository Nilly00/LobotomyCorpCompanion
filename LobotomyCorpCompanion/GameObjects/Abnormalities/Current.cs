using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LobotomyCorpCompanion.GameObjects.Abnormalities
{
    internal class Current : Abnormality
    {
        public Current()
        {
            Name = "The Dreaming Current";
            DerivedName = "Ecstasy";
            RiskLevel = RiskLevel.WAW;

            Weapon = new EgoWeapon(DerivedName, 60, 2, [2, 0, 0, 0, 3], DamageType.WHITE,RiskLevel, 2, 4, 1, 1.0);

            Suit = new EgoSuit(DerivedName, 40, 3, [0, 0, 2, 0, 2], RiskLevel, [0.8, 0.8, 0.8, 1.5]);

            Gift = new EgoGift(DerivedName, Slot.Mouth_2, new SecondaryStats(SP:6));
        }
    }
}