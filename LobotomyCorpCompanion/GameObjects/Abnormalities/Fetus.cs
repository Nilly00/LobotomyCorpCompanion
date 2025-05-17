using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LobotomyCorpCompanion.GameObjects.Abnormalities
{
    internal class Fetus : Abnormality
    {
        public Fetus()
        {
            Name = "Nameless Fetus";
            DerivedName = "Syrinx";
            RiskLevel = RiskLevel.HE;

            Weapon = new EgoWeapon(DerivedName, 45, 1, [2, 0, 0, 0, 0], DamageType.WHITE,RiskLevel, 3, 3, 10, 0.5);

            Suit = new EgoSuit(DerivedName, 45, 1, [0, 0, 3, 0, 0], RiskLevel, [1.2, 0.5, 0.8, 1.5]);

            Gift = new EgoGift(DerivedName, Slot.Helmet, new SecondaryStats(HP:-2,SP:-2,AS:6,MS:6));
        }

        internal override void GiftEffect(Employee employee)
        {
            //todo special effect damage redution
        }
    }
}
