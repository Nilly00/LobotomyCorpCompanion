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
            Name = "The Naked Nest";
            DerivedName = "Exuviae";
            RiskLevel = RiskLevel.WAW;

            Weapon = new EgoWeapon(DerivedName,60, 2, [0, 0, 0, 0, 4], DamageType.RED, RiskLevel,35,50, 1, 1.0);

            Suit = new EgoSuit(DerivedName,50, 2, [0, 0, 0, 0, 3], RiskLevel, [0.6, 0.8, 1.2, 1.5]);

            Gift = new EgoGift(DerivedName, Slot.Hand_2, new SecondaryStats(HP:5,SP:2));
        }

        internal override void WeaponEffect(Employee employee)
        {
            employee.SpecialEffects.Add("25% chance to make the target more vulnerable to RED damage");
        }
    }
}
