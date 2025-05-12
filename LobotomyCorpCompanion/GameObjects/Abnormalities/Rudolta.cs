using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LobotomyCorpCompanion.GameObjects.Abnormalities
{
    internal class Rudolta : Abnormality
    {
        public Rudolta()
        {
            name = "Rudolta of the Sleigh";
            derivedName = "Christmas";
            riskLevel = RiskLevel.HE;

            weapon = new EgoWeapon(derivedName, 35, 3, [0, 0, 0, 0, 0], DamageType.WHITE, WeaponRange.Short, riskLevel, 11, 13, AttackSpeed.Normal);

            suit = new EgoSuit(derivedName, 40, 3, [2, 0, 0, 0, 0], riskLevel, [0.8, 0.6, 1.3, 1.5]);

            gift = new EgoGift(derivedName, Slot.Hat, [-4, 8, 0, 0, 0, 0]);
        }

        public override void GiftEffect(Employee employee)
        {
            employee.SpecialEffects.Add("");
        }
    }
}
