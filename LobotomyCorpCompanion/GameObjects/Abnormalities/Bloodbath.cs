using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LobotomyCorpCompanion.GameObjects.Abnormalities
{
    internal class Bloodbath : Abnormality
    {
        public Bloodbath()
        {
            Name = "Bloodbath";
            DerivedName = "Wrist Cutter";
            RiskLevel = RiskLevel.TETH;

            Weapon = new EgoWeapon(DerivedName, 25, 2, [0, 0, 0, 0, 0], DamageType.WHITE,RiskLevel, 2, 3, 2, 0.7);

            Suit = new EgoSuit(DerivedName, 25, 2, [0, 0, 0, 0, 0], RiskLevel, [1.0, 0.6, 1.2, 2.0]);

            Gift = new EgoGift(DerivedName, Slot.Hand_2, new SecondaryStats(SR:2, WS:2));
        }
    }
}
