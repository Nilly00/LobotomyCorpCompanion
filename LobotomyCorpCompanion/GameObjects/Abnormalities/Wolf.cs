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
            Name = "The Big and Will be Bad Wolf";
            DerivedName = "Cobalt Scar";
            RiskLevel = RiskLevel.WAW;

            Weapon = new EgoWeapon(DerivedName, 70, 1, [3, 0, 3, 0, 3], DamageType.RED, RiskLevel, 12, 17, 3 ,1.8);

            Suit = new EgoSuit(DerivedName, 60, 1, [4, 0, 0, 0, 4], RiskLevel, [0.4, 0.8, 0.7, 2.0]);

            Gift = new EgoGift(DerivedName, Slot.Face, new SecondaryStats(HP:4,AS:2,MS:2));
        }

        internal override void WeaponEffect(Employee employee)
        {
            employee.SpecialEffects.Add("Deals DOT");
            employee.SpecialEffects.Add("While below 50% HP +50% damage and FRIENDLY FIRE!");
            employee.conditionalBoni.damagePercent *= 1.5;
        }
    }
}
