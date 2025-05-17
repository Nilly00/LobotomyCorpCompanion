using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LobotomyCorpCompanion.GameObjects.Abnormalities
{
    internal class WallLady : Abnormality
    {
        public WallLady()
        {
            Name = "The Lady Facing the Wall";
            DerivedName = "Screaming Wedge";
            RiskLevel = RiskLevel.TETH;

            Weapon = new EgoWeapon(DerivedName, 35, 2, [0, 2, 0, 0, 0], DamageType.WHITE, RiskLevel.HE, 7, 14, 20, 2.0);

            Suit = new EgoSuit(DerivedName, 30, 2, [0, 0, 0, 0, 0], RiskLevel, [1.2, 0.6, 1.0, 2.0]);
        }

        internal override void WeaponEffect(Employee employee)
        {
            if (employee.ranks[0] < 3 && employee.ranks[1] < 3) {
                employee.SpecialEffects.Add("50% chance to take 5 SP damage with each attack");
            }
        }
    }
}
