using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LobotomyCorpCompanion.GameObjects.Abnormalities
{
    internal class Dream : Abnormality
    {
        public Dream()
        {
            name = "Void Dream";
            derivedName = "Engulfing Dream";
            riskLevel = RiskLevel.TETH;

            weapon = new EgoWeapon(derivedName, 25, 2, [0, 0, 0, 0, 0], DamageType.WHITE, WeaponRange.Medium, riskLevel, 1, 2, AttackSpeed.VeryFast);

            suit = new EgoSuit(derivedName, 25, 2, [0, 0, 0, 0, 0], riskLevel, [1.2, 0.8, 0.7, 2.0]);

            gift = new EgoGift(derivedName, Slot.Hat, [0, 4, 0, 0, 0, 0]);
        }
    }
}