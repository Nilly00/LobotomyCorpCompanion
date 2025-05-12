using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LobotomyCorpCompanion.GameObjects.Abnormalities
{
    internal class Butterflies : Abnormality
    {
        public Butterflies()
        {
            name = "Funeral of the Dead Butterflies";
            derivedName = "Solemn Lament";
            riskLevel = RiskLevel.HE;

            weapon = new EgoWeapon(derivedName, 50, 1, [0, 0, 0, 3, 0], DamageType.BLACK_WHITE, WeaponRange.Long, riskLevel, 2, 2, AttackSpeed.VeryFast);

            suit = new EgoSuit(derivedName, 45, 1, [0, 0, 0, 3, 0], riskLevel, [1.2, 0.8, 0.5, 1.5]);

            gift = new EgoGift(derivedName, Slot.Right_back, [1, 1, 1, 1, 1, 1]);
        }

        public override void WeaponEffect(Employee employee)
        {
            employee.SpecialEffects.Add("Dual Weapon");
        }
    }
}
