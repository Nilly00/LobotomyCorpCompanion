using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LobotomyCorpCompanion.GameObjects.Abnormalities
{
    internal class Dream : Abnormality
    {
        public Dream()
        {
            Name = "Void Dream";
            DerivedName = "Engulfing Dream";
            RiskLevel = RiskLevel.TETH;

            Weapon = new EgoWeapon(DerivedName, 25, 2, [0, 0, 0, 0, 0], DamageType.WHITE,RiskLevel, 1, 2, 8, 1.0);

            Suit = new EgoSuit(DerivedName, 25, 2, [0, 0, 0, 0, 0], RiskLevel, [1.2, 0.8, 0.7, 2.0]);

            Gift = new EgoGift(DerivedName, Slot.Hat, new SecondaryStats(SP:4));
        }
    }
}