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
            Name = "The Knight of Despair";
            DerivedName = "The Sword Sharpened with Tears";
            RiskLevel = RiskLevel.WAW;

            Weapon = new EgoWeapon(DerivedName, 70, 1, [0, 0, 0, 4, 0], DamageType.WHITE,RiskLevel, 9, 12, 1, 1.0);

            Suit = new EgoSuit(DerivedName, 60, 1, [0, 0, 0, 4, 0], RiskLevel, [0.8, 0.8, 0.8, 0.8]);

            Gift = new EgoGift(DerivedName, Slot.Cheek, new SecondaryStats(SP:2,AS:4,MS:4));
        }

        internal override void WeaponEffect(Employee employee)
        {
            employee.SpecialEffects.Add("25% chance to deal an additional 9-18 damage");
        }
    }
}