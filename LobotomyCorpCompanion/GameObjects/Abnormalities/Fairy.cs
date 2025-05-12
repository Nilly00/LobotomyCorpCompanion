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
            name = "Fairy Festival";
            derivedName = "Wingbeat";
            riskLevel = RiskLevel.ZAYIN;

            weapon = new EgoWeapon(derivedName, 10, 5, [0, 0, 0, 0, 0], DamageType.RED, WeaponRange.Short, riskLevel, 5, 7, AttackSpeed.Normal);

            suit = new EgoSuit(derivedName, 10, 5, [0, 0, 0, 0, 0], riskLevel, [0.8, 0.8, 1.0, 2.0]);

            gift = new EgoGift(derivedName, Slot.Hand_2, [0, 0, 2, 2, 0, 0]);
        }
    }
}
