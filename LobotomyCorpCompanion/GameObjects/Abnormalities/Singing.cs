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
            name = "Singing Machine";
            derivedName = "Harmony";
            riskLevel = RiskLevel.HE;

            weapon = new EgoWeapon(derivedName, 40, 2, [2, 0, 0, 0, 2], DamageType.WHITE, WeaponRange.Long, riskLevel, 30, 50, AttackSpeed.VerySlow);

            gift = new EgoGift(derivedName, Slot.Cheek, [8,-4, 0, 0, 0, 0]);
        }

        public override void WeaponEffect(Employee employee)
        {
            employee.SpecialEffects.Add("When above 10% HP consume 5% HP twice for +30% damage");
        }

        public override void GiftEffect(Employee employee)
        {
            employee.SpecialEffects.Add("Upon taking WHITE damage, recover 20% of the damage as SP and Attack Speed +10");
        }
    }
}
