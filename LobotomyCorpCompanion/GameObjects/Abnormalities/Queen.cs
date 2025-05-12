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
            name = "Snow Queen";
            derivedName = "Frost Splinter";
            riskLevel = RiskLevel.HE;

            weapon = new EgoWeapon(derivedName, 35, 3, [0, 0, 0, 0, 0], DamageType.WHITE, WeaponRange.Medium, riskLevel, 6, 12, AttackSpeed.Fast);

            suit = new EgoSuit(derivedName, 35, 2, [2, 0, 0, 0, 0], riskLevel, [1.3, 0.6, 0.8, 1.5]);

            gift = new EgoGift("Those who know the Cruelty of Winter and the Aroma of Roses", Slot.Cheek, [6, 6, 0, 0, 0, 0]);
        }

        public override void WeaponEffect(Employee employee)
        {
            employee.SpecialEffects.Add("Reduces the Movement Speed of the target by 30% for 3 seconds");
        }
    }
}
