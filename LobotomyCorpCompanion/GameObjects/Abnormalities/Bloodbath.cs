using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LobotomyCorpCompanion.GameObjects.Abnormalities
{
    internal class Bloodbath : Abnormality
    {
        public Bloodbath()
        {
            name = "Bloodbath";
            derivedName = "Wrist Cutter";
            riskLevel = RiskLevel.TETH;

            weapon = new EgoWeapon(derivedName, 25, 2, [0, 0, 0, 0, 0], DamageType.WHITE, WeaponRange.VeryShort, riskLevel, 2, 3, AttackSpeed.VeryFast);

            suit = new EgoSuit(derivedName, 25, 2, [0, 0, 0, 0, 0], riskLevel, [1.0, 0.6, 1.2, 2.0]);

            gift = new EgoGift(derivedName, Slot.Hand_2, [0, 0, 2, 2, 0, 0]);
        }
    }
}
