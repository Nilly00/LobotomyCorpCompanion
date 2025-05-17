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
            Name = "The King of Greed";
            DerivedName = "Gold Rush";
            RiskLevel = RiskLevel.WAW;

            Weapon = new EgoWeapon(DerivedName, 100, 1, [5, 0, 0, 0, 5], DamageType.RED, RiskLevel.ALEPH, 5, 6, 1, 1.0);

            Suit = new EgoSuit(DerivedName, 60, 1, [0, 0, 4, 0, 4], RiskLevel, [0.4, 0.7, 0.8, 2.0]);

            Gift = new EgoGift(DerivedName, Slot.Hand_1, new SecondaryStats(HP:6));
        }

        internal override void WeaponEffect(Employee employee)
        {
            employee.SpecialEffects.Add("On each attack, 10% chance to buff Min. and Max. Attack Power by +5 for 12 seconds and reduce Temperance by 50% for 120 seconds.");
            employee.SpecialEffects.Add("Hits 3 times");
            employee.SpecialEffects.Add("Special attack that deals 40-60 Damage");
        }

        internal override void GiftEffect(Employee employee)
        {
            employee.SpecialEffects.Add("INSTINCT SR +6%");
        }
    }
}
