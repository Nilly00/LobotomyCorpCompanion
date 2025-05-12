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
            name = "White Night";
            derivedName = "Paradise Lost";
            riskLevel = RiskLevel.ALEPH;

            weapon = new EgoWeapon(derivedName, 0, 1, [5, 5, 5, 5, 5], DamageType.PALE, WeaponRange.VeryLong, riskLevel,22,28, AttackSpeed.Fast);

            suit = new EgoSuit(derivedName,333, 1, [5, 5, 5, 5, 5], riskLevel, [0.5, 0.5, 0.5, 0.3]);

            gift = new EgoGift(derivedName, Slot.Left_back, [10,10, 0, 0,10,10]);
        }

        public override void WeaponEffect(Employee employee)
        {
            //todo a bunch of stuff
            employee.SpecialEffects.Add("");
        }

        public override void SuitEffect(Employee employee)
        {
            //todo a bunch of stuff
            employee.SpecialEffects.Add("");
        }

        public override void GiftEffect(Employee employee)
        {
            employee.SpecialEffects.Add("");
        }
    }
}
