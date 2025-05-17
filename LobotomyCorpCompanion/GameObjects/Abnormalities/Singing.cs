using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LobotomyCorpCompanion.GameObjects.Abnormalities
{
    internal class Singing : Abnormality
    {
        public Singing()
        {
            Name = "Singing Machine";
            DerivedName = "Harmony";
            RiskLevel = RiskLevel.HE;

            Weapon = new EgoWeapon(DerivedName, 40, 2, [2, 0, 0, 0, 2], DamageType.WHITE, RiskLevel, 30, 50, 15 ,5);

            Gift = new EgoGift(DerivedName, Slot.Cheek, new SecondaryStats(HP:8,SP:-4));
        }

        internal override void WeaponEffect(Employee employee)
        {
            employee.SpecialEffects.Add("When above 10% HP consume 5% HP twice for +30% damage");
            employee.conditionalBoni.damagePercent *= 1.3;
        }

        internal override void GiftEffect(Employee employee)
        {
            employee.SpecialEffects.Add("Upon taking WHITE damage, recover 20% of the damage as SP and Attack Speed +10");
            employee.conditionalBoni.secondaryStats.AS += 10;
        }
    }
}
