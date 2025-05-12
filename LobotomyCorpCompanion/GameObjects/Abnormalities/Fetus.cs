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
            name = "Nameless Fetus";
            derivedName = "Syrinx";
            riskLevel = RiskLevel.HE;

            weapon = new EgoWeapon(derivedName, 45, 1, [2, 0, 0, 0, 0], DamageType.WHITE, WeaponRange.Long, riskLevel, 3, 3, AttackSpeed.VeryFast);

            suit = new EgoSuit(derivedName, 45, 1, [0, 0, 3, 0, 0], riskLevel, [1.2, 0.5, 0.8, 1.5]);

            gift = new EgoGift(derivedName, Slot.Helmet, [-2, -2, 0, 0, 6, 6]);
        }

        public override void GiftEffect(Employee employee)
        {
            //todo special effect damage redution
        }
    }
}
