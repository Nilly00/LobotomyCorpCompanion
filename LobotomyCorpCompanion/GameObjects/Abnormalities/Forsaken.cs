using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LobotomyCorpCompanion.GameObjects.Abnormalities
{
    internal class Forsaken : Abnormality
    {
        public Forsaken()
        {
            Name = "Forsaken Murderer";
            DerivedName = "Regret";
            RiskLevel = RiskLevel.TETH;

            Weapon = new EgoWeapon(DerivedName, 25, 2, [0, 0, 0, 0, 0], DamageType.RED, RiskLevel, 10, 15, 5, 3.0);

            Suit = new EgoSuit(DerivedName, 25, 2, [0, 0, 0, 0, 0], RiskLevel, [0.7, 1.2, 0.8, 2.0]);

            Gift = new EgoGift(DerivedName, Slot.Mouth_1, new SecondaryStats(HP:2,SP:2));
        }
    }
}
