using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LobotomyCorpCompanion.GameObjects.Abnormalities
{
    internal class Scorched : Abnormality
    {
        public Scorched()
        {
            name = "Scorched Girl";
            derivedName = "Fourth Match Flame";
            riskLevel = RiskLevel.TETH;

            weapon = new EgoWeapon(derivedName, 35, 1, [0, 0, 0, 0, 0], DamageType.RED, WeaponRange.VeryLong, riskLevel, 20, 30, AttackSpeed.VerySlow);

            suit = new EgoSuit(derivedName, 25, 2, [0, 0, 0, 0, 0], riskLevel, [0.6, 1.0, 1.2, 2.0]);

            gift = new EgoGift(derivedName, Slot.Mouth_2, [4, 0, 0, 0, 0, 0]);
        }
    }
}
