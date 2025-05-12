using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LobotomyCorpCompanion.GameObjects.Abnormalities
{
    internal class Laetitia : Abnormality
    {
        public Laetitia()
        {
            name = "Laetitia";
            derivedName = "Laetitia";
            riskLevel = RiskLevel.HE;

            weapon = new EgoWeapon(derivedName, 40, 2, [0, 2, 0, 0, 0], DamageType.BLACK, WeaponRange.VeryLong, riskLevel, 5, 6, AttackSpeed.VeryFast);

            suit = new EgoSuit(derivedName, 45, 1, [0, 0, 0, 0, 3], riskLevel, [0.7, 0.7, 0.7, 1.5]);

            gift = new EgoGift(derivedName, Slot.Helmet, [0, 4, 0, 0, 0, 0]);
        }
    }
}
