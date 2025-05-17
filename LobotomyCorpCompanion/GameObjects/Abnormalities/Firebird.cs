using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LobotomyCorpCompanion.GameObjects.Abnormalities
{
    internal class Firebird : Abnormality
    {
        public Firebird()
        {
            Name = "The Firebird";
            DerivedName = "Feather of Honor";
            RiskLevel = RiskLevel.WAW;

            Weapon = new EgoWeapon(DerivedName, 0, 3, [3, 0, 0, 0, 0], DamageType.WHITE, RiskLevel, 4, 5, 1, 1.0);

            Suit = new EgoSuit(DerivedName,50, 2, [3, 0, 0, 0, 3], RiskLevel, [0.6, 0.6, 1.3, 2.0]);

            Gift = new EgoGift(DerivedName, Slot.Hat, new SecondaryStats(SP:2,AS:4,MS:4));
        }
    }
}
