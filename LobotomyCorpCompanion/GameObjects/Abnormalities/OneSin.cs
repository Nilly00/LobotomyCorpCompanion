using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LobotomyCorpCompanion.GameObjects.Abnormalities
{
    internal class OneSin : Abnormality
    {
        public OneSin()
        {
            name = "One Sin and Hundreds of Good Deeds";
            derivedName = "Penitence";
            riskLevel = RiskLevel.ZAYIN;

            weapon = new EgoWeapon(derivedName, 15 , 5, [0, 0, 0, 0, 0], DamageType.WHITE, WeaponRange.Short, riskLevel, 5, 7, AttackSpeed.Normal);

            suit = new EgoSuit(derivedName, 10, 5,[0, 0, 0, 0, 0], riskLevel, [0.9, 0.8, 0.9, 2.0]);

            gift = new EgoGift(derivedName, Slot.Hat, [0, 2, 0, 0, 0, 0]);
        }

        public override void WeaponEffect(Employee employee)
        {
            if (employee.ranks[3] > 2)
            {
                employee.SpecialEffects.Add("5% chance to recover 10 SP on attack");
            }
        }

        public override void SuitEffect(Employee employee)
        {
            employee.SpecialEffects.Add("Heal SP +10 with a 5% chance upon receiving RED or BLACK damage");
        }

        public override void GiftEffect(Employee employee)
        {
            employee.SpecialEffects.Add("Work Success Rate +10% with One Sin");
        }
    }
}
