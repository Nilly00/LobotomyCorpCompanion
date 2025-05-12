using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LobotomyCorpCompanion.GameObjects.Abnormalities
{
    internal class Orchestra : Abnormality
    {
        public Orchestra()
        {
            name = "The Silent Orchestra";
            derivedName = "Da Capo";
            riskLevel = RiskLevel.ALEPH;

            weapon = new EgoWeapon(derivedName,222, 1, [0, 5, 0, 0, 5], DamageType.WHITE, WeaponRange.Medium, riskLevel, 4, 5, AttackSpeed.Fast);

            suit = new EgoSuit(derivedName, 120, 1, [0, 5, 0, 0, 5], riskLevel, [0.5, 0.2, 0.5, 1.5]);

            gift = new EgoGift(derivedName, Slot.Eye, [0, 0, 4, 4, 0, 0]);
        }

        public override void WeaponEffect(Employee employee)
        {
            employee.SpecialEffects.Add("Hits 4 times");
            employee.SpecialEffects.Add("40% chance to deal 16-18 Damage 3 times");
        }

        public override void GiftEffect(Employee employee)
        {
            if(employee.suit == this)
            {
                //todo
                employee.SpecialEffects.Add("WHITE resist becomes -1");
            }
        }
    }
}
