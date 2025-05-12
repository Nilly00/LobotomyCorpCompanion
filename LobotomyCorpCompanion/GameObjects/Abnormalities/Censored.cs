using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LobotomyCorpCompanion.GameObjects.Abnormalities
{
    internal class Censored : Abnormality
    {
        public Censored()
        {
            name = "CENSORED";
            derivedName = "CENSORED";
            riskLevel = RiskLevel.ALEPH;

            weapon = new EgoWeapon(derivedName,222, 1, [5, 0, 0, 0, 5], DamageType.BLACK, WeaponRange.Short, riskLevel,7,11, AttackSpeed.Fast);

            gift = new EgoGift(derivedName, Slot.Eye, [0,10, 0, 0, 0, 0]);
        }

        public override void WeaponEffect(Employee employee)
        {
            employee.SpecialEffects.Add("Hits twice");
            employee.SpecialEffects.Add("10% chance to deal 15-30 damage 3 times");
            employee.SpecialEffects.Add("Recover 40% of damage taken when hit");
        }
    }
}
