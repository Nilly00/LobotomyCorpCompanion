using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LobotomyCorpCompanion.GameObjects.Abnormalities
{
    internal class Cute : Abnormality
    {
        public Cute()
        {
            name = "Ppodae";
            derivedName = "SO CUTE!!!";
            riskLevel = RiskLevel.TETH;

            weapon = new EgoWeapon(derivedName, 25, 2, [0, 0, 0, 0, 0], DamageType.RED, WeaponRange.VeryShort, riskLevel, 4, 6, AttackSpeed.Normal);

            suit = new EgoSuit(derivedName, 20, 3, [0, 0, 0, 0, 0], riskLevel, [0.8, 1.2, 0.8, 0.0]);

            gift = new EgoGift(derivedName, Slot.Hat, [4, 0, 2, 2, 0, 0]);
        }

        public override void WeaponEffect(Employee employee)
        {
            employee.SpecialEffects.Add("Dual Weapon");
        }
    }
}
