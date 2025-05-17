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
            Name = "Schadenfreude";
            DerivedName = "Gaze";
            RiskLevel = RiskLevel.HE;

            Weapon = new EgoWeapon(DerivedName, 45, 1, [0, 2, 2, 0, 0], DamageType.RED, RiskLevel, 1, 4, 4, 2.9);

            Suit = new EgoSuit(DerivedName, 30, 3, [0, 0, 0, 0, 0], RiskLevel, [1.0, 0.8, 1.0, 1.5]);

            Gift = new EgoGift(DerivedName, Slot.Hand_2, new SecondaryStats(HP:4));
        }

        internal override void WeaponEffect(Employee employee)
        {
            employee.SpecialEffects.Add("Hits 10 Times");
        }

        internal override void SuitEffect(Employee employee)
        {
            employee.SpecialEffects.Add("While on screen JUSTICE +10 base Defense becomes 0.8/0.5/0.8/1.5");
            employee.conditionalBoni.primaryStats.Justice += 10;
            //todo special calculation for defense in employee method
        }
    }
}
