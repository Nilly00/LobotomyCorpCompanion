using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LobotomyCorpCompanion.GameObjects.Abnormalities
{
    internal class Apple : Abnormality
    {
        public Apple()
        {
            Name = "Snow White's Apple";
            DerivedName = "Green Stem";
            RiskLevel = RiskLevel.WAW;

            Weapon = new EgoWeapon(DerivedName, 50, 3, [0, 0, 3, 0, 0], DamageType.BLACK, RiskLevel, 8, 16, 1, 1.0);

            Suit = new EgoSuit(DerivedName, 50, 2, [0, 3, 0, 0, 0], RiskLevel, [0.8, 1.2, 0.6, 1.5]);

            Gift = new EgoGift(DerivedName, Slot.Brooch, new SecondaryStats(SP:6));
        }

        internal override void GiftEffect(Employee employee)
        {
            if(employee.weapon==this)
            {
                employee.permanentBoni.damageFlat += 5;
            }
        }
    }
}
