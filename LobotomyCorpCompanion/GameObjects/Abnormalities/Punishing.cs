using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LobotomyCorpCompanion.GameObjects.Abnormalities
{
    internal class Punishing : Abnormality
    {
        public Punishing()
        {
            Name = "Punishing Bird";
            DerivedName = "Beak";
            RiskLevel = RiskLevel.TETH;

            Weapon = new EgoWeapon(DerivedName, 30, 2, [0, 0, 0, 0, 0], DamageType.RED,RiskLevel, 2, 3, 10, 0.7);

            Suit = new EgoSuit(DerivedName, 25, 2, [0, 0, 0, 0, 0], RiskLevel, [0.7, 0.8, 1.2, 2.0]);

            Gift = new EgoGift(DerivedName, Slot.Neckwear, new SecondaryStats(AS:2,MS:2));
        }
    }
}
