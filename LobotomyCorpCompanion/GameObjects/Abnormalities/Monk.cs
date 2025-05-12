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
            name = "Clouded Monk";
            derivedName = "Amita";
            riskLevel = RiskLevel.WAW;

            weapon = new EgoWeapon(derivedName,70, 1, [3, 0, 0, 0, 3], DamageType.RED, WeaponRange.Medium, riskLevel, 3, 4, AttackSpeed.Fast);

            suit = new EgoSuit(derivedName,50, 2, [0, 2, 2, 0, 0], riskLevel, [0.5, 1.3, 0.7, 1.5]);

            gift = new EgoGift(derivedName, Slot.Hand_1, [10,-4, 0, 0, 0, 0]);
        }
    }
}
