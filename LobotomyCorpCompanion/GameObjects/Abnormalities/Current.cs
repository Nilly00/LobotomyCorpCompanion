using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LobotomyCorpCompanion.GameObjects.Abnormalities
{
    internal class Current : Abnormality
    {
        public Current()
        {
            name = "The Dreaming Current";
            derivedName = "Ecstasy";
            riskLevel = RiskLevel.WAW;

            weapon = new EgoWeapon(derivedName, 60, 2, [2, 0, 0, 0, 3], DamageType.WHITE, WeaponRange.Long, riskLevel, 2, 4, AttackSpeed.Fast);

            suit = new EgoSuit(derivedName, 40, 3, [0, 0, 2, 0, 2], riskLevel, [0.8, 0.8, 0.8, 1.5]);

            gift = new EgoGift(derivedName, Slot.Mouth_2, [0, 6, 0, 0, 0, 0]);
        }
    }
}