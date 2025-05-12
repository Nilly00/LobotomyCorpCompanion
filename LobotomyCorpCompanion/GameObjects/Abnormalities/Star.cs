using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LobotomyCorpCompanion.GameObjects.Abnormalities
{
    internal class Star : Abnormality
    {
        public Star()
        {
            name = "Blue Star";
            derivedName = "Sound of a Star";
            riskLevel = RiskLevel.ALEPH;

            weapon = new EgoWeapon(derivedName,222, 1, [0, 5, 5, 0, 5], DamageType.WHITE, WeaponRange.VeryLong, riskLevel, 8,12, AttackSpeed.Fast);

            suit = new EgoSuit(derivedName,150, 1, [0, 5, 5, 0, 5], riskLevel, [0.4, 0.4, 0.4, 1.0]);

            gift = new EgoGift(derivedName, Slot.Eye, [0, 0, 0, 0, 0,10]);
        }

        public override void WeaponEffect(Employee employee)
        {
            employee.SpecialEffects.Add("While above 30% SP deal an additional 9-16 Damage");
            employee.SpecialEffects.Add("While above 60% SP deal an additional 11-16 Damage");
        }

        public override void SuitEffect(Employee employee)
        {
            employee.SpecialEffects.Add("+5 SP per second for all Employees in the Room");
        }
    }
}
