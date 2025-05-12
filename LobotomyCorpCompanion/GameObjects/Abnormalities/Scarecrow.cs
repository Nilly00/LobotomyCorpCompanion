using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LobotomyCorpCompanion.GameObjects.Abnormalities
{
    internal class Scarecrow : Abnormality
    {
        public Scarecrow()
        {
            name = "Scarecrow Searching for Wisdom";
            derivedName = "Harvest";
            riskLevel = RiskLevel.HE;

            weapon = new EgoWeapon(derivedName, 45, 3, [0, 0, 0, 0, 0], DamageType.BLACK, WeaponRange.Medium, riskLevel, 6,12, AttackSpeed.Fast);

            suit = new EgoSuit(derivedName, 35, 2, [0, 2, 0, 0, 0], riskLevel, [0.6, 0.8, 1.3, 1.5]);
        }
    }
}
