using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LobotomyCorpCompanion.GameObjects.Abnormalities
{
    internal class Forsaken : Abnormality
    {
        public Forsaken()
        {
            name = "Forsaken Murderer";
            derivedName = "Regret";
            riskLevel = RiskLevel.TETH;

            weapon = new EgoWeapon(derivedName, 25, 2, [0, 0, 0, 0, 0], DamageType.RED, WeaponRange.Long, riskLevel, 10, 15, AttackSpeed.Slow);

            suit = new EgoSuit(derivedName, 25, 2, [0, 0, 0, 0, 0], riskLevel, [0.7, 1.2, 0.8, 2.0]);

            gift = new EgoGift(derivedName, Slot.Mouth_1, [2, 2, 0, 0, 0, 0]);
        }
    }
}
