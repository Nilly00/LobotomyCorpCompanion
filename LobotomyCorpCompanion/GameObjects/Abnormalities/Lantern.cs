using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LobotomyCorpCompanion.GameObjects.Abnormalities
{
    internal class Lantern : Abnormality
    {
        public Lantern()
        {
            name = "Meat Lantern";
            derivedName = "Lantern";
            riskLevel = RiskLevel.TETH;

            weapon = new EgoWeapon(derivedName, 25, 2, [0, 0, 0, 0, 0], DamageType.BLACK, WeaponRange.Medium, riskLevel, 12, 18, AttackSpeed.Slow);

            suit = new EgoSuit(derivedName, 30, 2, [0, 0, 0, 0, 0], riskLevel, [0.8, 0.7, 1.2, 2.0]);

            gift = new EgoGift(derivedName, Slot.Mouth_2, [5, 0, 0, 0, 0, 0]);
        }
    }
}
