using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LobotomyCorpCompanion.GameObjects.Abnormalities
{
    internal class Beauty : Abnormality
    {
        public Beauty()
        {
            name = "Beauty and the Beast";
            derivedName = "Horn";
            riskLevel = RiskLevel.TETH;

            weapon = new EgoWeapon(derivedName, 30, 3, [0, 0, 0, 0, 0], DamageType.RED, WeaponRange.Medium, riskLevel, 5, 9, AttackSpeed.Fast);

            suit = new EgoSuit(derivedName, 30, 3, [0, 0, 0, 0, 0], riskLevel, [0.8, 0.8, 1.5, 2.0]);

            gift = new EgoGift(derivedName, Slot.Hat, [2, 2, 0, 0, 0, 0]);
        }
    }
}
