using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LobotomyCorpCompanion.GameObjects.Abnormalities
{
    internal class Big : Abnormality
    {
        public Big()
        {
            name = "Big Bird";
            derivedName = "Lamp";
            riskLevel = RiskLevel.WAW;

            weapon = new EgoWeapon(derivedName, 70, 1, [3, 3, 0, 0, 0], DamageType.BLACK, WeaponRange.Medium, riskLevel, 22, 28, AttackSpeed.Slow);

            suit = new EgoSuit(derivedName, 60, 1, [0, 0, 3, 3, 4], riskLevel, [0.8, 0.7, 0.4, 1.5]);
        }

        public override void WeaponEffect(Employee employee)
        {
            employee.SpecialEffects.Add("25% chance to make the target more vulnerable to BLACK damage");
        }

    }
}
