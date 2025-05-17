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
            Name = "Il Pianto della Luna";
            DerivedName = "Moonlight";
            RiskLevel = RiskLevel.WAW;

            Weapon = new EgoWeapon(DerivedName,70, 1, [3, 0, 0, 0, 0], DamageType.WHITE, RiskLevel, 8,10, 1, 1.0);

            Suit = new EgoSuit(DerivedName,60, 1, [0, 0, 3, 0, 0], RiskLevel, [0.8, 0.4, 0.7, 2.0]);

            Gift = new EgoGift(DerivedName, Slot.Brooch, new SecondaryStats(1, 1, 1, 1, 1, 1));
        }

        internal override void WeaponEffect(Employee employee)
        {
            employee.SpecialEffects.Add("Special Attack granting BLACK shields to employees in the room");
        }
    }
}
