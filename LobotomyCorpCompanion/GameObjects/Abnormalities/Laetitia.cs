using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LobotomyCorpCompanion.GameObjects.Abnormalities
{
    internal class Laetitia : Abnormality
    {
        public Laetitia()
        {
            Name = "Laetitia";
            DerivedName = "Laetitia";
            RiskLevel = RiskLevel.HE;

            Weapon = new EgoWeapon(DerivedName, 40, 2, [0, 2, 0, 0, 0], DamageType.BLACK, RiskLevel, 5, 6, 1, 1.0);

            Suit = new EgoSuit(DerivedName, 45, 1, [0, 0, 0, 0, 3], RiskLevel, [0.7, 0.7, 0.7, 1.5]);

            Gift = new EgoGift(DerivedName, Slot.Helmet, new SecondaryStats(SP:4));
        }
    }
}
