using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LobotomyCorpCompanion.GameObjects.Abnormalities
{
    internal class Bald : Abnormality
    {
        public Bald()
        {
            name = "You're Bald...";
            derivedName = "Tough";
            riskLevel = RiskLevel.ZAYIN;

            weapon = new EgoWeapon(derivedName, 15, 3, [0, 0, 0, 0, 0], DamageType.WHITE, WeaponRange.Long, RiskLevel.TETH, 2, 4, AttackSpeed.VeryFast);

            suit = new EgoSuit(derivedName, 10, 5, [0, 0, 0, 0, 0], riskLevel, [1.0, 1.0, 0.8, 2.0]);

            gift = new EgoGift(derivedName, Slot.Eye, [0, 0, 0, 0, 2, 2]);
        }

        public override void WeaponEffect(Employee employee)
        {
            employee.SpecialEffects.Add("Employee Must be Bald");
        }

        public override void SuitEffect(Employee employee)
        {
            if (employee.SpecialEffects[0] != "Employee Must be Bald")
            {
                employee.SpecialEffects.Add("Employee Must be Bald");
            }
        }
    }
}
