using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LobotomyCorpCompanion.GameObjects.Abnormalities
{
    internal class Woodsman : Abnormality
    {
        public Woodsman()
        {
            Name = "Warm-hearted Woodsman";
            DerivedName = "Logging";
            RiskLevel = RiskLevel.HE;

            Weapon = new EgoWeapon(DerivedName, 60, 2, [0, 2, 0, 0, 0], DamageType.RED, RiskLevel, 15, 21, 1, 1.0);

            Suit = new EgoSuit(DerivedName, 30, 3, [0, 0, 0, 0, 0], RiskLevel, [0.8, 1.2, 0.8, 1.5]);

            Gift = new EgoGift(DerivedName, Slot.Brooch, new SecondaryStats(HP:2,SR:2,WS:2));
        }
    }
}
