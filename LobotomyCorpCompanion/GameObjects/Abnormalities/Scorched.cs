using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LobotomyCorpCompanion.GameObjects.Abnormalities
{
    internal class Scorched : Abnormality
    {
        public Scorched()
        {
            Name = "Scorched Girl";
            DerivedName = "Fourth Match Flame";
            RiskLevel = RiskLevel.TETH;

            Weapon = new EgoWeapon(DerivedName, 35, 1, [0, 0, 0, 0, 0], DamageType.RED, RiskLevel, 20, 30, 15, 5.0);

            Suit = new EgoSuit(DerivedName, 25, 2, [0, 0, 0, 0, 0], RiskLevel, [0.6, 1.0, 1.2, 2.0]);

            Gift = new EgoGift(DerivedName, Slot.Mouth_2, new SecondaryStats(HP:4));
        }
    }
}
