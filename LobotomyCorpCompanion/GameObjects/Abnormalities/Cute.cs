using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LobotomyCorpCompanion.GameObjects.Abnormalities
{
    internal class Cute : Abnormality
    {
        public Cute()
        {
            Name = "Ppodae";
            DerivedName = "SO CUTE!!!";
            RiskLevel = RiskLevel.TETH;

            Weapon = new EgoWeapon(DerivedName, 25, 2, [0, 0, 0, 0, 0], DamageType.RED, RiskLevel, 4, 6, 2, 2.0);

            Suit = new EgoSuit(DerivedName, 20, 3, [0, 0, 0, 0, 0], RiskLevel, [0.8, 1.2, 0.8, 0.0]);

            Gift = new EgoGift(DerivedName, Slot.Hat, new SecondaryStats(HP:4,SR:2,WS:2));
        }

        internal override void WeaponEffect(Employee employee)
        {
            employee.SpecialEffects.Add("Dual Weapon");
        }
    }
}
