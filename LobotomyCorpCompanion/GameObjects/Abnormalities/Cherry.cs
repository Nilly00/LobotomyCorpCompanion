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
            name = "Grave of Cherry Blossoms";
            derivedName = "Cherry Blossoms";
            riskLevel = RiskLevel.TETH;

            weapon = new EgoWeapon(derivedName, 25, 1, [0, 0, 0, 0, 0], DamageType.WHITE, WeaponRange.Medium, riskLevel, 1, 2, AttackSpeed.VeryFast);

            suit = new EgoSuit(derivedName, 30, 1, [0, 2, 0, 0, 0], riskLevel, [1.2, 0.6, 0.7, 2.0]);

            gift = new EgoGift(derivedName, Slot.Hat, [2, 0, 0, 0, 2, 2]);
        }

        public override void WeaponEffect(Employee employee)
        {
            employee.SpecialEffects.Add("Multihit!");
        }
    }
}
