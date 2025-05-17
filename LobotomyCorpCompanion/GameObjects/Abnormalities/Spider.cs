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
            Name = "Spider Bud";
            DerivedName = "Red Eyes";
            RiskLevel = RiskLevel.TETH;

            Weapon = new EgoWeapon(DerivedName, 20, 3, [0, 0, 0, 0, 0], DamageType.RED, RiskLevel, 7, 9, 3, 2.0);

            Suit = new EgoSuit(DerivedName, 30, 1, [2, 0, 0, 0, 0], RiskLevel, [0.8, 0.8, 0.8, 2.0]);

            Gift = new EgoGift(DerivedName, Slot.Eye, new SecondaryStats(SR:3,WS:3));
        }

        internal override void WeaponEffect(Employee employee)
        {
            if (employee.ranks[0] < 1)
            {
                employee.SpecialEffects.Add("+2.5 MS during supression or combat");
                employee.conditionalBoni.secondaryStats.MS += 2;
            }
        }

        internal override void SuitEffect(Employee employee)
        {
            if (employee.ranks[0] < 1)
            {
                if (employee.weapon==this)
                {
                    employee.SpecialEffects[0] = "+5 MS during supression or combat";
                    employee.conditionalBoni.secondaryStats.MS += 3;

                }
                else
                {
                    employee.SpecialEffects.Add("+2.5 MS during supression or combat");
                    employee.conditionalBoni.secondaryStats.MS += 2;
                }
            }
        }
    }
}
