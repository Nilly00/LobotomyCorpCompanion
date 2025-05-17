using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LobotomyCorpCompanion.GameObjects.Abnormalities
{
    internal class Hatred : Abnormality
    {
        public Hatred()
        {
            Name = "The Queen of Hatred";
            DerivedName = "In the Name of Love and Hate";
            RiskLevel = RiskLevel.WAW;

            Weapon = new EgoWeapon(DerivedName, 70, 1, [3, 0, 0, 3, 4], DamageType.HEALING, RiskLevel, 5, 8, 1, 1.0);

            Suit = new EgoSuit(DerivedName, 60, 1, [0, 3, 3, 0, 4], RiskLevel, [0.7, 0.8, 0.4, 2.0]);

            Gift = new EgoGift(DerivedName, Slot.Hat, new SecondaryStats(SR:2,WS:2,AS:4,MS:4));
        }

        internal override void WeaponEffect(Employee employee)
        {
            employee.SpecialEffects.Add("Heals other Employees instead of attacking Monsters");
        }
    }
}
