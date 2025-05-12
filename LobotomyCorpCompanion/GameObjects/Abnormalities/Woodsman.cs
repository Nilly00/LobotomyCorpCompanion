using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LobotomyCorpCompanion.GameObjects.Abnormalities
{
    internal class Woodsman : Abnormality
    {
        public Woodsman()
        {
            name = "Warm-hearted Woodsman";
            derivedName = "Logging";
            riskLevel = RiskLevel.HE;

            weapon = new EgoWeapon(derivedName, 60, 2, [0, 2, 0, 0, 0], DamageType.RED, WeaponRange.Medium, riskLevel, 15, 21, AttackSpeed.Slow);

            suit = new EgoSuit(derivedName, 30, 3, [0, 0, 0, 0, 0], riskLevel, [0.8, 1.2, 0.8, 1.5]);

            gift = new EgoGift(derivedName, Slot.Brooch, [2, 0, 2, 2, 0, 0]);
        }
    }
}
