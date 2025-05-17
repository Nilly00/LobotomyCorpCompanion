using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LobotomyCorpCompanion.GameObjects.Abnormalities
{
    internal class Training : Abnormality
    {
        public Training()
        {
            Name = "Standard Training-Dummy Rabbit";
            DerivedName = "Standard Training E.G.O";
            RiskLevel = RiskLevel.TETH;

            Weapon = new EgoWeapon(DerivedName, 1, 5, [0, 0, 0, 0, 0], DamageType.WHITE, RiskLevel, 5, 7, 4 ,1.0);

            Suit = new EgoSuit(DerivedName, 1, 5, [0, 0, 0, 0, 0], RiskLevel, [0.5, 1.0, 1.5, 2.0]);

            Gift = new EgoGift(DerivedName, Slot.Hat, new SecondaryStats(HP:2,SP:2));
        }
    }
}
