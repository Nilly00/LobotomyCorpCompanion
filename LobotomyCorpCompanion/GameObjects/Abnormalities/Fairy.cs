using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LobotomyCorpCompanion.GameObjects.Abnormalities
{
    internal class Fairy : Abnormality
    {
        public Fairy()
        {
            Name = "Fairy Festival";
            DerivedName = "Wingbeat";
            RiskLevel = RiskLevel.ZAYIN;

            Weapon = new EgoWeapon(DerivedName, 10, 5, [0, 0, 0, 0, 0], DamageType.RED, RiskLevel, 5, 7, 3, 2.0);
            
            Suit = new EgoSuit(DerivedName, 10, 5, [0, 0, 0, 0, 0], RiskLevel, [0.8, 0.8, 1.0, 2.0]);

            Gift = new EgoGift(DerivedName, Slot.Hand_2, new SecondaryStats(SR:2,WS:2));
        }
    }
}
