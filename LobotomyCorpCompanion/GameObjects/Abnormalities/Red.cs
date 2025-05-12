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
            name = "Litle Red Riding Hood";
            derivedName = "Crimson Scar";
            riskLevel = RiskLevel.WAW;

            weapon = new EgoWeapon(derivedName,70, 1, [3, 0, 0, 3, 0], DamageType.RED, WeaponRange.Short, riskLevel,11,13, AttackSpeed.Fast);

            suit = new EgoSuit(derivedName,60, 1, [3, 0, 0, 3, 4], riskLevel, [0.6, 0.6, 0.6, 1.5]);

            gift = new EgoGift(derivedName, Slot.Mouth_1, [3, 0, 0, 0, 3, 3]);
        }

        public override void WeaponEffect(Employee employee)
        {
            employee.SpecialEffects.Add("While below 50% HP +50% damage and FRIENDLY FIRE!");
        }

        public override void SuitEffect(Employee employee)
        {
            employee.SpecialEffects.Add("Movement Speed +30% when suppressing");
        }
    }
}
