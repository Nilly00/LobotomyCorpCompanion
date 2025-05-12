using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LobotomyCorpCompanion.GameObjects.Abnormalities
{
    internal class Apocalypse : Abnormality
    {
        public Apocalypse()
        {
            name = "Apocalypse Bird";
            derivedName = "Twilight";
            riskLevel = RiskLevel.ALEPH;

            //todo special requirement
            weapon = new EgoWeapon(derivedName, 0, 1, [0, 0, 0, 0, 0], DamageType.SPECIAL, WeaponRange.Medium, riskLevel, 0, 0, AttackSpeed.Normal);
            //todo special requirement
            suit = new EgoSuit(derivedName, 0, 0, [0, 0, 0, 0, 0], riskLevel, [0.0, 0.0, 0.0, 0.0]);

            gift = new EgoGift("Through the Dark Twilight", Slot.Right_back, [7, 7, 7, 7, 7, 7]);
        }

        public override void WeaponEffect(Employee employee)
        {
            //todo a bunch of stuff
            employee.SpecialEffects.Add("");
        }

        public override void SuitEffect(Employee employee)
        {
            //todo a bunch of stuff
            employee.SpecialEffects.Add("");
        }
    }
}
