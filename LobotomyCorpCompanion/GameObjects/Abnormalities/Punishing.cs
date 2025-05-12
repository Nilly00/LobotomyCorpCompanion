using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LobotomyCorpCompanion.GameObjects.Abnormalities
{
    internal class Punishing : Abnormality
    {
        public Punishing()
        {
            name = "Punishing Bird";
            derivedName = "Beak";
            riskLevel = RiskLevel.TETH;

            weapon = new EgoWeapon(derivedName, 30, 2, [0, 0, 0, 0, 0], DamageType.RED, WeaponRange.Long, riskLevel, 2, 3, AttackSpeed.VeryFast);

            suit = new EgoSuit(derivedName, 25, 2, [0, 0, 0, 0, 0], riskLevel, [0.7, 0.8, 1.2, 2.0]);

            gift = new EgoGift(derivedName, Slot.Neckwear, [0, 0, 0, 0, 2, 2]);
        }
    }
}
