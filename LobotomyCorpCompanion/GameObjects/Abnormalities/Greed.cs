using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LobotomyCorpCompanion.GameObjects.Abnormalities
{
    internal class Greed : Abnormality
    {
        public Greed()
        {
            name = "The King of Greed";
            derivedName = "Gold Rush";
            riskLevel = RiskLevel.WAW;

            weapon = new EgoWeapon(derivedName, 100, 1, [5, 0, 0, 0, 5], DamageType.RED, WeaponRange.VeryShort, RiskLevel.ALEPH, 5, 6, AttackSpeed.Fast);

            suit = new EgoSuit(derivedName, 60, 1, [0, 0, 4, 0, 4], riskLevel, [0.4, 0.7, 0.8, 2.0]);

            gift = new EgoGift(derivedName, Slot.Hand_1, [6, 0, 0, 0, 0, 0]);
        }

        public override void WeaponEffect(Employee employee)
        {
            employee.SpecialEffects.Add("On each attack, 10% chance to buff Min. and Max. Attack Power by +5 for 12 seconds and reduce Temperance by 50% for 120 seconds.");
            employee.SpecialEffects.Add("Hits 3 times");
            employee.SpecialEffects.Add("Special attack that deals 40-60 Damage");
        }

        public override void GiftEffect(Employee employee)
        {
            employee.SpecialEffects.Add("INSTINCT SR +6%");
        }
    }
}
