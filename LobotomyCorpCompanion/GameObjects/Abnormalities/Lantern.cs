using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LobotomyCorpCompanion.GameObjects.Abnormalities
{
    internal class Lantern : Abnormality
    {
        public Lantern()
        {
            Name = "Meat Lantern";
            DerivedName = "Lantern";
            RiskLevel = RiskLevel.TETH;

            Weapon = new EgoWeapon(DerivedName, 25, 2, [0, 0, 0, 0, 0], DamageType.BLACK, RiskLevel, 12, 18, 5, 3.0);

            Suit = new EgoSuit(DerivedName, 30, 2, [0, 0, 0, 0, 0], RiskLevel, [0.8, 0.7, 1.2, 2.0]);

            Gift = new EgoGift(DerivedName, Slot.Mouth_2, new SecondaryStats(HP: 5));
        }
    }
}
