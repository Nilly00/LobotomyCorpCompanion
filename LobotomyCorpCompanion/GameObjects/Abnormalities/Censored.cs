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
            Name = "CENSORED";
            DerivedName = "CENSORED";
            RiskLevel = RiskLevel.ALEPH;

            Weapon = new EgoWeapon(DerivedName,222, 1, [5, 0, 0, 0, 5], DamageType.BLACK,RiskLevel,7,11, 1, 1.0);

            Gift = new EgoGift(DerivedName, Slot.Eye, new SecondaryStats(SP:10));
        }

        internal override void WeaponEffect(Employee employee)
        {
            employee.SpecialEffects.Add("Hits twice");
            employee.SpecialEffects.Add("10% chance to deal 15-30 damage 3 times");
            employee.SpecialEffects.Add("Recover 40% of damage taken when hit");
        }
    }
}
