using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LobotomyCorpCompanion.GameObjects.Abnormalities
{
    internal class Apple : Abnormality
    {
        public Apple()
        {
            name = "Snow White's Apple";
            derivedName = "Green Stem";
            riskLevel = RiskLevel.WAW;

            weapon = new EgoWeapon(derivedName, 50, 3, [0, 0, 3, 0, 0], DamageType.BLACK, WeaponRange.Medium, riskLevel, 8, 16, AttackSpeed.Fast);

            suit = new EgoSuit(derivedName, 50, 2, [0, 3, 0, 0, 0], riskLevel, [0.8, 1.2, 0.6, 1.5]);

            gift = new EgoGift(derivedName, Slot.Brooch, [0, 6, 0, 0, 0, 0]);
        }

        public override void GiftEffect(Employee employee)
        {
            if(employee.weapon==this)
            {
                employee.damageBoni += 5;
            }
        }
    }
}
