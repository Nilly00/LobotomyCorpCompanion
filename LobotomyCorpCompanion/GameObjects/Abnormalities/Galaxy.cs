using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LobotomyCorpCompanion.GameObjects.Abnormalities
{
    internal class Galaxy : Abnormality
    {
        public Galaxy()
        {
            Name = "Child of the Galaxy";
            DerivedName = "Our Galaxy";
            RiskLevel = RiskLevel.HE;

            Weapon = new EgoWeapon(DerivedName, 45, 1, [0, 2, 0, 0, 2], DamageType.BLACK, RiskLevel, 9, 15, 8 ,2.0);

            Suit = new EgoSuit(DerivedName, 30, 3, [0, 0, 0, 0, 0], RiskLevel, [0.8, 0.8, 1.2, 1.5]);

            Gift = new EgoGift(DerivedName, Slot.Neckwear, new SecondaryStats(SR:3,WS:3));
        }


        internal override void SuitEffect(Employee employee)
        {
            employee.SpecialEffects.Add("Galaxy Child Pebble healing increased");
        }

        internal override void GiftEffect(Employee employee)
        {
            employee.SpecialEffects.Add("Periodically recover a small amount of HP");
        }
    }
}
