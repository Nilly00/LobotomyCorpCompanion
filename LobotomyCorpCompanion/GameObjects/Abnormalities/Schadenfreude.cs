using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LobotomyCorpCompanion.GameObjects.Abnormalities
{
    internal class Schadenfreude : Abnormality
    {
        public Schadenfreude()
        {
            name = "Schadenfreude";
            derivedName = "Gaze";
            riskLevel = RiskLevel.HE;

            weapon = new EgoWeapon(derivedName, 45, 1, [0, 2, 2, 0, 0], DamageType.RED, WeaponRange.Medium, riskLevel, 1, 4, AttackSpeed.Normal);

            suit = new EgoSuit(derivedName, 30, 3, [0, 0, 0, 0, 0], riskLevel, [1.0, 0.8, 1.0, 1.5]);

            gift = new EgoGift(derivedName, Slot.Hand_2, [4, 0, 0, 0, 0, 0]);
        }

        public override void WeaponEffect(Employee employee)
        {
            employee.SpecialEffects.Add("Hits 10 Times");
        }

        public override void SuitEffect(Employee employee)
        {
            employee.SpecialEffects.Add("While on screen JUSTICE +10 base Defense becomes 0.8/0.5/0.8/1.5");
        }
    }
}
