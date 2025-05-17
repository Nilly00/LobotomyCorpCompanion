using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LobotomyCorpCompanion.GameObjects.Abnormalities
{
    internal class Swan : Abnormality
    {
        public Swan()
        {
            Name = "Dream of a Black Swan";
            DerivedName = "Black Swan";
            RiskLevel = RiskLevel.WAW;

            Weapon = new EgoWeapon(DerivedName, 60, 2, [0, 3, 0, 0, 0], DamageType.BLACK, RiskLevel, 5, 7, 3, 1.6);

            Suit = new EgoSuit(DerivedName, 50, 2, [0, 0, 3, 0, 0], RiskLevel, [0.6, 1.2, 0.8, 1.5]);
        }

        internal override void WeaponEffect(Employee employee)
        {
            employee.SpecialEffects.Add("Chance to reflect damage taken");
        }
    }
}