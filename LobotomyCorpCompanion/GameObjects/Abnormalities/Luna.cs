using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LobotomyCorpCompanion.GameObjects.Abnormalities
{
    internal class Luna : Abnormality
    {
        public Luna()
        {
            name = "Il Pianto della Luna";
            derivedName = "Moonlight";
            riskLevel = RiskLevel.WAW;

            weapon = new EgoWeapon(derivedName,70, 1, [3, 0, 0, 0, 0], DamageType.WHITE, WeaponRange.Short, riskLevel, 8,10, AttackSpeed.Fast);

            suit = new EgoSuit(derivedName,60, 1, [0, 0, 3, 0, 0], riskLevel, [0.8, 0.4, 0.7, 2.0]);

            gift = new EgoGift(derivedName, Slot.Brooch, [1, 1, 1, 1, 1, 1]);
        }

        public override void WeaponEffect(Employee employee)
        {
            employee.SpecialEffects.Add("Special Attack granting BLACK shields to employees in the room");
        }
    }
}
