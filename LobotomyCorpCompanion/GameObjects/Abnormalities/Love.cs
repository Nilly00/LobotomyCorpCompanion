using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LobotomyCorpCompanion.GameObjects.Abnormalities
{
    internal class Love : Abnormality
    {
        public Love()
        {
            Name = "Melting Love";
            DerivedName = "Adoration";
            RiskLevel = RiskLevel.ALEPH;

            Weapon = new EgoWeapon(DerivedName,222, 1, [0, 0, 5, 0, 5], DamageType.BLACK, RiskLevel,22,44, 1, 1.0);

            Suit = new EgoSuit(DerivedName,120, 1, [5, 0, 0, 0, 5], RiskLevel, [0.3, 0.6, 0.3, 1.0]);

            Gift = new EgoGift(DerivedName, Slot.Helmet, new SecondaryStats(HP:5,SP:10,SR:-5,WS:-5));
        }

        internal override void WeaponEffect(Employee employee)
        {
            employee.SpecialEffects.Add("Reduces the Movement Speed of the target by 30% for 3 seconds");
            employee.SpecialEffects.Add("Target takes 2 BLACK damage every second for 5 seconds");
        }


        internal override void GiftEffect(Employee employee)
        {
            if(employee.suit == this)
            {
                employee.SpecialEffects.Add("When falling below 20% HP gain a 100 RED shield that lasts for 3 seconds. 12 Second Cooldown. Half MS while shielded");
            }
        }
    }
}
