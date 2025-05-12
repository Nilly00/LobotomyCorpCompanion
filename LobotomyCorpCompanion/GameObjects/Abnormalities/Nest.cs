using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LobotomyCorpCompanion.GameObjects.Abnormalities
{
    internal class Nest : Abnormality
    {
        public Nest()
        {
            name = "The Naked Nest";
            derivedName = "Exuviae";
            riskLevel = RiskLevel.WAW;

            weapon = new EgoWeapon(derivedName,60, 2, [0, 0, 0, 0, 4], DamageType.RED, WeaponRange.Long, riskLevel,35,50, AttackSpeed.VerySlow);

            suit = new EgoSuit(derivedName,50, 2, [0, 0, 0, 0, 3], riskLevel, [0.6, 0.8, 1.2, 1.5]);

            gift = new EgoGift(derivedName, Slot.Hand_2, [5, 2, 0, 0, 0, 0]);
        }

        public override void WeaponEffect(Employee employee)
        {
            employee.SpecialEffects.Add("25% chance to make the target more vulnerable to RED damage");
        }
    }
}
