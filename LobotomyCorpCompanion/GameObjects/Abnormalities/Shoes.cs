using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LobotomyCorpCompanion.GameObjects.Abnormalities
{
    internal class Shoes : Abnormality
    {
        public Shoes()
        {
            Name = "The Red Shoes";
            DerivedName = "Sanguine Desire";
            RiskLevel = RiskLevel.HE;

            Weapon = new EgoWeapon(DerivedName, 40, 2, [0, 0, 0, 0, 0], DamageType.RED, RiskLevel, 4, 7, 2, 1.0);

            Suit = new EgoSuit(DerivedName, 50, 1, [0, 0, 3, 0, 0], RiskLevel, [0.5, 1.2, 0.8, 1.5]);

            Gift = new EgoGift(DerivedName, Slot.Mouth_2, new SecondaryStats(HP:4));
        }

        internal override void WeaponEffect(Employee employee)
        {
            if (employee.ranks[2] > 3)
            {
                employee.permanentBoni.damageFlat += 4;
                employee.SpecialEffects.Add("take SP damage equal to 4% of Max. SP on each attack");
            }
        }

        internal override void GiftEffect(Employee employee)
        {
            if (employee.weapon == this)
            {
                employee.permanentBoni.secondaryStats.SR -= 10;
                employee.permanentBoni.secondaryStats.WS -= 10;
                employee.permanentBoni.secondaryStats.AS += 10;
            }
        }
    }
}
