using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LobotomyCorpCompanion.GameObjects.Abnormalities
{
    internal class OneSin : Abnormality
    {

        public OneSin()
        {
            Name = "One Sin and Hundreds of Good Deeds";
            DerivedName = "Penitence";
            RiskLevel = RiskLevel.ZAYIN;

            Weapon = new EgoWeapon(DerivedName, 15 , 5, [0, 0, 0, 0, 0], DamageType.WHITE, RiskLevel, 5, 7, 3 ,2.0);

            Suit = new EgoSuit(DerivedName, 10, 5,[0, 0, 0, 0, 0], RiskLevel, [0.9, 0.8, 0.9, 2.0]);

            Gift = new EgoGift(DerivedName, Slot.Hat, new SecondaryStats(SP: 2));
        }

        internal override void WeaponEffect(Employee employee)
        {
            if (employee.ranks[3] > 2)
            {
                employee.SpecialEffects.Add("5% chance to recover 10 SP on attack");
            }
        }

        internal override void SuitEffect(Employee employee)
        {
            employee.SpecialEffects.Add("Heal SP +10 with a 5% chance upon receiving RED or BLACK damage");
        }

        internal override void GiftEffect(Employee employee)
        {
            employee.SpecialEffects.Add("Work Success Rate +10% with One Sin");
        }
    }
}
