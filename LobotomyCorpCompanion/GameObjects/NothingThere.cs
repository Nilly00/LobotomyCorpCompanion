using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LobotomyCorpCompanion.GameObjects.Abnormalities
{
    internal class NothingThere : Abnormality
    {
        public NothingThere()
        {
            name = "Nothing There";
            derivedName = "Mimicry";
            riskLevel = RiskLevel.ALEPH;

            weapon = new EgoWeapon(derivedName,222, 1, [5, 0, 0, 0, 5], DamageType.RED, WeaponRange.Medium, riskLevel,10,14, AttackSpeed.Fast);

            suit = new EgoSuit(derivedName,120, 1, [5, 0, 0, 0, 5], riskLevel, [0.2, 0.5, 0.5, 1.0]);

            gift = new EgoGift(derivedName, Slot.Cheek, [10, 0, 0, 0, 0, 0]);
        }

        public override void WeaponEffect(Employee employee)
        {
            employee.SpecialEffects.Add("Recover 25% of damage dealt to the target as HP");
        }

        public override void GiftEffect(Employee employee)
        {
            employee.SpecialEffects.Add("HP healing +5%");
        }
    }
}
