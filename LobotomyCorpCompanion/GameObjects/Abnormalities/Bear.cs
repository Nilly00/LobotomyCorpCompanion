using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LobotomyCorpCompanion.GameObjects.Abnormalities
{
    internal class Bear : Abnormality
    {
        public Bear()
        {
            Name = "Happy Teddy Bear";
            DerivedName = "Bear Paws";
            RiskLevel = RiskLevel.HE;

            Weapon = new EgoWeapon(DerivedName, 40, 2, [2, 0, 0, 0, 0], DamageType.RED, RiskLevel, 6, 7, 1, 1.0);

            Suit = new EgoSuit(DerivedName, 30, 3, [0, 0, 0, 0, 2], RiskLevel, [0.8, 1.0, 1.0, 1.5]);

            Gift = new EgoGift(DerivedName, Slot.Hat, new SecondaryStats(SP:4));
        }

        internal override void WeaponEffect(Employee employee)
        {
            employee.SpecialEffects.Add("Dual Weapon");
        }

        internal override void GiftEffect(Employee employee)
        {
            employee.SpecialEffects.Add("ATTACHMENT work SR +3%");
        }
    }
}
