using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LobotomyCorpCompanion.GameObjects.Abnormalities
{
    internal class Butterflies : Abnormality
    {
        public Butterflies()
        {
            Name = "Funeral of the Dead Butterflies";
            DerivedName = "Solemn Lament";
            RiskLevel = RiskLevel.HE;

            Weapon = new EgoWeapon(DerivedName, 50, 1, [0, 0, 0, 3, 0], DamageType.BLACK_WHITE, RiskLevel, 2, 2, 10, 0.5);

            Suit = new EgoSuit(DerivedName, 45, 1, [0, 0, 0, 3, 0], RiskLevel, [1.2, 0.8, 0.5, 1.5]);

            Gift = new EgoGift(DerivedName, Slot.Right_back, new SecondaryStats(1, 1, 1, 1, 1, 1));
        }

        internal override void WeaponEffect(Employee employee)
        {
            employee.SpecialEffects.Add("Dual Weapon");
        }
    }
}
