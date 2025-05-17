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
            Name = "Mountain of Smiling Bodies";
            DerivedName = "Smile";
            RiskLevel = RiskLevel.ALEPH;

            Weapon = new EgoWeapon(DerivedName,222, 1, [0, 0, 5, 0, 5], DamageType.BLACK, RiskLevel, 12,18, 1, 1.0);

            Suit = new EgoSuit(DerivedName,120, 1, [0, 0, 5, 0, 5], RiskLevel, [0.5, 0.5, 0.2, 1.0]);

            Gift = new EgoGift(DerivedName, Slot.Eye, new SecondaryStats(HP: 5, SP: 5));
        }

        internal override void WeaponEffect(Employee employee)
        {
            employee.SpecialEffects.Add("Each time an attack target dies, Fortitude and Justice will rise by 3 up to 30");
            employee.conditionalBoni.primaryStats.Fortitude += 30;
            employee.conditionalBoni.primaryStats.Justice += 30;
            employee.SpecialEffects.Add("Decrease the target’s Movement Speed on normal attack");
            employee.SpecialEffects.Add("30% chance to deal 55-65 Damage AOE");
        }

        internal override void SuitEffect(Employee employee)
        {
            employee.SpecialEffects.Add("Recover HP when passing over an employee's dead body");
        }
    }
}
