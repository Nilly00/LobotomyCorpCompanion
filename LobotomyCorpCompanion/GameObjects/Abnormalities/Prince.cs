using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LobotomyCorpCompanion.GameObjects.Abnormalities
{
    internal class Prince : Abnormality
    {
        public Prince()
        {
            Name = "The Little Prince";
            DerivedName = "Spore";
            RiskLevel = RiskLevel.WAW;

            Weapon = new EgoWeapon(DerivedName,50, 3, [0, 0, 2, 0, 2], DamageType.WHITE, RiskLevel, 8,16, 1, 1.0);

            Suit = new EgoSuit(DerivedName,50, 3, [0, 2, 0, 0, 2], RiskLevel, [0.8, 0.6, 1.2, 1.5]);

            Gift = new EgoGift(DerivedName, Slot.Hand_2, new SecondaryStats(SP:5,SR:2,WS:2));
        }

        internal override void WeaponEffect(Employee employee)
        {
            employee.SpecialEffects.Add("25% chance to make the target more vulnerable to WHITE damage");
        }

        internal override void SuitEffect(Employee employee)
        {
            employee.SpecialEffects.Add("");
        }

        internal override void GiftEffect(Employee employee)
        {
            employee.SpecialEffects.Add("");
        }
    }
}
