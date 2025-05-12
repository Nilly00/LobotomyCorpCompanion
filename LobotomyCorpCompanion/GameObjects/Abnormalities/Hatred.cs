using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LobotomyCorpCompanion.GameObjects.Abnormalities
{
    internal class Hatred : Abnormality
    {
        public Hatred()
        {
            name = "The Queen of Hatred";
            derivedName = "In the Name of Love and Hate";
            riskLevel = RiskLevel.WAW;

            weapon = new EgoWeapon(derivedName, 70, 1, [3, 0, 0, 3, 4], DamageType.HEALING, WeaponRange.VeryLong, riskLevel, 5, 8, AttackSpeed.VeryFast);

            suit = new EgoSuit(derivedName, 60, 1, [0, 3, 3, 0, 4], riskLevel, [0.7, 0.8, 0.4, 2.0]);

            gift = new EgoGift(derivedName, Slot.Hat, [0, 0, 2, 2, 4, 4]);
        }

        public override void WeaponEffect(Employee employee)
        {
            employee.SpecialEffects.Add("Heals other Employees instead of attacking Monsters");
        }
    }
}
