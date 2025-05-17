using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LobotomyCorpCompanion.GameObjects.Abnormalities
{
    internal class Porccubus : Abnormality
    {
        public Porccubus()
        {
            Name = "Porccubus";
            DerivedName = "Pleasure";
            RiskLevel = RiskLevel.HE;

            Weapon = new EgoWeapon(DerivedName, 45, 1, [0, 0, 3, 0, 0], DamageType.BLACK, RiskLevel, 1, 4, 1, 1.0);

            Suit = new EgoSuit(DerivedName, 30, 3, [0, 0, 0, 0, 0], RiskLevel, [1.2, 0.8, 0.8, 1.5]);

            Gift = new EgoGift(DerivedName, Slot.Neckwear, new SecondaryStats(SP:10,SR:-6,WS:-6));
        }

        internal override void WeaponEffect(Employee employee)
        {
            employee.SpecialEffects.Add("Deals 2 WHITE damage per second over 5 Seconds");
        }
    }
}
