using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LobotomyCorpCompanion.GameObjects.Abnormalities
{
    internal class Nothing : Abnormality
    {
        public Nothing()
        {
            Name = "Nothing There";
            DerivedName = "Mimicry";
            RiskLevel = RiskLevel.ALEPH;

            Weapon = new EgoWeapon(DerivedName, 222, 1, [5, 0, 0, 0, 5], DamageType.RED, RiskLevel, 10, 14, 1, 1.0);

            Suit = new EgoSuit(DerivedName, 120, 1, [5, 0, 0, 0, 5], RiskLevel, [0.2, 0.5, 0.5, 1.0]);

            Gift = new EgoGift(DerivedName, Slot.Mouth_2, new SecondaryStats(HP: 10));
        }

        internal override void WeaponEffect(Employee employee)
        {
            employee.SpecialEffects.Add("Recover 25% of damage dealt to the target as HP");
        }

        internal override void GiftEffect(Employee employee)
        {
                    
        }
    }
}
