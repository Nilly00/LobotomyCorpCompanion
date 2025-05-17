using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LobotomyCorpCompanion.GameObjects.Abnormalities
{
    internal class Scarecrow : Abnormality
    {
        public Scarecrow()
        {
            Name = "Scarecrow Searching for Wisdom";
            DerivedName = "Harvest";
            RiskLevel = RiskLevel.HE;

            Weapon = new EgoWeapon(DerivedName, 45, 3, [0, 0, 0, 0, 0], DamageType.BLACK, RiskLevel, 6,12, 4, 1.5);

            Suit = new EgoSuit(DerivedName, 35, 2, [0, 2, 0, 0, 0], RiskLevel, [0.6, 0.8, 1.3, 1.5]);
        }
    }
}
