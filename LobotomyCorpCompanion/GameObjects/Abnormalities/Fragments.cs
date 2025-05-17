using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LobotomyCorpCompanion.GameObjects.Abnormalities
{
    internal class Fragments : Abnormality
    {
        public Fragments()
        {
            Name = "Fragment of the Universe";
            DerivedName = "Fragments from Somewhere";
            RiskLevel = RiskLevel.TETH;

            Weapon = new EgoWeapon(DerivedName, 20, 3, [0, 0, 0, 0, 0], DamageType.BLACK, RiskLevel, 5, 9, 4, 1.5);

            Suit = new EgoSuit(DerivedName, 25, 2, [0, 0, 0, 0, 0], RiskLevel, [1.0, 1.2, 0.6, 0.0]);

            Gift = new EgoGift(DerivedName, Slot.Brooch, new SecondaryStats(SR:2,WS:2));
        }

        internal override void WeaponEffect(Employee employee)
        {
            if (employee.ranks[1] > 5)
            {
                employee.SpecialEffects.Add("On Hit 10% chance for +40% SP for 30 seconds");
            }
        }
    }
}
