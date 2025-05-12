using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LobotomyCorpCompanion.GameObjects.Abnormalities
{
    internal class Smiling : Abnormality
    {
        public Smiling()
        {
            name = "Mountain of Smiling Bodies";
            derivedName = "Smile";
            riskLevel = RiskLevel.ALEPH;

            weapon = new EgoWeapon(derivedName,222, 1, [0, 0, 5, 0, 5], DamageType.BLACK, WeaponRange.Medium, riskLevel, 12,18, AttackSpeed.Fast);

            suit = new EgoSuit(derivedName,120, 1, [0, 0, 5, 0, 5], riskLevel, [0.5, 0.5, 0.2, 1.0]);

            gift = new EgoGift(derivedName, Slot.Eye, [5, 5, 0, 0, 0, 0]);
        }

        public override void WeaponEffect(Employee employee)
        {
            employee.SpecialEffects.Add("Each time an attack target dies, Fortitude and Justice will rise by 3 up to 30");
            employee.SpecialEffects.Add("Decrease the target’s Movement Speed on normal attack");
            employee.SpecialEffects.Add("30% chance to deal 55-65 Damage AOE");
        }

        public override void SuitEffect(Employee employee)
        {
            employee.SpecialEffects.Add("Recover HP when passing over an employee's dead body");
        }
    }
}
