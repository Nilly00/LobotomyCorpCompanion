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
            Name = "You're Bald...";
            DerivedName = "Tough";
            RiskLevel = RiskLevel.ZAYIN;

            Weapon = new EgoWeapon(DerivedName, 15, 3, [0, 0, 0, 0, 0], DamageType.WHITE, RiskLevel.TETH, 2, 4, 10, 0.7);

            Suit = new EgoSuit(DerivedName, 10, 5, [0, 0, 0, 0, 0], RiskLevel, [1.0, 1.0, 0.8, 2.0]);

            Gift = new EgoGift(DerivedName, Slot.Eye, new SecondaryStats(AS:2, MS:2));
        }

        internal override void WeaponEffect(Employee employee)
        {
            employee.SpecialEffects.Add("Employee Must be Bald");
        }

        internal override void SuitEffect(Employee employee)
        {
            if (employee.SpecialEffects[0] != "Employee Must be Bald")
            {
                employee.SpecialEffects.Add("Employee Must be Bald");
            }
        }
    }
}
