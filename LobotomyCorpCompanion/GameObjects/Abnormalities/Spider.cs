using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LobotomyCorpCompanion.GameObjects.Abnormalities
{
    internal class Spider : Abnormality
    {
        public Spider()
        {
            name = "Spider Bud";
            derivedName = "Red Eyes";
            riskLevel = RiskLevel.TETH;

            weapon = new EgoWeapon(derivedName, 20, 3, [0, 0, 0, 0, 0], DamageType.RED, WeaponRange.Short, riskLevel, 7, 9, AttackSpeed.Normal);

            suit = new EgoSuit(derivedName, 30, 1, [2, 0, 0, 0, 0], riskLevel, [0.8, 0.8, 0.8, 2.0]);

            gift = new EgoGift(derivedName, Slot.Eye, [0, 0, 3, 3, 0, 0]);
        }

        public override void WeaponEffect(Employee employee)
        {
            if (employee.ranks[0] < 1)
            {
                employee.SpecialEffects.Add("+2.5 MS during supression or combat");
            }
        }

        public override void SuitEffect(Employee employee)
        {
            if (employee.ranks[0] < 1)
            {
                if (employee.weapon==this)
                {
                    employee.SpecialEffects[0] = "+5 MS during supression or combat";
                }
                else
                {
                    employee.SpecialEffects.Add("+2.5 MS during supression or combat");
                }
            }
        }
    }
}
