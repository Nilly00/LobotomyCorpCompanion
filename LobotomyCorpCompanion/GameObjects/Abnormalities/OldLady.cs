using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LobotomyCorpCompanion.GameObjects.Abnormalities
{
    internal class OldLady : Abnormality
    {
        public OldLady()
        {
            name = "Old Lady";
            derivedName = "Solitude";
            riskLevel = RiskLevel.TETH;

            weapon = new EgoWeapon(derivedName, 30, 2, [0, 0, 0, 0, 0], DamageType.WHITE, WeaponRange.Long, riskLevel, 2, 3, AttackSpeed.VeryFast);

            suit = new EgoSuit(derivedName, 20, 3, [0, 0, 0, 0, 0], riskLevel, [1.5, 0.8, 0.8, 2.0]);

            gift = new EgoGift(derivedName, Slot.Eye, [0, 0, 3, 3, 0, 0]);
        }
    }
}
