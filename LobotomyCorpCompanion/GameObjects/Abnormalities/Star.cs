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
            Name = "Blue Star";
            DerivedName = "Sound of a Star";
            RiskLevel = RiskLevel.ALEPH;

            Weapon = new EgoWeapon(DerivedName,222, 1, [0, 5, 5, 0, 5], DamageType.WHITE, RiskLevel, 8,12, 1, 1.0);

            Suit = new EgoSuit(DerivedName,150, 1, [0, 5, 5, 0, 5], RiskLevel, [0.4, 0.4, 0.4, 1.0]);

            Gift = new EgoGift(DerivedName, Slot.Eye, new SecondaryStats(MS:10));
        }

        internal override void WeaponEffect(Employee employee)
        {
            employee.SpecialEffects.Add("While above 30% SP deal an additional 9-16 Damage");
            employee.SpecialEffects.Add("While above 60% SP deal an additional 11-16 Damage");
        }

        internal override void SuitEffect(Employee employee)
        {
            employee.SpecialEffects.Add("+5 SP per second for all Employees in the Room");
        }
    }
}
