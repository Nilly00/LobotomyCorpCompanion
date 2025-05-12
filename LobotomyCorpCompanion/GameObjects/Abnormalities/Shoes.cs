using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LobotomyCorpCompanion.GameObjects.Abnormalities
{
    internal class Shoes : Abnormality
    {
        public Shoes()
        {
            name = "The Red Shoes";
            derivedName = "Sanguine Desire";
            riskLevel = RiskLevel.HE;

            weapon = new EgoWeapon(derivedName, 40, 2, [0, 0, 0, 0, 0], DamageType.RED, WeaponRange.VeryShort, riskLevel, 4, 7, AttackSpeed.VeryFast);

            suit = new EgoSuit(derivedName, 50, 1, [0, 0, 3, 0, 0], riskLevel, [0.5, 1.2, 0.8, 1.5]);

            gift = new EgoGift(derivedName, Slot.Mouth_2, [4, 0, 0, 0, 0, 0]);
        }

        public override void WeaponEffect(Employee employee)
        {
            if (employee.ranks[2] > 3)
            {
                employee.damageBoni += 4;
                employee.SpecialEffects.Add("take SP damage equal to 4% of Max. SP on each attack");
            }
        }

        public override void GiftEffect(Employee employee)
        {
            if (employee.weapon == this)
            {
                employee.secondaryStats[2] -= 10;
                employee.secondaryStats[3] -= 10;
                employee.secondaryStats[5] += 10;
            }
        }
    }
}
