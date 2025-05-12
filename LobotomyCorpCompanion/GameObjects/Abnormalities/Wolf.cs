using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LobotomyCorpCompanion.GameObjects.Abnormalities
{
    internal class Wolf : Abnormality
    {
        public Wolf()
        {
            name = "The Big and Will be Bad Wolf";
            derivedName = "Cobalt Scar";
            riskLevel = RiskLevel.WAW;

            weapon = new EgoWeapon(derivedName, 70, 1, [3, 0, 3, 0, 3], DamageType.RED, WeaponRange.Short, riskLevel, 12, 17, AttackSpeed.Fast);

            suit = new EgoSuit(derivedName, 60, 1, [4, 0, 0, 0, 4], riskLevel, [0.4, 0.8, 0.7, 2.0]);

            gift = new EgoGift(derivedName, Slot.Face, [4, 0, 0, 0, 2, 2]);
        }

        public override void WeaponEffect(Employee employee)
        {
            employee.SpecialEffects.Add("Deals DOT");
            employee.SpecialEffects.Add("While below 50% HP +50% damage and FRIENDLY FIRE!");
        }
    }
}
