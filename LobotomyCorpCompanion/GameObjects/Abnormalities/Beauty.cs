using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LobotomyCorpCompanion.GameObjects.Abnormalities
{
    internal class Beauty : Abnormality
    {
        public Beauty()
        {
            Name = "Beauty and the Beast";
            DerivedName = "Horn";
            RiskLevel = RiskLevel.TETH;

            Weapon = new EgoWeapon(DerivedName, 30, 3, [0, 0, 0, 0, 0], DamageType.RED, RiskLevel, 5, 9, 1, 1.0);

            Suit = new EgoSuit(DerivedName, 30, 3, [0, 0, 0, 0, 0], RiskLevel, [0.8, 0.8, 1.5, 2.0]);

            Gift = new EgoGift(DerivedName, Slot.Hat, new SecondaryStats(HP:2, SP:2));
        }
    }
}
