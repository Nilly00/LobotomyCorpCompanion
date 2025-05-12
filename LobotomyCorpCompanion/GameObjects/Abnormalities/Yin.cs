using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LobotomyCorpCompanion.GameObjects.Abnormalities
{
    internal class Yin : Abnormality
    {
        public Yin()
        {
            name = "Yin";
            derivedName = "Discord";
            riskLevel = RiskLevel.WAW;

            weapon = new EgoWeapon(derivedName,60, 2, [0, 0, 3, 0, 0], DamageType.BLACK, WeaponRange.Medium, riskLevel, 8,13, AttackSpeed.Fast);

            suit = new EgoSuit(derivedName,50, 2, [0, 0, 0, 3, 0], riskLevel, [1.2, 0.8, 0.6, 1.5]);

            gift = new EgoGift(derivedName, Slot.Helmet, [-10,-10, 0, 0,20,20]);
        }
        public override void GiftEffect(Employee employee)
        {
            employee.SpecialEffects.Add("8% chance to heal as much as damage taken");
        }
    }
}
