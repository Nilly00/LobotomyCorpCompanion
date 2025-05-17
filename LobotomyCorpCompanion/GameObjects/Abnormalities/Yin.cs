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
            Name = "Yin";
            DerivedName = "Discord";
            RiskLevel = RiskLevel.WAW;

            Weapon = new EgoWeapon(DerivedName,60, 2, [0, 0, 3, 0, 0], DamageType.BLACK, RiskLevel, 8,13, 1, 1.0);

            Suit = new EgoSuit(DerivedName,50, 2, [0, 0, 0, 3, 0], RiskLevel, [1.2, 0.8, 0.6, 1.5]);

            Gift = new EgoGift(DerivedName, Slot.Helmet, new SecondaryStats(HP:-10,SP:-10,AS:20,MS:20));
        }
        internal override void GiftEffect(Employee employee)
        {
            employee.SpecialEffects.Add("8% chance to heal as much as damage taken");
        }
    }
}
