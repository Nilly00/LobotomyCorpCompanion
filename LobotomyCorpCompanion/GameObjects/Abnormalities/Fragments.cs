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
            name = "Fragment of the Universe";
            derivedName = "Fragments from Somewhere";
            riskLevel = RiskLevel.TETH;

            weapon = new EgoWeapon(derivedName, 20, 3, [0, 0, 0, 0, 0], DamageType.BLACK, WeaponRange.Medium, riskLevel, 5, 9, AttackSpeed.Fast);

            suit = new EgoSuit(derivedName, 25, 2, [0, 0, 0, 0, 0], riskLevel, [1.0, 1.2, 0.6, 0.0]);

            gift = new EgoGift(derivedName, Slot.Brooch, [0, 0, 2, 2, 0, 0]);
        }

        public override void WeaponEffect(Employee employee)
        {
            if (employee.ranks[1] > 5)
            {
                employee.SpecialEffects.Add("On Hit 10% chance for +40% SP for 30 seconds");
            }
        }
    }
}
