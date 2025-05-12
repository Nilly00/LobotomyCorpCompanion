using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LobotomyCorpCompanion.GameObjects.Abnormalities
{
    internal class Swan : Abnormality
    {
        public Swan()
        {
            name = "Dream of a Black Swan";
            derivedName = "Black Swan";
            riskLevel = RiskLevel.WAW;

            weapon = new EgoWeapon(derivedName, 60, 2, [0, 3, 0, 0, 0], DamageType.BLACK, WeaponRange.Short, riskLevel, 5, 7, AttackSpeed.Fast);

            suit = new EgoSuit(derivedName, 50, 2, [0, 0, 3, 0, 0], riskLevel, [0.6, 1.2, 0.8, 1.5]);
        }

        public override void WeaponEffect(Employee employee)
        {
            employee.SpecialEffects.Add("Chance to reflect damage taken");
        }
    }
}