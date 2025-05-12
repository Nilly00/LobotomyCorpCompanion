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
            name = "Melting Love";
            derivedName = "Adoration";
            riskLevel = RiskLevel.ALEPH;

            weapon = new EgoWeapon(derivedName,222, 1, [0, 0, 5, 0, 5], DamageType.BLACK, WeaponRange.Long, riskLevel,22,44, AttackSpeed.Slow);

            suit = new EgoSuit(derivedName,120, 1, [5, 0, 0, 0, 5], riskLevel, [0.3, 0.6, 0.3, 1.0]);

            gift = new EgoGift(derivedName, Slot.Helmet, [5,10,-5,-5, 0, 0]);
        }

        public override void WeaponEffect(Employee employee)
        {
            employee.SpecialEffects.Add("Reduces the Movement Speed of the target by 30% for 3 seconds");
            employee.SpecialEffects.Add("Target takes 2 BLACK damage every second for 5 seconds");
        }


        public override void GiftEffect(Employee employee)
        {
            if(employee.suit == this)
            {
                employee.SpecialEffects.Add("When falling below 20% HP gain a 100 RED shield that lasts for 3 seconds. 12 Second Cooldown. Half MS while shielded");
            }
        }
    }
}
