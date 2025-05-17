using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LobotomyCorpCompanion.GameObjects.Abnormalities
{
    internal class White : Abnormality
    {
        public White()
        {
            Name = "White Night";
            DerivedName = "Paradise Lost";
            RiskLevel = RiskLevel.ALEPH;

            Weapon = new EgoWeapon(DerivedName, 0, 1, [5, 5, 5, 5, 5], DamageType.PALE, RiskLevel,22,28, 1, 1.0);

            Suit = new EgoSuit(DerivedName,333, 1, [5, 5, 5, 5, 5], RiskLevel, [0.5, 0.5, 0.5, 0.3]);

            Gift = new EgoGift(DerivedName, Slot.Left_back, new SecondaryStats(HP:10,SP:10,AS:10,MS:10));
        }

        internal override void WeaponEffect(Employee employee)
        {
            //todo a bunch of stuff
            employee.SpecialEffects.Add("");
        }

        internal override void SuitEffect(Employee employee)
        {
            //todo a bunch of stuff
            employee.SpecialEffects.Add("");
        }

        internal override void GiftEffect(Employee employee)
        {
            employee.SpecialEffects.Add("");
        }
    }
}
