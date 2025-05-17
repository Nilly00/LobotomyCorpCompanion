using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LobotomyCorpCompanion.GameObjects.Abnormalities
{
    internal class Cherry : Abnormality
    {
        public Cherry()
        {
            Name = "Grave of Cherry Blossoms";
            DerivedName = "Cherry Blossoms";
            RiskLevel = RiskLevel.TETH;

            Weapon = new EgoWeapon(DerivedName, 25, 1, [0, 0, 0, 0, 0], DamageType.WHITE,RiskLevel, 1, 2,5 ,1.0);

            Suit = new EgoSuit(DerivedName, 30, 1, [0, 2, 0, 0, 0], RiskLevel, [1.2, 0.6, 0.7, 2.0]);

            Gift = new EgoGift(DerivedName, Slot.Hat, new SecondaryStats(HP:2,AS:2,MS:2));
        }

        internal override void WeaponEffect(Employee employee)
        {
            employee.SpecialEffects.Add("Multihit!");
        }
    }
}
