using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LobotomyCorpCompanion.GameObjects.Abnormalities
{
    internal class WallLady : Abnormality
    {
        public WallLady()
        {
            name = "The Lady Facing the Wall";
            derivedName = "Screaming Wedge";
            riskLevel = RiskLevel.TETH;

            weapon = new EgoWeapon(derivedName, 35, 2, [0, 2, 0, 0, 0], DamageType.WHITE, WeaponRange.VeryLong, RiskLevel.HE, 7, 14, AttackSpeed.Normal);

            suit = new EgoSuit(derivedName, 30, 2, [0, 0, 0, 0, 0], riskLevel, [1.2, 0.6, 1.0, 2.0]);
        }

        public override void WeaponEffect(Employee employee)
        {
            if (employee.ranks[0] < 3 && employee.ranks[1] < 3) {
                employee.SpecialEffects.Add("50% chance to take 5 SP damage with each attack");
            }
        }
    }
}
