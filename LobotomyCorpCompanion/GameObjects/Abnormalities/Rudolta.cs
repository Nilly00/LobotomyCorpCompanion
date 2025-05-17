using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LobotomyCorpCompanion.GameObjects.Abnormalities
{
    internal class Rudolta : Abnormality
    {
        public Rudolta()
        {
            Name = "Rudolta of the Sleigh";
            DerivedName = "Christmas";
            RiskLevel = RiskLevel.HE;

            Weapon = new EgoWeapon(DerivedName, 35, 3, [0, 0, 0, 0, 0], DamageType.WHITE, RiskLevel, 11, 13, 1, 1.0);

            Suit = new EgoSuit(DerivedName, 40, 3, [2, 0, 0, 0, 0], RiskLevel, [0.8, 0.6, 1.3, 1.5]);

            Gift = new EgoGift(DerivedName, Slot.Hat, new SecondaryStats(HP:-4,SP:8));
        }
    }
}
