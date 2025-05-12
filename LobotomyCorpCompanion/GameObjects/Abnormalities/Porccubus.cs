using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LobotomyCorpCompanion.GameObjects.Abnormalities
{
    internal class Porccubus : Abnormality
    {
        public Porccubus()
        {
            name = "Porccubus";
            derivedName = "Pleasure";
            riskLevel = RiskLevel.HE;

            weapon = new EgoWeapon(derivedName, 45, 1, [0, 0, 3, 0, 0], DamageType.BLACK, WeaponRange.Medium, riskLevel, 1, 4, AttackSpeed.Fast);

            suit = new EgoSuit(derivedName, 30, 3, [0, 0, 0, 0, 0], riskLevel, [1.2, 0.8, 0.8, 1.5]);

            gift = new EgoGift(derivedName, Slot.Neckwear, [0,10,-6,-6, 0, 0]);
        }

        public override void WeaponEffect(Employee employee)
        {
            employee.SpecialEffects.Add("Deals 2 WHITE damage per second over 5 Seconds");
        }
    }
}
