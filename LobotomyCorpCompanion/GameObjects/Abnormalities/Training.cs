using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LobotomyCorpCompanion.GameObjects.Abnormalities
{
    internal class Training : Abnormality
    {
        public Training()
        {
            name = "Standard Training-Dummy Rabbit";
            derivedName = "Standard Training E.G.O";
            riskLevel = RiskLevel.TETH;

            weapon = new EgoWeapon(derivedName, 1, 5, [0, 0, 0, 0, 0], DamageType.WHITE, WeaponRange.Short, riskLevel, 5, 7, AttackSpeed.Normal);

            suit = new EgoSuit(derivedName, 1, 5, [0, 0, 0, 0, 0], riskLevel, [0.5, 1.0, 1.5, 2.0]);

            gift = new EgoGift(derivedName, Slot.Hat, [2, 2, 0, 0, 0, 0]);
        }
    }
}
