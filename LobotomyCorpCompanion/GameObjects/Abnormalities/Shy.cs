using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LobotomyCorpCompanion.GameObjects.Abnormalities
{
    internal class Shy : Abnormality
    {
        public Shy()
        {
            name = "Today's Shy look";
            derivedName = "Today's Expression";
            riskLevel = RiskLevel.TETH;

            weapon = new EgoWeapon(derivedName, 25, 2, [0, 0, 0, 0, 0], DamageType.BLACK, WeaponRange.Long, riskLevel, 2, 3, AttackSpeed.VeryFast);

            suit = new EgoSuit(derivedName, 30, 1, [2, 0, 0, 0, 0], riskLevel, [0.7, 0.6, 1.5, 2.0]);

            gift = new EgoGift(derivedName, Slot.Eye, [0,-2, 4, 4, 0, 0]);
        }
    }
}
