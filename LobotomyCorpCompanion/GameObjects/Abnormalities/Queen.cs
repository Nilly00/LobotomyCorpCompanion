using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LobotomyCorpCompanion.GameObjects.Abnormalities
{
    internal class Queen : Abnormality
    {
        public Queen()
        {
            Name = "Snow Queen";
            DerivedName = "Frost Splinter";
            RiskLevel = RiskLevel.HE;

            Weapon = new EgoWeapon(DerivedName, 35, 3, [0, 0, 0, 0, 0], DamageType.WHITE, RiskLevel, 6, 12, 4, 1.5);

            Suit = new EgoSuit(DerivedName, 35, 2, [2, 0, 0, 0, 0], RiskLevel, [1.3, 0.6, 0.8, 1.5]);

            Gift = new EgoGift("Those who know the Cruelty of Winter and the Aroma of Roses", Slot.Cheek, new SecondaryStats(HP:6,SP:6));
        }

        internal override void WeaponEffect(Employee employee)
        {
            employee.SpecialEffects.Add("Reduces the Movement Speed of the target by 30% for 3 seconds");
        }
    }
}
