using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LobotomyCorpCompanion.GameObjects.Abnormalities
{
    internal class Red : Abnormality
    {
        public Red()
        {
            Name = "Litle Red Riding Hood";
            DerivedName = "Crimson Scar";
            RiskLevel = RiskLevel.WAW;

            Weapon = new EgoWeapon(DerivedName,70, 1, [3, 0, 0, 3, 0], DamageType.RED, RiskLevel,11,13, 1, 1.0);

            Suit = new EgoSuit(DerivedName,60, 1, [3, 0, 0, 3, 4], RiskLevel, [0.6, 0.6, 0.6, 1.5]);

            Gift = new EgoGift(DerivedName, Slot.Mouth_1, new SecondaryStats(HP:3,AS:3,WS:3));
        }

        internal override void WeaponEffect(Employee employee)
        {
            employee.SpecialEffects.Add("While below 50% HP +50% damage and FRIENDLY FIRE!");
            employee.conditionalBoni.damagePercent *= 1.5;
        }

        internal override void SuitEffect(Employee employee)
        {
            employee.SpecialEffects.Add("Movement Speed +30% when suppressing");
            employee.conditionalBoni.movespeedPercent *= 1.3;
        }
    }
}
