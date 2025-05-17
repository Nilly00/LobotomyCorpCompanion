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
            Name = "The Silent Orchestra";
            DerivedName = "Da Capo";
            RiskLevel = RiskLevel.ALEPH;

            Weapon = new EgoWeapon(DerivedName,222, 1, [0, 5, 0, 0, 5], DamageType.WHITE, RiskLevel, 4, 5, 1, 1.0);

            Suit = new EgoSuit(DerivedName, 120, 1, [0, 5, 0, 0, 5], RiskLevel, [0.5, 0.2, 0.5, 1.5]);

            Gift = new EgoGift(DerivedName, Slot.Eye, new SecondaryStats(SR:4,WS:4));
        }

        internal override void WeaponEffect(Employee employee)
        {
            employee.SpecialEffects.Add("Hits 4 times");
            employee.SpecialEffects.Add("40% chance to deal 16-18 Damage 3 times");
        }

        internal override void GiftEffect(Employee employee)
        {
            if(employee.suit == this)
            {
                //todo
                employee.SpecialEffects.Add("WHITE resist becomes -1");
            }
        }
    }
}
