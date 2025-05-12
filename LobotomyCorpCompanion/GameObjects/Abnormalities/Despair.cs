using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LobotomyCorpCompanion.GameObjects.Abnormalities
{
    internal class Despair : Abnormality
    {
        public Despair()
        {
            name = "The Knight of Despair";
            derivedName = "The Sword Sharpened with Tears";
            riskLevel = RiskLevel.WAW;

            weapon = new EgoWeapon(derivedName, 70, 1, [0, 0, 0, 4, 0], DamageType.WHITE, WeaponRange.Medium, riskLevel, 9, 12, AttackSpeed.Fast);

            suit = new EgoSuit(derivedName, 60, 1, [0, 0, 0, 4, 0], riskLevel, [0.8, 0.8, 0.8, 0.8]);

            gift = new EgoGift(derivedName, Slot.Cheek, [0, 2, 0, 0, 4, 4]);
        }

        public override void WeaponEffect(Employee employee)
        {
            employee.SpecialEffects.Add("25% chance to deal an additional 9-18 damage");
        }
    }
}