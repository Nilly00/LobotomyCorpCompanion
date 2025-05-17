using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LobotomyCorpCompanion.GameObjects.Abnormalities
{
    internal class Monk : Abnormality
    {
        public Monk()
        {
            Name = "Clouded Monk";
            DerivedName = "Amita";
            RiskLevel = RiskLevel.WAW;

            Weapon = new EgoWeapon(DerivedName,70, 1, [3, 0, 0, 0, 3], DamageType.RED, RiskLevel, 3, 4, 1, 1.0);

            Suit = new EgoSuit(DerivedName,50, 2, [0, 2, 2, 0, 0], RiskLevel, [0.5, 1.3, 0.7, 1.5]);

            Gift = new EgoGift(DerivedName, Slot.Hand_1, new SecondaryStats(HP:10,SP:-4));
        }
    }
}
